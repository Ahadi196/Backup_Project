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
    public partial class frmNetstore1 : Form
    {
        public frmNetstore1()
        {
            InitializeComponent();
            
        }

        private void Btnbackup_Click(object sender, EventArgs e)
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
