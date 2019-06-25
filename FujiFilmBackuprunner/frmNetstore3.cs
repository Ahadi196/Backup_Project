using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace FujiFilmBackuprunner
{
    public partial class frmNetstore3 : Form
    {
        public frmNetstore3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Process backup = new Process())
            {
                string fileName = "ipconfig.bat";
                string path = Path.Combine(Application.StartupPath, @"Net1Scripts\", fileName);
                Console.WriteLine(path);
                backup.StartInfo.FileName = "ipconfig";
                backup.StartInfo.UseShellExecute = false;
                backup.StartInfo.RedirectStandardOutput = true;
                backup.Start();
                txtlog.Text = backup.StandardOutput.ReadToEnd();
            }
        }
    }
}
