namespace FolderLocker
{
    partial class UnLockFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnLockFolder));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.linkForgetPwd = new System.Windows.Forms.LinkLabel();
            this.picUnLock = new System.Windows.Forms.PictureBox();
            this.txtUnLock = new System.Windows.Forms.TextBox();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.lblUnlock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUnLock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 12);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "★您可以使用初始密码解锁";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(294, 65);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 17;
            this.btnDone.Text = "退出";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // linkForgetPwd
            // 
            this.linkForgetPwd.AutoSize = true;
            this.linkForgetPwd.Location = new System.Drawing.Point(231, 38);
            this.linkForgetPwd.Name = "linkForgetPwd";
            this.linkForgetPwd.Size = new System.Drawing.Size(53, 12);
            this.linkForgetPwd.TabIndex = 16;
            this.linkForgetPwd.TabStop = true;
            this.linkForgetPwd.Text = "忘记密码";
            this.linkForgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPwd_LinkClicked);
            // 
            // picUnLock
            // 
            this.picUnLock.Image = ((System.Drawing.Image)(resources.GetObject("picUnLock.Image")));
            this.picUnLock.Location = new System.Drawing.Point(132, 8);
            this.picUnLock.Name = "picUnLock";
            this.picUnLock.Size = new System.Drawing.Size(92, 86);
            this.picUnLock.TabIndex = 15;
            this.picUnLock.TabStop = false;
            // 
            // txtUnLock
            // 
            this.txtUnLock.Location = new System.Drawing.Point(18, 33);
            this.txtUnLock.Name = "txtUnLock";
            this.txtUnLock.PasswordChar = '*';
            this.txtUnLock.Size = new System.Drawing.Size(270, 21);
            this.txtUnLock.TabIndex = 14;
            this.txtUnLock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnLock_KeyDown);
            // 
            // btnUnLock
            // 
            this.btnUnLock.Location = new System.Drawing.Point(294, 34);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(75, 21);
            this.btnUnLock.TabIndex = 13;
            this.btnUnLock.Text = "解锁";
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // lblUnlock
            // 
            this.lblUnlock.AutoSize = true;
            this.lblUnlock.Location = new System.Drawing.Point(16, 18);
            this.lblUnlock.Name = "lblUnlock";
            this.lblUnlock.Size = new System.Drawing.Size(89, 12);
            this.lblUnlock.TabIndex = 12;
            this.lblUnlock.Text = "输入解锁密码：";
            // 
            // UnLockFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 118);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.linkForgetPwd);
            this.Controls.Add(this.picUnLock);
            this.Controls.Add(this.txtUnLock);
            this.Controls.Add(this.btnUnLock);
            this.Controls.Add(this.lblUnlock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnLockFolder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "解锁文件夹";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picUnLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.LinkLabel linkForgetPwd;
        private System.Windows.Forms.PictureBox picUnLock;
        private System.Windows.Forms.TextBox txtUnLock;
        private System.Windows.Forms.Button btnUnLock;
        private System.Windows.Forms.Label lblUnlock;
    }
}