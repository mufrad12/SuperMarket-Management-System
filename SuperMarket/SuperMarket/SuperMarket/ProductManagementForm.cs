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
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Integrated Security=True");

        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Products ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void product_add_btn_Click(object sender, EventArgs e)
        {
            if ((tb_name.Text!= "" || tb_name.Text != null) && (tb_type.Text != "" || tb_type.Text != null) && (tb_price.Text != "" || tb_price.Text != ""))
            {
                sq.Open();
                SqlCommand sC = new SqlCommand("insert into Products values ('" + int.Parse(tb_ID.Text) + "', '" + tb_name.Text + "', '" + tb_type.Text + "', '" + int.Parse(tb_price.Text) + "')", sq);
                sC.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("Product Inserted");
                ShowMe();
            }
            else
            {
                MessageBox.Show("Please Insert valid credential", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            
        }

        private void product_update_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("update Products set Name='"+ tb_name.Text + "',Type='" + tb_type.Text + "', Price = '" + tb_price.Text + "' where ID = '" + int.Parse(tb_ID.Text)+"' ", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("Data has been Updated");
            sq.Close();
            ShowMe();
        }

        private void product_delete_btn_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Products where ID = '"+int.Parse(tb_ID.Text)+"' ", sq);

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

        private void product_src_btn_Click(object sender, EventArgs e)
        {
            SqlCommand sC = new SqlCommand("select * from Products where ID = '"+int.Parse(tb_prod_src.Text)+"'", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void tb_prod_src_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            tb_name.Text = "";
            tb_type.Text = "";
            tb_price.Text = "";
            tb_prod_src.Text = "";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sZ = new SqlCommand("select * from Products ", sq);
            SqlDataAdapter sY = new SqlDataAdapter(sZ);
            DataTable dt = new DataTable();
            sY.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
