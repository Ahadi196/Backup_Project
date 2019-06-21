using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FujiFilmBackuprunner
{
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
            newMenuItem.PerformClick();
        }


        /* 
        * ================================================================
                                   MENU FILE
           ===============================================================
        */

            //NETSORE 1
        private void Netstore1MenuItem_Click(object sender, EventArgs e)
        {
            Form netstoreOne = new frmNetstore1();
            netstoreOne.MdiParent = this;
            netstoreOne.Show();
        }
            //NETSTORE 2
        private void Netstore2MenuItem_Click(object sender, EventArgs e)
        {
            Form netstoreTwo = new FrmNetstore2();
            netstoreTwo.MdiParent = this;
            netstoreTwo.Show();
        }
            //NETSTORE 3
        private void Netstore3MenuItem_Click(object sender, EventArgs e)
        {
            Form netstoreThree = new frmNetstore3();
            netstoreThree.MdiParent = this;
            netstoreThree.Show();
        }
            //NETSTORE 4
        private void Netstore4MenuItem_Click(object sender, EventArgs e)
        {
            Form netstoreFour = new FrmNetstore4();
            netstoreFour.MdiParent = this;
            netstoreFour.Show();
        }
            //EXTERNAL LOCATION
        private void ExternalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form external = new FrmExternal();
            external.MdiParent = this;
            external.Show();
        }
            // CLOSE ACTIVE CHILD
        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
            //EXIT APPLICATION
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            //CASCADE
        private void CascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
            //VERTICAL
        private void VerticalMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
            //HORIZONTAL
        private void HorizontalMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        /* 
        * ================================================================
                                   STRIP BAR
           ===============================================================
        */

        private void StripBtnNetOne_Click(object sender, EventArgs e)
        {
            Form netstoreOne = new frmNetstore1();
            netstoreOne.MdiParent = this;
            netstoreOne.Show();
        }

        private void StripBtnNetTwo_Click(object sender, EventArgs e)
        {
            Form netstoreTwo = new FrmNetstore2();
            netstoreTwo.MdiParent = this;
            netstoreTwo.Show();
        }

        private void StripBtnNetThree_Click(object sender, EventArgs e)
        {
            Form netstoreThree = new frmNetstore3();
            netstoreThree.MdiParent = this;
            netstoreThree.Show();
        }

        private void StripBtnExternal_Click(object sender, EventArgs e)
        {
            Form external = new FrmExternal();
            external.MdiParent = this;
            external.Show();
        }
    }
}