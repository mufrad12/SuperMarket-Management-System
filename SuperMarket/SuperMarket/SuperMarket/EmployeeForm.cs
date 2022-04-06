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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void product_mng_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductManagementForm().Show();
            this.Close();
        }

        private void user_mng_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerManagementForm().Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
