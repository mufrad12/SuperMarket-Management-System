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
    public partial class CustomerForm1 : Form
    {
        public CustomerForm1()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=MMJ\\SQLEXPRESS;Initial Catalog=StoreManagement;Initial Catalog=StoreManagement;Integrated Security=True");
        private void shop_src_btn_Click(object sender, EventArgs e)
        {
            SqlCommand sC = new SqlCommand("select * from Shops where Username = '" + tb_shop_src.Text + "' ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView1.DataSource = dt;
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
            SqlCommand sZ = new SqlCommand("select * from Products where ID = '" + int.Parse(textBox1.Text) + "'", sq);
            SqlDataAdapter sY = new SqlDataAdapter(sZ);
            DataTable dt = new DataTable();
            sY.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void product_list_btn_Click(object sender, EventArgs e)
        {
            SqlCommand sC = new SqlCommand("select * from Products ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dt = new DataTable();
            sA.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView2.DataSource = "";
            tb_shop_src.Text = "";
            textBox1.Text = "";
        }
    }
}
