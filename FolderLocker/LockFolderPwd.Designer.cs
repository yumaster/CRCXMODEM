namespace FolderLocker
{
    partial class LockFolderPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockFolderPwd));
            this.btnClose = new System.Windows.Forms.Button();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.txtLock = new System.Windows.Forms.TextBox();
            this.lblLockPwd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(294, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLock
            // 
            this.picLock.Image = ((System.Drawing.Image)(resources.GetObject("picLock.Image")));
            this.picLock.Location = new System.Drawing.Point(139, 3);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(92, 86);
            this.picLock.TabIndex = 8;
            this.picLock.TabStop = false;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(294, 33);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 21);
            this.btnLock.TabIndex = 7;
            this.btnLock.Text = "加锁";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // txtLock
            // 
            this.txtLock.Location = new System.Drawing.Point(16, 33);
            this.txtLock.Name = "txtLock";
            this.txtLock.Size = new System.Drawing.Size(262, 21);
            this.txtLock.TabIndex = 6;
            this.txtLock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLock_KeyDown);
            // 
            // lblLockPwd
            // 
            this.lblLockPwd.AutoSize = true;
            this.lblLockPwd.Location = new System.Drawing.Point(16, 17);
            this.lblLockPwd.Name = "lblLockPwd";
            this.lblLockPwd.Size = new System.Drawing.Size(65, 12);
            this.lblLockPwd.TabIndex = 5;
            this.lblLockPwd.Text = "加锁密码：";
            // 
            // LockFolderPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 93);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picLock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.txtLock);
            this.Controls.Add(this.lblLockPwd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockFolderPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件夹加锁";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox txtLock;
        private System.Windows.Forms.Label lblLockPwd;
    }
}