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
    public partial class EmployeeManagementForm : Form
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Employees ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void emp_add_btn_Click(object sender, EventArgs e)
        {
            if ((tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != ""))
            {
                sq.Open();
                SqlCommand sC = new SqlCommand("insert into Employees values ('" + tb_name.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "')", sq);
                sC.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("Employee Inserted");
                ShowMe();

            }
            else
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
           
        }

        private void emp_update_btn_Click(object sender, EventArgs e)
        {
            if ((tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null))
            {
                sq.Open();
                SqlCommand sC = new SqlCommand("update Employees set Name = '" + tb_name.Text + "' where Username = '" + tb_username.Text + "' ", sq);
                sC.ExecuteNonQuery();
                MessageBox.Show("Name has been Updated");
                sq.Close();
                ShowMe();
            }
            else if ((tb_name.Text == "" || tb_name.Text == null) && (tb_username.Text == "" || tb_username.Text == null))
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void emp_delete_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Employees where Username = '" + tb_username.Text + "' ", sq);

            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                sC.ExecuteNonQuery();
                sq.Close();
                ShowMe();
            }
            if (res == DialogResult.No)
            {
                sq.Close();
                ShowMe();
            }
        }

        private void emp_src_btn_Click(object sender, EventArgs e)
        {
            SqlCommand sC = new SqlCommand("select * from Employees where Username = '" + tb_emp_src.Text + "' ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void show_emp_btn_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_username.Text = "";
            tb_pass.Text = "";
            tb_emp_src.Text = "";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sZ = new SqlCommand("select * from Employees ", sq);
            SqlDataAdapter sY = new SqlDataAdapter(sZ);
            DataTable dt = new DataTable();
            sY.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
