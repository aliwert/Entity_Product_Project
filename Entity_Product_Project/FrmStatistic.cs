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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        DbEntityProductEntities db = new DbEntityProductEntities();

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Category.Count().ToString();
            label3.Text = db.Tbl_Product.Count().ToString();

            // sum
            label5.Text = db.Tbl_Customer.Count(a => a.STATUS == true).ToString();
            label7.Text = db.Tbl_Customer.Count(b => b.STATUS == false).ToString();


            
            label11.Text = db.Tbl_Product.Sum(a => a.STOCK).ToString();
            label9.Text = db.Tbl_Product.Count(i => i.CATEGORY == 1).ToString();
            label19.Text = db.Tbl_Sales.Sum(c => c.PRICE).ToString();
            label13.Text = (from d in db.Tbl_Product orderby d.PRICE descending select d.PRODUCTID).FirstOrDefault();
            label15.Text = (from x in db.Tbl_Product orderby x.PRICE ascending select x.PRODUCTID).FirstOrDefault();
            label17.Text = (from i in db.Tbl_Customer select i.CITY).Distinct().Count().ToString();
            label23.Text = db.Tbl_Product.Count(l => l.CATEGORY == 2).ToString();

        }
    }
}
