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
    public partial class ShopManagementForm : Form
    {
        public ShopManagementForm()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Initial Catalog=StoreManagement;Integrated Security=True");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Shops ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ShowProductList()
        {
            SqlCommand sC = new SqlCommand("select * from Products ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void shop_add_btn_Click(object sender, EventArgs e)
        {
            if ((tb_name.Text != "" || tb_name.Text != null) && (tb_username.Text != "" || tb_username.Text != null) && (tb_address.Text != "" || tb_address.Text != ""))
            {
                sq.Open();
                SqlCommand sC = new SqlCommand("insert into Shops values ('" + tb_name.Text + "', '" + tb_username.Text + "', '" + tb_address.Text + "')", sq);
                sC.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("Shop Inserted");
                ShowMe();
            }
            else
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShopManagementForm_Load(object sender, EventArgs e)
        {
            
        }

        private void shop_update_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("update Shops set Name= '" + tb_name.Text + "', Address = '" + tb_address.Text + "' where Username = '" + tb_username.Text + "' ", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("Data has been Updated");
            sq.Close();
            ShowMe();
        }

        private void shop_delete_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Shops where Username = '" + tb_username.Text + "' ", sq);

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

        private void product_list_btn_Click(object sender, EventArgs e)
        {
            ShowProductList();
        }

        private void shop_src_btn_Click(object sender, EventArgs e)
        {
            SqlCommand sC = new SqlCommand("select * from Shops where Username = '" + tb_shop_src.Text + "' ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_username.Text = "";
            tb_address.Text = "";
            tb_shop_src.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sC = new SqlCommand("select * from Shops ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sZ = new SqlCommand("select * from Products where Username = '" + tb_shop_src.Text + "' ", sq);
            SqlDataAdapter sY = new SqlDataAdapter(sZ);
            DataTable dt = new DataTable();
            sY.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
