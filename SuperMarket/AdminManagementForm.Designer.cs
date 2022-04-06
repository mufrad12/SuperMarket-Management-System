
namespace SuperMarket
{
    partial class AdminManagementForm
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
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.admin_delete_btn = new System.Windows.Forms.Button();
            this.admin_add_btn = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.admin_list_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(210, 138);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(285, 24);
            this.tb_pass.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 167);
            this.dataGridView1.TabIndex = 46;
            // 
            // admin_delete_btn
            // 
            this.admin_delete_btn.BackColor = System.Drawing.Color.DarkRed;
            this.admin_delete_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_delete_btn.Location = new System.Drawing.Point(165, 185);
            this.admin_delete_btn.Name = "admin_delete_btn";
            this.admin_delete_btn.Size = new System.Drawing.Size(167, 32);
            this.admin_delete_btn.TabIndex = 45;
            this.admin_delete_btn.Text = "Delete Admin";
            this.admin_delete_btn.UseVisualStyleBackColor = false;
            this.admin_delete_btn.Click += new System.EventHandler(this.admin_delete_btn_Click);
            // 
            // admin_add_btn
            // 
            this.admin_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.admin_add_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_add_btn.Location = new System.Drawing.Point(33, 185);
            this.admin_add_btn.Name = "admin_add_btn";
            this.admin_add_btn.Size = new System.Drawing.Size(126, 32);
            this.admin_add_btn.TabIndex = 43;
            this.admin_add_btn.Text = "Add Admin";
            this.admin_add_btn.UseVisualStyleBackColor = false;
            this.admin_add_btn.Click += new System.EventHandler(this.admin_add_btn_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(210, 92);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(286, 24);
            this.tb_username.TabIndex = 41;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(210, 43);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(286, 24);
            this.tb_name.TabIndex = 40;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.SlateGray;
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh_btn.Location = new System.Drawing.Point(338, 185);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(158, 32);
            this.refresh_btn.TabIndex = 49;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // admin_list_btn
            // 
            this.admin_list_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.admin_list_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_list_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_list_btn.Location = new System.Drawing.Point(21, 448);
            this.admin_list_btn.Name = "admin_list_btn";
            this.admin_list_btn.Size = new System.Drawing.Size(204, 42);
            this.admin_list_btn.TabIndex = 50;
            this.admin_list_btn.Text = "Show Admin List";
            this.admin_list_btn.UseVisualStyleBackColor = false;
            this.admin_list_btn.Click += new System.EventHandler(this.admin_list_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.back_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_btn.Location = new System.Drawing.Point(21, 496);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(144, 40);
            this.back_btn.TabIndex = 86;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundImage = global::SuperMarket.Properties.Resources.figheogbbhz2;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.refresh_btn);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_pass);
            this.groupBox1.Controls.Add(this.admin_delete_btn);
            this.groupBox1.Controls.Add(this.admin_add_btn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 241);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin  Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Admin Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 90;
            this.label2.Text = "Admin Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Admin Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::SuperMarket.Properties.Resources.unauthorized_person;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(577, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 241);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // AdminManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::SuperMarket.Properties.Resources.original;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.admin_list_btn);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "AdminManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button admin_delete_btn;
        private System.Windows.Forms.Button admin_add_btn;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button admin_list_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}