namespace FujiFilmBackuprunner
{
    partial class frmNetstore1
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
            this.btnbackup = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbackup
            // 
            this.btnbackup.Location = new System.Drawing.Point(12, 48);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(305, 23);
            this.btnbackup.TabIndex = 0;
            this.btnbackup.Text = "Back up ";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.Btnbackup_Click);
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(12, 77);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(305, 224);
            this.txtlog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Netstore 1 Backup";
            // 
            // frmNetstore1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.btnbackup);
            this.Name = "frmNetstore1";
            this.Text = "Netstore 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Label label1;
    }
}