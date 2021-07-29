
namespace MVClient
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.TablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TableLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.OpenZipFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.FolderTestBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TablePanel1.SuspendLayout();
            this.TableLayout2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableLayout3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel1
            // 
            this.TablePanel1.ColumnCount = 1;
            this.TablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanel1.Controls.Add(this.TableLayout2, 0, 1);
            this.TablePanel1.Controls.Add(this.TableLayout3, 0, 0);
            this.TablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel1.Location = new System.Drawing.Point(0, 0);
            this.TablePanel1.Name = "TablePanel1";
            this.TablePanel1.RowCount = 2;
            this.TablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.7479F));
            this.TablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.2521F));
            this.TablePanel1.Size = new System.Drawing.Size(433, 147);
            this.TablePanel1.TabIndex = 0;
            // 
            // TableLayout2
            // 
            this.TableLayout2.ColumnCount = 2;
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.TableLayout2.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.TableLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout2.Location = new System.Drawing.Point(3, 105);
            this.TableLayout2.Name = "TableLayout2";
            this.TableLayout2.RowCount = 3;
            this.TableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayout2.Size = new System.Drawing.Size(427, 39);
            this.TableLayout2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.CancelBTN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OKBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBTN.Location = new System.Drawing.Point(3, 3);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(97, 28);
            this.CancelBTN.TabIndex = 0;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKBtn.Location = new System.Drawing.Point(106, 3);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(89, 28);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "Save";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select Test Folder Path";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // TableLayout3
            // 
            this.TableLayout3.ColumnCount = 2;
            this.TableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.41218F));
            this.TableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.58782F));
            this.TableLayout3.Controls.Add(this.OpenFolder, 0, 1);
            this.TableLayout3.Controls.Add(this.OpenZipFile, 0, 0);
            this.TableLayout3.Controls.Add(this.groupBox1, 1, 0);
            this.TableLayout3.Controls.Add(this.groupBox2, 1, 1);
            this.TableLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout3.Location = new System.Drawing.Point(3, 3);
            this.TableLayout3.Name = "TableLayout3";
            this.TableLayout3.RowCount = 2;
            this.TableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout3.Size = new System.Drawing.Size(427, 96);
            this.TableLayout3.TabIndex = 1;
            this.TableLayout3.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayout3_Paint);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFolder.Location = new System.Drawing.Point(3, 51);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(47, 42);
            this.OpenFolder.TabIndex = 0;
            this.OpenFolder.Text = "...";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // OpenZipFile
            // 
            this.OpenZipFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenZipFile.Location = new System.Drawing.Point(3, 3);
            this.OpenZipFile.Name = "OpenZipFile";
            this.OpenZipFile.Size = new System.Drawing.Size(47, 42);
            this.OpenZipFile.TabIndex = 1;
            this.OpenZipFile.Text = "...";
            this.OpenZipFile.UseVisualStyleBackColor = true;
            this.OpenZipFile.Click += new System.EventHandler(this.OpenZipFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModelBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(56, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trained Model Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FolderTestBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(56, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Folder Path";
            // 
            // ModelBox
            // 
            this.ModelBox.Enabled = false;
            this.ModelBox.Location = new System.Drawing.Point(6, 16);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(348, 20);
            this.ModelBox.TabIndex = 0;
            // 
            // FolderTestBox
            // 
            this.FolderTestBox.Enabled = false;
            this.FolderTestBox.Location = new System.Drawing.Point(6, 19);
            this.FolderTestBox.Name = "FolderTestBox";
            this.FolderTestBox.Size = new System.Drawing.Size(348, 20);
            this.FolderTestBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "ML Model Files|*zip|All Files|*.*\"";
            this.openFileDialog1.Title = "Select a Zip File with the Trained ML Model";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 147);
            this.Controls.Add(this.TablePanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.TablePanel1.ResumeLayout(false);
            this.TableLayout2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TableLayout3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanel1;
        private System.Windows.Forms.TableLayoutPanel TableLayout2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TableLayoutPanel TableLayout3;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Button OpenZipFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FolderTestBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}