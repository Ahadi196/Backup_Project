namespace FujiFilmBackuprunner
{
    partial class FrmExternal
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.filename_txt = new System.Windows.Forms.TextBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "External Location";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(12, 48);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // filename_txt
            // 
            this.filename_txt.Location = new System.Drawing.Point(93, 51);
            this.filename_txt.Name = "filename_txt";
            this.filename_txt.Size = new System.Drawing.Size(224, 20);
            this.filename_txt.TabIndex = 2;
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(12, 77);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(305, 23);
            this.btn_backup.TabIndex = 3;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.Btn_backup_Click);
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(12, 106);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(305, 195);
            this.txtlog.TabIndex = 4;
            // 
            // FrmExternal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 313);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.filename_txt);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.label1);
            this.Name = "FrmExternal";
            this.Text = "External Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox filename_txt;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.TextBox txtlog;
    }
}