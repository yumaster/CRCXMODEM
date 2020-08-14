namespace FolderLocker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ckbtnUseInitPwd = new System.Windows.Forms.CheckBox();
            this.picOpen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbtnUseInitPwd
            // 
            this.ckbtnUseInitPwd.AutoSize = true;
            this.ckbtnUseInitPwd.Location = new System.Drawing.Point(48, 150);
            this.ckbtnUseInitPwd.Name = "ckbtnUseInitPwd";
            this.ckbtnUseInitPwd.Size = new System.Drawing.Size(96, 16);
            this.ckbtnUseInitPwd.TabIndex = 4;
            this.ckbtnUseInitPwd.Tag = "";
            this.ckbtnUseInitPwd.Text = "使用初始密码";
            this.ckbtnUseInitPwd.UseVisualStyleBackColor = true;
            // 
            // picOpen
            // 
            this.picOpen.Image = ((System.Drawing.Image)(resources.GetObject("picOpen.Image")));
            this.picOpen.Location = new System.Drawing.Point(39, 19);
            this.picOpen.Name = "picOpen";
            this.picOpen.Size = new System.Drawing.Size(117, 117);
            this.picOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpen.TabIndex = 3;
            this.picOpen.TabStop = false;
            this.toolTip1.SetToolTip(this.picOpen, "将文件夹拖动到窗口内即可加锁或解锁");
            this.picOpen.Click += new System.EventHandler(this.picOpen_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "本程序所有权归作者所有,对用户造成的一切后果由用户承担");
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 173);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbtnUseInitPwd);
            this.Controls.Add(this.picOpen);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件夹加密工具";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbtnUseInitPwd;
        private System.Windows.Forms.PictureBox picOpen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}