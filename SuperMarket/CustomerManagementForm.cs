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
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Customers ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void user_add_btn_Click(object sender, EventArgs e)
        {
            if ((tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != ""))
            {
                sq.Open();
                SqlCommand sC = new SqlCommand("insert into Customers values ('" + tb_name.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "')", sq);
                sC.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("User Inserted");
                ShowMe();
            }
            else
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_update_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("update Customers set Name = '" + tb_name.Text + "' where Username = '" + tb_username.Text + "' ", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("Name has been Updated");
            sq.Close();
            ShowMe();
        }

        private void user_delete_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Customers where Username = '" + tb_username.Text + "' ", sq);

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

        private void user_src_btn_Click(object sender, EventArgs e)
        {
           
                SqlCommand sC = new SqlCommand("select * from Customers where Username = '" + tb_user_src.Text + "' ", sq);
                SqlDataAdapter sA = new SqlDataAdapter(sC);
                DataTable dt = new DataTable();
                sA.Fill(dt);
                dataGridView1.DataSource = dt;

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_username.Text = "";
            tb_pass.Text = "";
            tb_user_src.Text = "";

            ShowMe();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sZ = new SqlCommand("select * from Customers ", sq);
            SqlDataAdapter sY = new SqlDataAdapter(sZ);
            DataTable dc = new DataTable();
            sY.Fill(dc);
            dataGridView1.DataSource = dc;
        }
    }
}
