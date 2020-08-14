using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderLocker
{
    public partial class UnLockFolder : Form
    {
        public UnLockFolder()
        {
            InitializeComponent();
            this.btnDone.Hide();
            this.picUnLock.Hide();
            this.txtUnLock.Show();
            this.btnUnLock.Show();
            base.Height = 125;
            if (!File.Exists(MainForm.tmPath + @"\Dat"))
            {
                MessageBox.Show("该文件夹挪动过位置，为保护文件,您无法解锁", "警告", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }

        }
        private Boolean UnLock(string s2)
        {
            string path = s2 + @"\Dat";
            StreamReader reader = new StreamReader(path);
            string str2 = reader.ReadLine();
            reader.Close();
            if (!(str2 == this.txtUnLock.Text) && !(this.txtUnLock.Text == MainForm.pw))
            {
                MessageBox.Show("您输入的密码有误，无法解锁！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtUnLock.Text = "";
                return false;
            }
            else
            {
                File.Delete(path);
                DirectoryInfo info = new DirectoryInfo(s2);
                string[] strArray = info.Name.ToString().Split(new char[] { '.' });
                info.MoveTo(info.Parent.FullName + @"\" + strArray[0]);
                this.lblUnlock.Text = "解锁成功！";
                this.btnDone.Show();
                this.txtUnLock.Hide();
                this.linkForgetPwd.Hide();
                this.btnUnLock.Hide();
                this.picUnLock.Show();
                return true;
            }
        }
        
        ///在文本框输入回车时调用btnLock函数
        private void txtUnLock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnUnLock_Click(null, null);
            }
        }
        
        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (!this.UnLock(MainForm.tmPath))
                return;
            MainForm.showLock = true;
            this.lblUnlock.Text = "解锁成功！";
            this.btnDone.Show();
            this.picUnLock.Show();
            this.txtUnLock.Hide();
            this.btnUnLock.Hide();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (base.Height == 125)
                base.Height = 150;
            else if (base.Height == 150)
                base.Height = 125;
        }

    }
}
