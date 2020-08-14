namespace FolderLocker
{
    partial class SetMainPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMainPwd));
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBoxOne = new System.Windows.Forms.PictureBox();
            this.linkLabelWhy = new System.Windows.Forms.LinkLabel();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtCheckPw = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lbl_EntryPwd = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(16, 129);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(353, 24);
            this.lbl_title.TabIndex = 15;
            this.lbl_title.Text = "使用初始密码一方面可以帮你您解锁忘记密码的文件夹，另一方面\r\n可以快速加锁您的文件夹而不需要输入单独的密码";
            // 
            // pictureBoxOne
            // 
            this.pictureBoxOne.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOne.Image")));
            this.pictureBoxOne.Location = new System.Drawing.Point(345, 16);
            this.pictureBoxOne.Name = "pictureBoxOne";
            this.pictureBoxOne.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOne.TabIndex = 14;
            this.pictureBoxOne.TabStop = false;
            // 
            // linkLabelWhy
            // 
            this.linkLabelWhy.AutoSize = true;
            this.linkLabelWhy.Location = new System.Drawing.Point(130, 90);
            this.linkLabelWhy.Name = "linkLabelWhy";
            this.linkLabelWhy.Size = new System.Drawing.Size(125, 12);
            this.linkLabelWhy.TabIndex = 13;
            this.linkLabelWhy.TabStop = true;
            this.linkLabelWhy.Text = "为什么要使用初始密码";
            this.linkLabelWhy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWhy_LinkClicked);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(261, 84);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "完成";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtCheckPw
            // 
            this.txtCheckPw.Location = new System.Drawing.Point(71, 57);
            this.txtCheckPw.Name = "txtCheckPw";
            this.txtCheckPw.PasswordChar = '*';
            this.txtCheckPw.Size = new System.Drawing.Size(265, 21);
            this.txtCheckPw.TabIndex = 11;
            this.txtCheckPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckPw_KeyDown);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(71, 19);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(265, 21);
            this.txtPasswd.TabIndex = 10;
            // 
            // lbl_EntryPwd
            // 
            this.lbl_EntryPwd.AutoSize = true;
            this.lbl_EntryPwd.Location = new System.Drawing.Point(12, 62);
            this.lbl_EntryPwd.Name = "lbl_EntryPwd";
            this.lbl_EntryPwd.Size = new System.Drawing.Size(53, 12);
            this.lbl_EntryPwd.TabIndex = 9;
            this.lbl_EntryPwd.Text = "再次输入";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 24);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 12);
            this.lblPwd.TabIndex = 8;
            this.lblPwd.Text = "输入密码";
            // 
            // SetMainPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 168);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBoxOne);
            this.Controls.Add(this.linkLabelWhy);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtCheckPw);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.lbl_EntryPwd);
            this.Controls.Add(this.lblPwd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetMainPwd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置初始密码";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetMainPwd_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBoxOne;
        private System.Windows.Forms.LinkLabel linkLabelWhy;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtCheckPw;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lbl_EntryPwd;
        private System.Windows.Forms.Label lblPwd;
    }
}