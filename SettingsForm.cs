using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVClient
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = FolderTestBox.Text;
            folderBrowserDialog1.ShowDialog();
            FolderTestBox.Text = folderBrowserDialog1.SelectedPath;

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            FolderTestBox.Text = MVSettings.Default.DefaultTestPath;
            ModelBox.Text = MVSettings.Default.ModelPath;
        }

        private void OpenZipFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ModelBox.Text = openFileDialog1.FileName;
        }

        private void TableLayout3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult UserConfirm = MessageBox.Show("Confirm your Settings?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (UserConfirm == DialogResult.OK)
            {
                MVSettings.Default.ModelPath = ModelBox.Text;
                MVSettings.Default.DefaultTestPath = FolderTestBox.Text;
                MVSettings.Default.Save();
                this.Close();
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
