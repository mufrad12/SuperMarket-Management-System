
namespace SuperMarket
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.shop_mng_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.emp_mng_btn = new System.Windows.Forms.Button();
            this.admin_mng_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // shop_mng_btn
            // 
            this.shop_mng_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.shop_mng_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_mng_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shop_mng_btn.Location = new System.Drawing.Point(420, 340);
            this.shop_mng_btn.Name = "shop_mng_btn";
            this.shop_mng_btn.Size = new System.Drawing.Size(342, 58);
            this.shop_mng_btn.TabIndex = 0;
            this.shop_mng_btn.Text = "Shop Management";
            this.shop_mng_btn.UseVisualStyleBackColor = false;
            this.shop_mng_btn.Click += new System.EventHandler(this.shop_mng_btn_Click);
            // 
            // emp_mng_btn
            // 
            this.emp_mng_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.emp_mng_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_mng_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_mng_btn.Location = new System.Drawing.Point(420, 255);
            this.emp_mng_btn.Name = "emp_mng_btn";
            this.emp_mng_btn.Size = new System.Drawing.Size(342, 58);
            this.emp_mng_btn.TabIndex = 1;
            this.emp_mng_btn.Text = "Employee Management";
            this.emp_mng_btn.UseVisualStyleBackColor = false;
            this.emp_mng_btn.Click += new System.EventHandler(this.emp_mng_btn_Click);
            // 
            // admin_mng_btn
            // 
            this.admin_mng_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.admin_mng_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_mng_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_mng_btn.Location = new System.Drawing.Point(420, 167);
            this.admin_mng_btn.Name = "admin_mng_btn";
            this.admin_mng_btn.Size = new System.Drawing.Size(344, 58);
            this.admin_mng_btn.TabIndex = 2;
            this.admin_mng_btn.Text = "Admin Management";
            this.admin_mng_btn.UseVisualStyleBackColor = false;
            this.admin_mng_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Crimson;
            this.back_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_btn.Location = new System.Drawing.Point(420, 404);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(102, 38);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Log Out";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 561);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SuperMarket.Properties.Resources.settings;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(33, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 185);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(61, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Admin Panel";
            this.label2.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SuperMarket.Properties.Resources.admin;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(368, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 58);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SuperMarket.Properties.Resources.employee;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(368, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 58);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::SuperMarket.Properties.Resources.customer;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(368, 340);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 58);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = global::SuperMarket.Properties.Resources.pmmqqqfmqky;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.admin_mng_btn);
            this.Controls.Add(this.emp_mng_btn);
            this.Controls.Add(this.shop_mng_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shop_mng_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button emp_mng_btn;
        private System.Windows.Forms.Button admin_mng_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}