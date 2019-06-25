using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FujiFilmBackuprunner
{
    public partial class FrmExternal : Form
    {
        public FrmExternal()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filename = openFile.FileName;

                filename_txt.Text = filename;
            }
        }

        private void Btn_backup_Click(object sender, EventArgs e)
        {
            using (Process test = new Process())
            {
                test.StartInfo.FileName = filename_txt.Text;
                test.StartInfo.UseShellExecute = false;
                test.StartInfo.RedirectStandardOutput = true;
                test.Start();
                txtlog.Text = test.StandardOutput.ReadToEnd();
            }
        }
    }
}
