using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Product_Project
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        DbEntityProductEntities db = new DbEntityProductEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Product.ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Product p = new Tbl_Product();
            p.MARKA =TxtBrand.Text;
            p.PRODUCTID = TxtProduct.Text;
            p.STOCK = short.Parse(TxtStock.Text);
            p.CATEGORY = int.Parse(comboBox1.Text);
            p.PRICE = decimal.Parse(TxtPrice.Text);
            p.STATUS = true;
            db.Tbl_Product.Add(p);
            db.SaveChanges();
            MessageBox.Show("Product added to system");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(TxtId.Text);
            var pro = db.Tbl_Product.Find(b);
            db.Tbl_Product.Remove(pro);
            db.SaveChanges();
            MessageBox.Show("Product deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(TxtId.Text);
            var pro = db.Tbl_Product.Find(b);
            pro.PRODUCTID = TxtProduct.Text;
            pro.STOCK = short.Parse(TxtStock.Text);
            pro.MARKA =TxtBrand.Text;
            db.SaveChanges();
            MessageBox.Show("Product updated");
        }
    }
}
