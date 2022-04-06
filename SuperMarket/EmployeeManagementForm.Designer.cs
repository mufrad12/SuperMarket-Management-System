
namespace SuperMarket
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emp_delete_btn = new System.Windows.Forms.Button();
            this.emp_update_btn = new System.Windows.Forms.Button();
            this.emp_add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_src_btn = new System.Windows.Forms.Button();
            this.tb_emp_src = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.show_emp_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 232);
            this.dataGridView1.TabIndex = 32;
            // 
            // emp_delete_btn
            // 
            this.emp_delete_btn.BackColor = System.Drawing.Color.Maroon;
            this.emp_delete_btn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_delete_btn.Location = new System.Drawing.Point(403, 181);
            this.emp_delete_btn.Name = "emp_delete_btn";
            this.emp_delete_btn.Size = new System.Drawing.Size(167, 32);
            this.emp_delete_btn.TabIndex = 31;
            this.emp_delete_btn.Text = "Delete Employee";
            this.emp_delete_btn.UseVisualStyleBackColor = false;
            this.emp_delete_btn.Click += new System.EventHandler(this.emp_delete_btn_Click);
            // 
            // emp_update_btn
            // 
            this.emp_update_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.emp_update_btn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_update_btn.Location = new System.Drawing.Point(214, 181);
            this.emp_update_btn.Name = "emp_update_btn";
            this.emp_update_btn.Size = new System.Drawing.Size(167, 32);
            this.emp_update_btn.TabIndex = 30;
            this.emp_update_btn.Text = "Update Employee";
            this.emp_update_btn.UseVisualStyleBackColor = false;
            this.emp_update_btn.Click += new System.EventHandler(this.emp_update_btn_Click);
            // 
            // emp_add_btn
            // 
            this.emp_add_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.emp_add_btn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_add_btn.Location = new System.Drawing.Point(21, 181);
            this.emp_add_btn.Name = "emp_add_btn";
            this.emp_add_btn.Size = new System.Drawing.Size(167, 32);
            this.emp_add_btn.TabIndex = 29;
            this.emp_add_btn.Text = "Add Employee";
            this.emp_add_btn.UseVisualStyleBackColor = false;
            this.emp_add_btn.Click += new System.EventHandler(this.emp_add_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Employee Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(245, 76);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(292, 24);
            this.tb_username.TabIndex = 27;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(245, 35);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(292, 24);
            this.tb_name.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee Name";
            // 
            // emp_src_btn
            // 
            this.emp_src_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.emp_src_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_src_btn.Location = new System.Drawing.Point(316, 33);
            this.emp_src_btn.Name = "emp_src_btn";
            this.emp_src_btn.Size = new System.Drawing.Size(76, 28);
            this.emp_src_btn.TabIndex = 24;
            this.emp_src_btn.Text = "Search";
            this.emp_src_btn.UseVisualStyleBackColor = false;
            this.emp_src_btn.Click += new System.EventHandler(this.emp_src_btn_Click);
            // 
            // tb_emp_src
            // 
            this.tb_emp_src.Location = new System.Drawing.Point(18, 33);
            this.tb_emp_src.Multiline = true;
            this.tb_emp_src.Name = "tb_emp_src";
            this.tb_emp_src.Size = new System.Drawing.Size(292, 24);
            this.tb_emp_src.TabIndex = 23;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(245, 118);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(292, 24);
            this.tb_pass.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Employee Password";
            // 
            // show_emp_btn
            // 
            this.show_emp_btn.BackColor = System.Drawing.Color.SlateGray;
            this.show_emp_btn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_emp_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_emp_btn.Location = new System.Drawing.Point(595, 181);
            this.show_emp_btn.Name = "show_emp_btn";
            this.show_emp_btn.Size = new System.Drawing.Size(167, 32);
            this.show_emp_btn.TabIndex = 35;
            this.show_emp_btn.Text = "Refresh";
            this.show_emp_btn.UseVisualStyleBackColor = false;
            this.show_emp_btn.Click += new System.EventHandler(this.show_emp_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.back_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_btn.Location = new System.Drawing.Point(16, 620);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(89, 29);
            this.back_btn.TabIndex = 87;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundImage = global::SuperMarket.Properties.Resources.figheogbbhz;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.show_emp_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_pass);
            this.groupBox1.Controls.Add(this.emp_update_btn);
            this.groupBox1.Controls.Add(this.emp_delete_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.emp_add_btn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(16, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 241);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::SuperMarket.Properties.Resources.employee1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(595, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 143);
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.BackgroundImage = global::SuperMarket.Properties.Resources.figheogbbhz1;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tb_emp_src);
            this.groupBox2.Controls.Add(this.emp_src_btn);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(16, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 86);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employee";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 28);
            this.button1.TabIndex = 95;
            this.button1.Text = "Show Employee List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = global::SuperMarket.Properties.Resources.original;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagementForm";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button emp_delete_btn;
        private System.Windows.Forms.Button emp_update_btn;
        private System.Windows.Forms.Button emp_add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emp_src_btn;
        private System.Windows.Forms.TextBox tb_emp_src;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button show_emp_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}