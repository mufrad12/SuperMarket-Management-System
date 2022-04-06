
namespace SuperMarket
{
    partial class ProductManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.product_src_btn = new System.Windows.Forms.Button();
            this.tb_prod_src = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.product_delete_btn = new System.Windows.Forms.Button();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.product_update_btn = new System.Windows.Forms.Button();
            this.product_add_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 222);
            this.dataGridView1.TabIndex = 43;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.back_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_btn.Location = new System.Drawing.Point(12, 619);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(106, 40);
            this.back_btn.TabIndex = 86;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.BackgroundImage = global::SuperMarket.Properties.Resources.figheogbbhz1;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.product_src_btn);
            this.groupBox2.Controls.Add(this.tb_prod_src);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 86);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Product";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 28);
            this.button1.TabIndex = 94;
            this.button1.Text = "Show All Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // product_src_btn
            // 
            this.product_src_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.product_src_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_src_btn.Location = new System.Drawing.Point(275, 33);
            this.product_src_btn.Name = "product_src_btn";
            this.product_src_btn.Size = new System.Drawing.Size(76, 28);
            this.product_src_btn.TabIndex = 35;
            this.product_src_btn.Text = "Search";
            this.product_src_btn.UseVisualStyleBackColor = false;
            this.product_src_btn.Click += new System.EventHandler(this.product_src_btn_Click);
            // 
            // tb_prod_src
            // 
            this.tb_prod_src.Location = new System.Drawing.Point(6, 36);
            this.tb_prod_src.Multiline = true;
            this.tb_prod_src.Name = "tb_prod_src";
            this.tb_prod_src.Size = new System.Drawing.Size(263, 24);
            this.tb_prod_src.TabIndex = 34;
            this.tb_prod_src.TextChanged += new System.EventHandler(this.tb_prod_src_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundImage = global::SuperMarket.Properties.Resources.figheogbbhz;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.refresh_btn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.product_delete_btn);
            this.groupBox1.Controls.Add(this.tb_type);
            this.groupBox1.Controls.Add(this.product_update_btn);
            this.groupBox1.Controls.Add(this.product_add_btn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 268);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::SuperMarket.Properties.Resources.shop;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(584, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 173);
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(14, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Product ID";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.SlateGray;
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh_btn.Location = new System.Drawing.Point(584, 212);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(167, 32);
            this.refresh_btn.TabIndex = 61;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(14, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Product Name";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(194, 161);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(320, 24);
            this.tb_price.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(14, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 59;
            this.label8.Text = "Product Price";
            // 
            // product_delete_btn
            // 
            this.product_delete_btn.BackColor = System.Drawing.Color.Maroon;
            this.product_delete_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.product_delete_btn.Location = new System.Drawing.Point(396, 212);
            this.product_delete_btn.Name = "product_delete_btn";
            this.product_delete_btn.Size = new System.Drawing.Size(167, 32);
            this.product_delete_btn.TabIndex = 42;
            this.product_delete_btn.Text = "Delete Product";
            this.product_delete_btn.UseVisualStyleBackColor = false;
            this.product_delete_btn.Click += new System.EventHandler(this.product_delete_btn_Click);
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(194, 118);
            this.tb_type.Multiline = true;
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(320, 24);
            this.tb_type.TabIndex = 45;
            // 
            // product_update_btn
            // 
            this.product_update_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.product_update_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.product_update_btn.Location = new System.Drawing.Point(207, 212);
            this.product_update_btn.Name = "product_update_btn";
            this.product_update_btn.Size = new System.Drawing.Size(167, 32);
            this.product_update_btn.TabIndex = 41;
            this.product_update_btn.Text = "Update Product";
            this.product_update_btn.UseVisualStyleBackColor = false;
            this.product_update_btn.Click += new System.EventHandler(this.product_update_btn_Click);
            // 
            // product_add_btn
            // 
            this.product_add_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.product_add_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.product_add_btn.Location = new System.Drawing.Point(18, 212);
            this.product_add_btn.Name = "product_add_btn";
            this.product_add_btn.Size = new System.Drawing.Size(167, 32);
            this.product_add_btn.TabIndex = 40;
            this.product_add_btn.Text = "Add Product";
            this.product_add_btn.UseVisualStyleBackColor = false;
            this.product_add_btn.Click += new System.EventHandler(this.product_add_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(14, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Product Type";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(194, 35);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(320, 24);
            this.tb_ID.TabIndex = 37;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(194, 77);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(320, 24);
            this.tb_name.TabIndex = 38;
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = global::SuperMarket.Properties.Resources.original;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(882, 710);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ProductManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagementForm";
            this.Load += new System.EventHandler(this.ProductManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button product_delete_btn;
        private System.Windows.Forms.Button product_update_btn;
        private System.Windows.Forms.Button product_add_btn;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button product_src_btn;
        private System.Windows.Forms.TextBox tb_prod_src;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}