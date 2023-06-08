using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class SellerProductMain : Form
    {
        private int _SellerID;
        public SellerProductMain(int sellerid)
        {
            InitializeComponent();
            _SellerID = sellerid;
            this.Load += SellerProductMain_Load;
        }

        private void SellerProductMain_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            var db = new AppDbContext();
            var data3 = from p in db.Products
                        join q in db.ProductsStocks
                        on p.ProductID equals q.ProductID
                        select new
                        {
                            p.ProductID,
                            p.ProductName,
                            p.ProductPrice,
                            p.SellerID,
                            q.StockQuantity,
                            p.ProductOpen,
                        };
            this.dataGridView1.DataSource = data3.Where(c => c.SellerID == _SellerID).ToList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var _productid = new AppDbContext().Products.OrderByDescending(x => x.ProductID).Select(p => p.ProductID).FirstOrDefault();
            var pid = _productid + 1;

            using (var formB = new SellerProductAdd(pid, _SellerID))
            {
                formB.FormClosed += FormB_FormClosed;
                formB.ProductAddNew();
                formB.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int _productid = (int)row.Cells[0].Value;

            using (var formB = new SellerProductAdd(_productid, _SellerID))
            {
                formB.FormClosed += FormB_FormClosed;
                formB.ProductEdit(_productid, _SellerID);
                formB.ShowDialog();
            }
        }

        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Refresh the data in FormA here
            Display();
        }

        private void btnrenew_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
