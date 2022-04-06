using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void shop_mng_btn_Click(object sender, EventArgs e)
        {
            new ShopManagementForm().Show();
            this.Close();
        }

        private void emp_mng_btn_Click(object sender, EventArgs e)
        {
            new EmployeeManagementForm().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminManagementForm().Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
