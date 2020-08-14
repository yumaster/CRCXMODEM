using Microsoft.Win32;
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
    public partial class MainForm : Form
    {
        public static string pw;
        public static bool showFolder = false;
        public static bool showLock = true;
        public static string Statu = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
        public static string tmPath;
        public MainForm()
        {
            if ((Environment.OSVersion.Version.Major < 6) && (MessageBox.Show("该软件只适用于Windows Vista以上版本，继续使用将不能保护您加锁的文件夹！\n是否继续使用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No))
            {
                base.Close();
            }
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\LockFolder", true);
            if (key == null)
            {
                base.Hide();
                Application.Run(new SetMainPwd());
            }
            else
            {
                pw = key.GetValue("PASSWORD").ToString();
            }
        }

        private void picOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("将要加锁或解锁的文件夹拖放到这把锁上即可加锁或解锁", "帮助", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (Directory.Exists(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString()))
            {
                tmPath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                this.ckbtnUseInitPwd.Text = "已成功添加";
                if (this.IsLock(tmPath))
                {
                    new UnLockFolder().Show();
                }
                else if (this.ckbtnUseInitPwd.Checked)
                {
                    StreamWriter writer = new StreamWriter(tmPath + @"\Dat");
                    writer.WriteLine(pw);
                    writer.Close();
                    DirectoryInfo info = new DirectoryInfo(tmPath);
                    info.MoveTo(info.Parent.FullName + @"\" + info.Name + Statu);
                }
                else
                {
                    new LockFolderPwd().Show();
                }
            }
        }
        private bool IsLock(string folderPath)
        {
            bool flag = false;
            if (Directory.Exists(folderPath))
            {
                foreach (string str in folderPath.Split(new char[] { '-' }))
                {
                    if (str == "00c04f60b9f0}")
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
