using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");




        private void submit_btn_Click(object sender, EventArgs e)
        {

            if (emp_radio_btn.Checked == true)
            {
                if ((!emp_radio_btn.Checked || !emp_radio_btn.Checked) && (tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != null))
                {
                    sq.Open();
                    SqlCommand sC = new SqlCommand("insert into Employees values ('" + tb_name.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "')", sq);
                    sC.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successful");
                    sq.Close();

                }

                else
                {
                    MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (user_radio_btn.Checked == true)
            {
                if ((!user_radio_btn.Checked || !user_radio_btn.Checked) && (tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != null))
                {
                    sq.Open();
                    SqlCommand sD = new SqlCommand("insert into Customers values ('" + tb_name.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "')", sq);
                    sD.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successful");
                    sq.Close();

                }
                else
                {
                    MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (emp_radio_btn.Checked == false && user_radio_btn.Checked == false)
            {
                MessageBox.Show("Type is Required");
            }

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            tb_name.Text = tb_username.Text = tb_pass.Text = "";
        
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
