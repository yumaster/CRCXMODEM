using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderLocker
{
    public partial class SetMainPwd : Form
    {
        public SetMainPwd()
        {
            InitializeComponent();
            //设置窗口的高度，遮挡住Label3
            base.Height = 150;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (this.txtPasswd.Text.Length < 5)
            {
                MessageBox.Show("您输入的密码太短，请重新输入！");
                this.txtPasswd.Text = "";
                this.txtCheckPw.Text = "";
            }
            else if (!(this.txtPasswd.Text != this.txtCheckPw.Text))
            {
                Registry.CurrentUser.CreateSubKey(@"Software\LockFolder").SetValue("PASSWORD", this.txtCheckPw.Text);
                base.Hide();
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("密码不一致，请重新输入");
                this.txtPasswd.Text = "";
                this.txtCheckPw.Text = "";
            }
        }

        private void txtCheckPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnDone_Click(null, null);
            }
        }

        private void linkLabelWhy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (base.Height == 150)
                base.Height = 200;
            else if (base.Height == 200)
                base.Height = 150;
        }

        private void SetMainPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            //避免在未设置初始密码时调用MainForm窗口
            Application.Exit();
        }
    }
}
