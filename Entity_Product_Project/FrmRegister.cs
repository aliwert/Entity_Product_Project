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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityProductEntities db = new DbEntityProductEntities();
            var s = from a in db.Tbl_Admin where a.UserName == textBox1.Text && a.Password == textBox2.Text select a;
            if (s.Any())
            {
                FrmMain fr = new FrmMain();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
