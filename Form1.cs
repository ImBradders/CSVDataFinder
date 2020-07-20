using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVDataFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = dialogOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileToUse.Text = dialogOpenFile.FileName;
            }
        }

        private void btnPerformSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateEntries())
                return;

            string[] fileLines = LoadFile(txtFileToUse.Text);
            if (fileLines == null)
                return;
            
            string[] dataToSearchThrough = GetColumnData(fileLines, int.Parse(txtColumnNumber.Text));
            if (dataToSearchThrough == null)
                return;
            
            int occurrences = SearchData(dataToSearchThrough, txtTextToSearchFor.Text, chkCaseSensitive.Checked);

            MessageBox.Show("The text \"" + txtTextToSearchFor.Text +
                            "\" appeared " + occurrences + " times in column " + txtColumnNumber.Text + 
                            " in file " + txtFileToUse.Text,
                            "Results");
        }

        private int SearchData(string[] dataToSearchThrough, string dataToFind, bool caseSensitive)
        {
            int count = 0;
            foreach (string line in dataToSearchThrough)
            {
                if (caseSensitive)
                {
                    if (line.Contains(dataToFind))
                        count++;
                }
                else
                {
                    if (line.ToLower().Contains(dataToFind.ToLower()))
                        count++;
                }
            }

            return count;
        }

        private string[] GetColumnData(string[] lines, int columnNumber)
        {
            List<string> rows = new List<string>();
            if (!TestColNumber(lines[0], columnNumber))
                return null;

            foreach (string line in lines)
            {
                string[] splitLine = line.Split(',');
                rows.Add(splitLine[columnNumber - 1]);
            }

            return rows.ToArray();
        }

        private bool TestColNumber(string data, int columnNumber)
        {
            string[] dataSize = data.Split(',');
            if (columnNumber > dataSize.Length - 1)
            {
                MessageBox.Show("Column number entered is greater than the number of columns in the file.", 
                    "PEBCAK");
                return false;
            }

            return true;
        }

        private string[] LoadFile(string filePath)
        {
            StreamReader reader = null;
            List<string> lines = new List<string>();
            try
            {
                reader = new StreamReader(filePath);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            catch (IOException ioException)
            {
                MessageBox.Show("Issue while reading from file.\n\n" + ioException.Message, 
                    "Big Scary Error Message");
                return null;
            }
            finally
            {
                reader?.Close();
            }

            return lines.ToArray();
        }

        private bool ValidateEntries()
        {
            #region txtFileToUse
            if (txtFileToUse.Text == "")
            {
                MessageBox.Show("Please enter the path of a file to use or select a file using the button.", "PEBCAK");
                return false;
            }
            if (!File.Exists(txtFileToUse.Text))
            {
                MessageBox.Show("File entered does not exist.", "PEBCAK");
                return false;
            }
            if (!txtFileToUse.Text.EndsWith(".csv"))
            {
                MessageBox.Show("This application is only designed to work with .csv (comma separated values) files.",
                    "PEBCAK");
                return false;
            }
            #endregion
            
            #region txtColumnNumber
            if (txtColumnNumber.Text == "")
            {
                MessageBox.Show("Please enter the comlumn number containing the data that you wish to search through.", 
                    "PEBCAK");
                return false;
            }
            int colNum;
            if (!int.TryParse(txtColumnNumber.Text, out colNum))
            {
                MessageBox.Show("Please ensure that a whole number is entered " +
                                "for the column number of the data you wish to search through.", 
                    "PEBCAK");
                return false;
            }
            if (colNum < 1)
            {
                MessageBox.Show("Please ensure that a positive number is entered " +
                                "for the column number of the data you wish to search through.", 
                    "PEBCAK");
                return false;
            }
            #endregion

            #region txtTextToSearchFor
            if (txtTextToSearchFor.Text == "")
            {
                MessageBox.Show("Please enter some data that you wish to search for.", "PEBCAK");
                return false;
            }
            #endregion

            return true;
        }
    }
}