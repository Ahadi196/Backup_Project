namespace FujiFilmBackuprunner
{
    partial class frmStartUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartUp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netstore1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netstore2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netstore3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netstore4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripBtnNetOne = new System.Windows.Forms.ToolStripButton();
            this.stripBtnNetTwo = new System.Windows.Forms.ToolStripButton();
            this.stripBtnNetThree = new System.Windows.Forms.ToolStripButton();
            this.stripBtnExternal = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.toolStripSeparator1,
            this.closeMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netstore1MenuItem,
            this.netstore2MenuItem,
            this.netstore3MenuItem,
            this.netstore4MenuItem,
            this.externalToolStripMenuItem});
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newMenuItem.Text = "New";
            this.newMenuItem.ToolTipText = "New Backup";
            // 
            // netstore1MenuItem
            // 
            this.netstore1MenuItem.Name = "netstore1MenuItem";
            this.netstore1MenuItem.Size = new System.Drawing.Size(128, 22);
            this.netstore1MenuItem.Text = "Netstore 1";
            this.netstore1MenuItem.ToolTipText = "Netstore 1 Backup";
            this.netstore1MenuItem.Click += new System.EventHandler(this.Netstore1MenuItem_Click);
            // 
            // netstore2MenuItem
            // 
            this.netstore2MenuItem.Name = "netstore2MenuItem";
            this.netstore2MenuItem.Size = new System.Drawing.Size(128, 22);
            this.netstore2MenuItem.Text = "Netstore 2";
            this.netstore2MenuItem.ToolTipText = "Netstore 2 Backup";
            this.netstore2MenuItem.Click += new System.EventHandler(this.Netstore2MenuItem_Click);
            // 
            // netstore3MenuItem
            // 
            this.netstore3MenuItem.Name = "netstore3MenuItem";
            this.netstore3MenuItem.Size = new System.Drawing.Size(128, 22);
            this.netstore3MenuItem.Text = "Netstore 3";
            this.netstore3MenuItem.ToolTipText = "Netstore 3 Backup";
            this.netstore3MenuItem.Click += new System.EventHandler(this.Netstore3MenuItem_Click);
            // 
            // netstore4MenuItem
            // 
            this.netstore4MenuItem.Name = "netstore4MenuItem";
            this.netstore4MenuItem.Size = new System.Drawing.Size(128, 22);
            this.netstore4MenuItem.Text = "Netstore 4";
            this.netstore4MenuItem.ToolTipText = "Netstore 4 Backup";
            this.netstore4MenuItem.Click += new System.EventHandler(this.Netstore4MenuItem_Click);
            // 
            // externalToolStripMenuItem
            // 
            this.externalToolStripMenuItem.Name = "externalToolStripMenuItem";
            this.externalToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.externalToolStripMenuItem.Text = "External";
            this.externalToolStripMenuItem.ToolTipText = "External Backup";
            this.externalToolStripMenuItem.Click += new System.EventHandler(this.ExternalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.ToolTipText = "Close Active Backup";
            this.closeMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.ToolTipText = "Exit Application";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeMenuItem,
            this.verticalMenuItem,
            this.horizontalMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // cascadeMenuItem
            // 
            this.cascadeMenuItem.Name = "cascadeMenuItem";
            this.cascadeMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeMenuItem.Text = "Cascade";
            this.cascadeMenuItem.ToolTipText = "Cascade Window";
            this.cascadeMenuItem.Click += new System.EventHandler(this.CascadeMenuItem_Click);
            // 
            // verticalMenuItem
            // 
            this.verticalMenuItem.Name = "verticalMenuItem";
            this.verticalMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalMenuItem.Text = "Vertical";
            this.verticalMenuItem.ToolTipText = "Vertical Window";
            this.verticalMenuItem.Click += new System.EventHandler(this.VerticalMenuItem_Click);
            // 
            // horizontalMenuItem
            // 
            this.horizontalMenuItem.Name = "horizontalMenuItem";
            this.horizontalMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalMenuItem.Text = "Horizontal";
            this.horizontalMenuItem.ToolTipText = "Horiontal Window";
            this.horizontalMenuItem.Click += new System.EventHandler(this.HorizontalMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripBtnNetOne,
            this.stripBtnNetTwo,
            this.stripBtnNetThree,
            this.stripBtnExternal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stripBtnNetOne
            // 
            this.stripBtnNetOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripBtnNetOne.Image = ((System.Drawing.Image)(resources.GetObject("stripBtnNetOne.Image")));
            this.stripBtnNetOne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripBtnNetOne.Name = "stripBtnNetOne";
            this.stripBtnNetOne.Size = new System.Drawing.Size(65, 22);
            this.stripBtnNetOne.Text = "Netstore 1";
            this.stripBtnNetOne.ToolTipText = "Back up for Netstore 1";
            this.stripBtnNetOne.Click += new System.EventHandler(this.StripBtnNetOne_Click);
            // 
            // stripBtnNetTwo
            // 
            this.stripBtnNetTwo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripBtnNetTwo.Image = ((System.Drawing.Image)(resources.GetObject("stripBtnNetTwo.Image")));
            this.stripBtnNetTwo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripBtnNetTwo.Name = "stripBtnNetTwo";
            this.stripBtnNetTwo.Size = new System.Drawing.Size(65, 22);
            this.stripBtnNetTwo.Text = "Netstore 2";
            this.stripBtnNetTwo.ToolTipText = "Back up for Netstore 2";
            this.stripBtnNetTwo.Click += new System.EventHandler(this.StripBtnNetTwo_Click);
            // 
            // stripBtnNetThree
            // 
            this.stripBtnNetThree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripBtnNetThree.Image = ((System.Drawing.Image)(resources.GetObject("stripBtnNetThree.Image")));
            this.stripBtnNetThree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripBtnNetThree.Name = "stripBtnNetThree";
            this.stripBtnNetThree.Size = new System.Drawing.Size(65, 22);
            this.stripBtnNetThree.Text = "Netstore 3";
            this.stripBtnNetThree.ToolTipText = "Back up for Netstore 3";
            this.stripBtnNetThree.Click += new System.EventHandler(this.StripBtnNetThree_Click);
            // 
            // stripBtnExternal
            // 
            this.stripBtnExternal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stripBtnExternal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripBtnExternal.Image = ((System.Drawing.Image)(resources.GetObject("stripBtnExternal.Image")));
            this.stripBtnExternal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripBtnExternal.Name = "stripBtnExternal";
            this.stripBtnExternal.Size = new System.Drawing.Size(52, 22);
            this.stripBtnExternal.Text = "External";
            this.stripBtnExternal.ToolTipText = "Backup to Exteral location";
            this.stripBtnExternal.Click += new System.EventHandler(this.StripBtnExternal_Click);
            // 
            // frmStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmStartUp";
            this.Text = "Fuji Film Weekly Backup Runner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netstore1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem netstore2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem netstore3MenuItem;
        private System.Windows.Forms.ToolStripMenuItem netstore4MenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripBtnNetOne;
        private System.Windows.Forms.ToolStripButton stripBtnNetTwo;
        private System.Windows.Forms.ToolStripButton stripBtnNetThree;
        private System.Windows.Forms.ToolStripButton stripBtnExternal;
    }
}

