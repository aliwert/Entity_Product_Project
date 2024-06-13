﻿using System;
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
            label5.Text = db.Tbl_Customer.Count().ToString();
        }
    }
}
