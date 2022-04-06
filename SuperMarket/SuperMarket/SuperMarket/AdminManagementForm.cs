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
    public partial class AdminManagementForm : Form
    {
        public AdminManagementForm()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Admins ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void admin_add_btn_Click(object sender, EventArgs e)
        {
            if ((tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null) && (tb_pass.Text != "" || tb_pass.Text != ""))
            {
                sq.Open();
                SqlCommand sC = new SqlCommand("insert into Admins values ('" + tb_name.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "')", sq);
                sC.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("Admin Inserted");
                ShowMe();
            }
            else
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminManagementForm_Load(object sender, EventArgs e)
        {
            
        }

        private void admin_delete_btn_Click(object sender, EventArgs e)
        {
                sq.Open();
                SqlCommand sC = new SqlCommand("Delete Admins where Username = '" + tb_username.Text + "' ", sq);
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_username.Text = "";
            tb_pass.Text = "";
        }

        private void admin_list_btn_Click(object sender, EventArgs e)
        {
            ShowMe();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Close();
        }
    }
}
