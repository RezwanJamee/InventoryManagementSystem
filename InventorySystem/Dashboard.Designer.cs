namespace InventorySystem
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GoToCustomersButton = new System.Windows.Forms.Button();
            this.TopCustomerLabel = new System.Windows.Forms.Label();
            this.TopProducts = new System.Windows.Forms.Label();
            this.CustomerNo1 = new System.Windows.Forms.Label();
            this.CustomerNo2 = new System.Windows.Forms.Label();
            this.CustomerNo3 = new System.Windows.Forms.Label();
            this.TopProductNo3 = new System.Windows.Forms.Label();
            this.TopProductNo2 = new System.Windows.Forms.Label();
            this.TopProductNo1 = new System.Windows.Forms.Label();
            this.TopCustomerIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopCustomerPictureBox = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopCustomerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCustomerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.Admin_Img;
            this.pictureBox1.Location = new System.Drawing.Point(1119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1029, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "DASHBOARD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.GoToCustomersButton);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(211, 365);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::InventorySystem.Properties.Resources.DashboardIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "DASHBOARD";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "           PRODUCTS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::InventorySystem.Properties.Resources.StockIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = " STOCKS";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::InventorySystem.Properties.Resources.VendorsIcon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "        VENDORS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.VendorsButton_Click);
            // 
            // GoToCustomersButton
            // 
            this.GoToCustomersButton.BackColor = System.Drawing.Color.White;
            this.GoToCustomersButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoToCustomersButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToCustomersButton.Image = global::InventorySystem.Properties.Resources.CustomersIcon;
            this.GoToCustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoToCustomersButton.Location = new System.Drawing.Point(3, 295);
            this.GoToCustomersButton.Name = "GoToCustomersButton";
            this.GoToCustomersButton.Size = new System.Drawing.Size(206, 67);
            this.GoToCustomersButton.TabIndex = 4;
            this.GoToCustomersButton.Text = "CUSTOMERS";
            this.GoToCustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GoToCustomersButton.UseVisualStyleBackColor = false;
            this.GoToCustomersButton.Click += new System.EventHandler(this.GoToCustomersButton_Click);
            // 
            // TopCustomerLabel
            // 
            this.TopCustomerLabel.AutoSize = true;
            this.TopCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopCustomerLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.TopCustomerLabel.Location = new System.Drawing.Point(444, 354);
            this.TopCustomerLabel.Name = "TopCustomerLabel";
            this.TopCustomerLabel.Size = new System.Drawing.Size(158, 30);
            this.TopCustomerLabel.TabIndex = 11;
            this.TopCustomerLabel.Text = "Top Customers";
            // 
            // TopProducts
            // 
            this.TopProducts.AutoSize = true;
            this.TopProducts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopProducts.ForeColor = System.Drawing.Color.DarkViolet;
            this.TopProducts.Location = new System.Drawing.Point(812, 354);
            this.TopProducts.Name = "TopProducts";
            this.TopProducts.Size = new System.Drawing.Size(142, 30);
            this.TopProducts.TabIndex = 12;
            this.TopProducts.Text = "Top Products";
            // 
            // CustomerNo1
            // 
            this.CustomerNo1.AutoSize = true;
            this.CustomerNo1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNo1.ForeColor = System.Drawing.Color.DarkViolet;
            this.CustomerNo1.Location = new System.Drawing.Point(477, 433);
            this.CustomerNo1.Name = "CustomerNo1";
            this.CustomerNo1.Size = new System.Drawing.Size(67, 30);
            this.CustomerNo1.TabIndex = 13;
            this.CustomerNo1.Text = "Diljot";
            // 
            // CustomerNo2
            // 
            this.CustomerNo2.AutoSize = true;
            this.CustomerNo2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNo2.ForeColor = System.Drawing.Color.DarkViolet;
            this.CustomerNo2.Location = new System.Drawing.Point(423, 463);
            this.CustomerNo2.Name = "CustomerNo2";
            this.CustomerNo2.Size = new System.Drawing.Size(60, 30);
            this.CustomerNo2.TabIndex = 14;
            this.CustomerNo2.Text = "Rifat";
            this.CustomerNo2.Click += new System.EventHandler(this.CustomerNo2_Click);
            // 
            // CustomerNo3
            // 
            this.CustomerNo3.AutoSize = true;
            this.CustomerNo3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNo3.ForeColor = System.Drawing.Color.DarkViolet;
            this.CustomerNo3.Location = new System.Drawing.Point(537, 471);
            this.CustomerNo3.Name = "CustomerNo3";
            this.CustomerNo3.Size = new System.Drawing.Size(65, 30);
            this.CustomerNo3.TabIndex = 15;
            this.CustomerNo3.Text = "Indra";
            // 
            // TopProductNo3
            // 
            this.TopProductNo3.AutoSize = true;
            this.TopProductNo3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopProductNo3.ForeColor = System.Drawing.Color.DarkViolet;
            this.TopProductNo3.Location = new System.Drawing.Point(910, 471);
            this.TopProductNo3.Name = "TopProductNo3";
            this.TopProductNo3.Size = new System.Drawing.Size(65, 30);
            this.TopProductNo3.TabIndex = 18;
            this.TopProductNo3.Text = "Daisy";
            // 
            // TopProductNo2
            // 
            this.TopProductNo2.AutoSize = true;
            this.TopProductNo2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopProductNo2.ForeColor = System.Drawing.Color.DarkViolet;
            this.TopProductNo2.Location = new System.Drawing.Point(782, 463);
            this.TopProductNo2.Name = "TopProductNo2";
            this.TopProductNo2.Size = new System.Drawing.Size(62, 30);
            this.TopProductNo2.TabIndex = 17;
            this.TopProductNo2.Text = "Tulip";
            // 
            // TopProductNo1
            // 
            this.TopProductNo1.AutoSize = true;
            this.TopProductNo1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopProductNo1.ForeColor = System.Drawing.Color.DarkViolet;
            this.TopProductNo1.Location = new System.Drawing.Point(843, 433);
            this.TopProductNo1.Name = "TopProductNo1";
            this.TopProductNo1.Size = new System.Drawing.Size(59, 30);
            this.TopProductNo1.TabIndex = 16;
            this.TopProductNo1.Text = "Rose";
            // 
            // TopCustomerIcon
            // 
            this.TopCustomerIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopCustomerIcon.Image = global::InventorySystem.Properties.Resources.Top_Saler_leaderboard;
            this.TopCustomerIcon.Location = new System.Drawing.Point(428, 422);
            this.TopCustomerIcon.Name = "TopCustomerIcon";
            this.TopCustomerIcon.Size = new System.Drawing.Size(156, 122);
            this.TopCustomerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopCustomerIcon.TabIndex = 10;
            this.TopCustomerIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(730, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 209);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // TopCustomerPictureBox
            // 
            this.TopCustomerPictureBox.Location = new System.Drawing.Point(334, 348);
            this.TopCustomerPictureBox.Name = "TopCustomerPictureBox";
            this.TopCustomerPictureBox.Size = new System.Drawing.Size(337, 209);
            this.TopCustomerPictureBox.TabIndex = 7;
            this.TopCustomerPictureBox.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Navy;
            this.button8.Image = global::InventorySystem.Properties.Resources.StockedProductWithImage;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(259, 105);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(266, 194);
            this.button8.TabIndex = 2;
            this.button8.Text = "16";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Navy;
            this.button9.Image = global::InventorySystem.Properties.Resources.CustomerWithImage;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(862, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(237, 194);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Navy;
            this.button7.Image = global::InventorySystem.Properties.Resources.VendorWithImage;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(571, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 194);
            this.button7.TabIndex = 1;
            this.button7.Text = "5";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogoutButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Image = global::InventorySystem.Properties.Resources.LogOutIcon;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(5, 507);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(206, 69);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "      LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(5, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 67);
            this.button5.TabIndex = 19;
            this.button5.Text = "     TRENDS\r\n    (GRAPHS)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::InventorySystem.Properties.Resources.Top_Saler_leaderboard;
            this.pictureBox3.Location = new System.Drawing.Point(787, 422);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 704);
            this.Controls.Add(this.TopProductNo3);
            this.Controls.Add(this.TopProductNo2);
            this.Controls.Add(this.TopProductNo1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CustomerNo3);
            this.Controls.Add(this.CustomerNo2);
            this.Controls.Add(this.CustomerNo1);
            this.Controls.Add(this.TopProducts);
            this.Controls.Add(this.TopCustomerLabel);
            this.Controls.Add(this.TopCustomerIcon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TopCustomerPictureBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopCustomerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCustomerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button GoToCustomersButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox TopCustomerPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox TopCustomerIcon;
        private System.Windows.Forms.Label TopCustomerLabel;
        private System.Windows.Forms.Label TopProducts;
        private System.Windows.Forms.Label CustomerNo1;
        private System.Windows.Forms.Label CustomerNo2;
        private System.Windows.Forms.Label CustomerNo3;
        private System.Windows.Forms.Label TopProductNo3;
        private System.Windows.Forms.Label TopProductNo2;
        private System.Windows.Forms.Label TopProductNo1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

