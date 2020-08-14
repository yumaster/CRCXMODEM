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
    public partial class LockFolderPwd : Form
    {
        public LockFolderPwd()
        {
            InitializeComponent();
            this.btnClose.Hide();
            this.picLock.Hide();
            this.txtLock.Show();
            this.btnLock.Show();
        }
        private void Lock(string s1)
        {
            StreamWriter writer = new StreamWriter(s1 + @"\Dat");
            writer.WriteLine(this.txtLock.Text);
            writer.Close();
            DirectoryInfo info = new DirectoryInfo(s1);
            try
            {
                info.MoveTo(info.Parent.FullName + @"\" + info.Name + MainForm.Statu);
            }
            catch
            {
                MessageBox.Show("文件夹重名！");
                Application.Exit();
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            this.Lock(MainForm.tmPath);
            MainForm.showLock = true;
            this.lblLockPwd.Text = "加锁成功！";
            this.btnClose.Show();
            this.picLock.Show();
            this.txtLock.Hide();
            this.btnLock.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //在文本框输入回车时调用btnLock函数
        private void txtLock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnLock_Click(null, null);
            }
        }
    }
}
