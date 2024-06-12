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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityProductEntities db = new DbEntityProductEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            var categories = db.Tbl_Category.ToList();
            dataGridView1.DataSource = categories;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Category c = new Tbl_Category();
            c.NAME = textBox2.Text;
            db.Tbl_Category.Add(c);
            db.SaveChanges();
            MessageBox.Show("Category added");
        }
    }
}
