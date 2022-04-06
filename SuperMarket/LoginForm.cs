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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if ((tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != ""))
            {
                SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");
                string query = " Select * from Admins Where Username = '" + tb_username.Text + "' and Password ='" + tb_pass.Text + "' ";
                SqlDataAdapter sdB = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdB.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new AdminForm().Show();
                    sq.Close();
                }


            }

            if ((tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != ""))
            {
                SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");
                string query = " Select * from Employees Where Username = '" + tb_username.Text + "' and Password ='" + tb_pass.Text + "' ";
                SqlDataAdapter sdA = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdA.Fill(dt);


                if (dt.Rows.Count == 1)
                {

                    {
                        this.Hide();
                        new EmployeeForm().Show();
                        sq.Close();
                    }


                }
            }



            if ((tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != ""))
            {
                SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");
                string query = " Select * from Customers Where Username = '" + tb_username.Text + "' and Password ='" + tb_pass.Text + "' ";
                SqlDataAdapter sdA = new SqlDataAdapter(query, sq);
                DataTable dt = new DataTable();
                sdA.Fill(dt);


                if (dt.Rows.Count == 1)
                {

                    
                    this.Hide();
                    new CustomerForm1().Show();
                    sq.Close();
                }


            }

            else
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrationForm().Show();
            
        }
    }
}
