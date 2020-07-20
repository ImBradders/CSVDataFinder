namespace CSVDataFinder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFileToUse = new System.Windows.Forms.Label();
            this.txtFileToUse = new System.Windows.Forms.TextBox();
            this.lblColumnToSearchThrough = new System.Windows.Forms.Label();
            this.txtColumnNumber = new System.Windows.Forms.TextBox();
            this.lblTextToSearchFor = new System.Windows.Forms.Label();
            this.txtTextToSearchFor = new System.Windows.Forms.TextBox();
            this.lblCaseSensitive = new System.Windows.Forms.Label();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.btnPerformSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dialogOpenFile
            // 
            this.dialogOpenFile.FileName = "dialogOpenFile";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(487, 25);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(94, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblFileToUse
            // 
            this.lblFileToUse.AutoSize = true;
            this.lblFileToUse.Location = new System.Drawing.Point(12, 7);
            this.lblFileToUse.Name = "lblFileToUse";
            this.lblFileToUse.Size = new System.Drawing.Size(75, 17);
            this.lblFileToUse.TabIndex = 1;
            this.lblFileToUse.Text = "File to Use";
            // 
            // txtFileToUse
            // 
            this.txtFileToUse.Location = new System.Drawing.Point(12, 26);
            this.txtFileToUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileToUse.Name = "txtFileToUse";
            this.txtFileToUse.Size = new System.Drawing.Size(469, 22);
            this.txtFileToUse.TabIndex = 2;
            // 
            // lblColumnToSearchThrough
            // 
            this.lblColumnToSearchThrough.AutoSize = true;
            this.lblColumnToSearchThrough.Location = new System.Drawing.Point(12, 66);
            this.lblColumnToSearchThrough.Name = "lblColumnToSearchThrough";
            this.lblColumnToSearchThrough.Size = new System.Drawing.Size(290, 17);
            this.lblColumnToSearchThrough.TabIndex = 1;
            this.lblColumnToSearchThrough.Text = "Column Number of Data to Search Through: ";
            // 
            // txtColumnNumber
            // 
            this.txtColumnNumber.Location = new System.Drawing.Point(322, 63);
            this.txtColumnNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColumnNumber.Name = "txtColumnNumber";
            this.txtColumnNumber.Size = new System.Drawing.Size(259, 22);
            this.txtColumnNumber.TabIndex = 2;
            // 
            // lblTextToSearchFor
            // 
            this.lblTextToSearchFor.AutoSize = true;
            this.lblTextToSearchFor.Location = new System.Drawing.Point(12, 103);
            this.lblTextToSearchFor.Name = "lblTextToSearchFor";
            this.lblTextToSearchFor.Size = new System.Drawing.Size(133, 17);
            this.lblTextToSearchFor.TabIndex = 1;
            this.lblTextToSearchFor.Text = "Text to Search For: ";
            // 
            // txtTextToSearchFor
            // 
            this.txtTextToSearchFor.Location = new System.Drawing.Point(152, 101);
            this.txtTextToSearchFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTextToSearchFor.Name = "txtTextToSearchFor";
            this.txtTextToSearchFor.Size = new System.Drawing.Size(429, 22);
            this.txtTextToSearchFor.TabIndex = 2;
            // 
            // lblCaseSensitive
            // 
            this.lblCaseSensitive.AutoSize = true;
            this.lblCaseSensitive.Location = new System.Drawing.Point(12, 141);
            this.lblCaseSensitive.Name = "lblCaseSensitive";
            this.lblCaseSensitive.Size = new System.Drawing.Size(209, 17);
            this.lblCaseSensitive.TabIndex = 1;
            this.lblCaseSensitive.Text = "Tick for Case Sensitive Search: ";
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(228, 140);
            this.chkCaseSensitive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(123, 21);
            this.chkCaseSensitive.TabIndex = 3;
            this.chkCaseSensitive.Text = "Case Sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btnPerformSearch
            // 
            this.btnPerformSearch.Location = new System.Drawing.Point(487, 138);
            this.btnPerformSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerformSearch.Name = "btnPerformSearch";
            this.btnPerformSearch.Size = new System.Drawing.Size(94, 23);
            this.btnPerformSearch.TabIndex = 0;
            this.btnPerformSearch.Text = "Start";
            this.btnPerformSearch.UseVisualStyleBackColor = true;
            this.btnPerformSearch.Click += new System.EventHandler(this.btnPerformSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 171);
            this.Controls.Add(this.btnPerformSearch);
            this.Controls.Add(this.chkCaseSensitive);
            this.Controls.Add(this.lblCaseSensitive);
            this.Controls.Add(this.txtTextToSearchFor);
            this.Controls.Add(this.lblTextToSearchFor);
            this.Controls.Add(this.txtColumnNumber);
            this.Controls.Add(this.lblColumnToSearchThrough);
            this.Controls.Add(this.txtFileToUse);
            this.Controls.Add(this.lblFileToUse);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "CSV Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPerformSearch;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.Label lblCaseSensitive;
        private System.Windows.Forms.Label lblColumnToSearchThrough;
        private System.Windows.Forms.Label lblFileToUse;
        private System.Windows.Forms.Label lblTextToSearchFor;
        private System.Windows.Forms.TextBox txtColumnNumber;
        private System.Windows.Forms.TextBox txtFileToUse;
        private System.Windows.Forms.TextBox txtTextToSearchFor;

        #endregion
    }
}