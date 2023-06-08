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

namespace WinformPoject0527
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void toolStripButtonuser_Click(object sender, EventArgs e)
        {
            var frm = new BuyerLogin();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void toolStripButtonseller_Click(object sender, EventArgs e)
        {
            var frm=new SellerLogin();
            frm.MdiParent = this;
            frm.WindowState= FormWindowState.Maximized;
            frm.Show();
        }

        private void toolStripButtonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public static class ImgLink
    {
        /// <summary>
        /// 請輸入對應商品的ProductID，組成圖片連結
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string Imglink(int id)
        {
            string varImageName = $"{id}"; // Your variable name
            string extension = ".jpg"; // The extension of your file
            string targetPath = @"C:\Users\User\Desktop\WinformProject0607ver1.0-master\img";
            string fullPath = Path.Combine(targetPath, varImageName + extension);
            return fullPath;
        }

        /// <summary>
        /// 回傳初始商品的圖片(圖號0的商品圖)
        /// </summary>
        /// <returns></returns>
        public static string Imglink0()
        {
            return @"C:\Users\User\Desktop\WinformProject0607ver1.0-master\img\0.jpg";
        }

        /// <summary>
        /// 存取圖片路徑連結
        /// </summary>
        /// <returns></returns>
        public static string Imglinksave() 
        { 
           return @"C:\Users\User\Desktop\WinformProject0607ver1.0-master\img";
        }
    }

}
