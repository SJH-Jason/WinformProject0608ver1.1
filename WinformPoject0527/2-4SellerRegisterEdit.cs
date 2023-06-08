using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class SellerRegisterEdit : Form
    {
        public int _SellerID;
        string shipid;
        string payid;

        public SellerRegisterEdit()
        {
            InitializeComponent();
            this.Load += SellerRegisterEdit_Load;
        }

        private void SellerRegisterEdit_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            var query1 = new AppDbContext().ShippingMethods.Select(x => x.ShippingMethodName).ToList();
            foreach (var item in query1)
            {
                comboBox1.Items.Add(item);
            }

            var query2 = new AppDbContext().PaymentMethods.Select(x => x.PaymentMethodName).ToList();
            foreach (var item in query2)
            {
                comboBox2.Items.Add(item);
            }

            var db2 = new AppDbContext();
            var sellers = db2.Sellers.Find(_SellerID);
            txtAccount.Text = sellers.SellerAccount.ToString();
            txtPassword.Text = sellers.SellerPassword.ToString();
            txtName.Text = sellers.SellerName;
            txtSellerNo.Text = sellers.SellerNumber;
            txtPhone.Text = sellers.SellerPhone;
            txtAddress.Text = sellers.SellerAddress;
            shipid = sellers.ShipID;
            payid = sellers.PayID;

            var shipidname = new AppDbContext().ShippingMethods.Where(c => c.ShippingMethodId == shipid).Select(x => x.ShippingMethodName).FirstOrDefault();
            var payidname = new AppDbContext().PaymentMethods.Where(c => c.PaymentMethodId == payid).Select(x => x.PaymentMethodName).FirstOrDefault();

            comboBox1.Text = shipidname;
            comboBox2.Text = payidname;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //密碼補充設定
            string sellerpassword = txtPassword.Text;
            if (sellerpassword.Length < 4)
            {
                MessageBox.Show("請至少輸入4碼密碼");
                return;
            }
            else if (!Regex.IsMatch(sellerpassword, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("密碼只能包含英文字母和數字");
                return;
            }

            string sellerphone = txtPhone.Text;
            string selleraddress = txtAddress.Text;
            string ship = comboBox1.Text;
            string pay = comboBox2.Text;

            var itemship = new AppDbContext().ShippingMethods
                                        .Where(x => x.ShippingMethodName == ship)
                                        .Select(x => x.ShippingMethodId).FirstOrDefault();

            var itempay = new AppDbContext().PaymentMethods
                                        .Where(x => x.PaymentMethodName == pay)
                                        .Select(x => x.PaymentMethodId).FirstOrDefault();

            var db = new AppDbContext();
            var sellers = db.Sellers.Find(_SellerID);
            sellers.SellerPassword = sellerpassword;
            sellers.SellerPhone = sellerphone;
            sellers.SellerAddress = selleraddress;
            sellers.ShipID = itemship;
            sellers.PayID = itempay;

            db.SaveChanges();
            MessageBox.Show("修改完成!");
            Close();
        }
    }
}
