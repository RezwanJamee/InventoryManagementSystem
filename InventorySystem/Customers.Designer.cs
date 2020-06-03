namespace InventorySystem
{
    partial class Customers
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.StocksButton = new System.Windows.Forms.Button();
            this.VendorsButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTable = new InventorySystem.CustomerTable();
            this.customersBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new InventorySystem.CustomersDataSet();
            this.customersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet1 = new InventorySystem.CustomersDataSet();
            this.customersTableAdapter1 = new InventorySystem.CustomersDataSetTableAdapters.CustomersTableAdapter();
            this.customersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerSearchTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new InventorySystem.CustomerTableTableAdapters.CustomersTableAdapter();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.SearchForCustomerButton = new System.Windows.Forms.Button();
            this.AddNewCustomer = new System.Windows.Forms.Button();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.DashboardButton);
            this.flowLayoutPanel1.Controls.Add(this.ProductsButton);
            this.flowLayoutPanel1.Controls.Add(this.StocksButton);
            this.flowLayoutPanel1.Controls.Add(this.VendorsButton);
            this.flowLayoutPanel1.Controls.Add(this.CustomersButton);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.LogoutButton);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 537);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.White;
            this.DashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DashboardButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Image = global::InventorySystem.Properties.Resources.DashboardIcon;
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(3, 3);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(206, 67);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "DASHBOARD";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.White;
            this.ProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ProductsButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.ProductsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsButton.Location = new System.Drawing.Point(3, 76);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(206, 67);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "           PRODUCTS";
            this.ProductsButton.UseVisualStyleBackColor = false;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // StocksButton
            // 
            this.StocksButton.BackColor = System.Drawing.Color.White;
            this.StocksButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StocksButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksButton.Image = global::InventorySystem.Properties.Resources.StockIcon;
            this.StocksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StocksButton.Location = new System.Drawing.Point(3, 149);
            this.StocksButton.Name = "StocksButton";
            this.StocksButton.Size = new System.Drawing.Size(206, 67);
            this.StocksButton.TabIndex = 2;
            this.StocksButton.Text = " STOCKS";
            this.StocksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StocksButton.UseVisualStyleBackColor = false;
            this.StocksButton.Click += new System.EventHandler(this.StocksButton_Click);
            // 
            // VendorsButton
            // 
            this.VendorsButton.BackColor = System.Drawing.Color.White;
            this.VendorsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.VendorsButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsButton.Image = global::InventorySystem.Properties.Resources.VendorsIcon;
            this.VendorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VendorsButton.Location = new System.Drawing.Point(3, 222);
            this.VendorsButton.Name = "VendorsButton";
            this.VendorsButton.Size = new System.Drawing.Size(206, 67);
            this.VendorsButton.TabIndex = 3;
            this.VendorsButton.Text = "        VENDORS";
            this.VendorsButton.UseVisualStyleBackColor = false;
            this.VendorsButton.Click += new System.EventHandler(this.VendorsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.White;
            this.CustomersButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CustomersButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.Image = global::InventorySystem.Properties.Resources.CustomersIcon;
            this.CustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.Location = new System.Drawing.Point(3, 295);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(206, 67);
            this.CustomersButton.TabIndex = 4;
            this.CustomersButton.Text = "CUSTOMERS";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomersButton.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 67);
            this.button5.TabIndex = 20;
            this.button5.Text = "     TRENDS\r\n    (GRAPHS)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogoutButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Image = global::InventorySystem.Properties.Resources.LogOutIcon;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(3, 441);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(206, 69);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "      LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 64);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "CUSTOMERS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.Admin_Img;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 11);
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
            this.label1.Location = new System.Drawing.Point(1035, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.AutoGenerateColumns = false;
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Products,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.CustomersGridView.DataSource = this.customersBindingSource7;
            this.CustomersGridView.Location = new System.Drawing.Point(352, 159);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.Size = new System.Drawing.Size(644, 315);
            this.CustomersGridView.TabIndex = 4;
            this.CustomersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Products
            // 
            this.Products.DataPropertyName = "Stocks";
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            this.Products.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Products.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Phone_Number";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone_Number";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn9.HeaderText = "Address";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // customersBindingSource7
            // 
            this.customersBindingSource7.DataMember = "Customers";
            this.customersBindingSource7.DataSource = this.customerTable;
            // 
            // customerTable
            // 
            this.customerTable.DataSetName = "CustomerTable";
            this.customerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource6
            // 
            this.customersBindingSource6.DataMember = "Customers";
            this.customersBindingSource6.DataSource = this.customerTable;
            // 
            // customersBindingSource3
            // 
            this.customersBindingSource3.DataMember = "Customers";
            this.customersBindingSource3.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource4
            // 
            this.customersBindingSource4.DataMember = "Customers";
            this.customersBindingSource4.DataSource = this.customersDataSet1;
            // 
            // customersDataSet1
            // 
            this.customersDataSet1.DataSetName = "CustomersDataSet";
            this.customersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersDataSetBindingSource
            // 
            this.customersDataSetBindingSource.DataSource = this.customersDataSet;
            this.customersDataSetBindingSource.Position = 0;
            // 
            // CustomerSearchTextBox
            // 
            this.CustomerSearchTextBox.Location = new System.Drawing.Point(940, 76);
            this.CustomerSearchTextBox.Name = "CustomerSearchTextBox";
            this.CustomerSearchTextBox.Size = new System.Drawing.Size(186, 20);
            this.CustomerSearchTextBox.TabIndex = 5;
            // 
            // customersBindingSource5
            // 
            this.customersBindingSource5.DataMember = "Customers";
            this.customersBindingSource5.DataSource = this.customersDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.Gray;
            this.Refreshbutton.Image = global::InventorySystem.Properties.Resources.Refresh;
            this.Refreshbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refreshbutton.Location = new System.Drawing.Point(386, 514);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(168, 55);
            this.Refreshbutton.TabIndex = 7;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // SearchForCustomerButton
            // 
            this.SearchForCustomerButton.BackgroundImage = global::InventorySystem.Properties.Resources.Search_96;
            this.SearchForCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchForCustomerButton.Location = new System.Drawing.Point(1132, 72);
            this.SearchForCustomerButton.Name = "SearchForCustomerButton";
            this.SearchForCustomerButton.Size = new System.Drawing.Size(31, 26);
            this.SearchForCustomerButton.TabIndex = 6;
            this.SearchForCustomerButton.UseVisualStyleBackColor = true;
            this.SearchForCustomerButton.Click += new System.EventHandler(this.SearchForCustomerButton_Click);
            // 
            // AddNewCustomer
            // 
            this.AddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCustomer.ForeColor = System.Drawing.Color.Gray;
            this.AddNewCustomer.Image = global::InventorySystem.Properties.Resources.Plus_math_961;
            this.AddNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewCustomer.Location = new System.Drawing.Point(706, 514);
            this.AddNewCustomer.Name = "AddNewCustomer";
            this.AddNewCustomer.Size = new System.Drawing.Size(290, 55);
            this.AddNewCustomer.TabIndex = 3;
            this.AddNewCustomer.Text = "Add New Customer";
            this.AddNewCustomer.UseVisualStyleBackColor = true;
            this.AddNewCustomer.Click += new System.EventHandler(this.AddNewCustomer_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 704);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.SearchForCustomerButton);
            this.Controls.Add(this.CustomerSearchTextBox);
            this.Controls.Add(this.CustomersGridView);
            this.Controls.Add(this.AddNewCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button StocksButton;
        private System.Windows.Forms.Button VendorsButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewCustomer;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        public System.Windows.Forms.DataGridView CustomersGridView;
        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource3;
        private CustomersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.BindingSource customersDataSetBindingSource;
        private CustomersDataSet customersDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource4;
        private System.Windows.Forms.TextBox CustomerSearchTextBox;
        private System.Windows.Forms.Button SearchForCustomerButton;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource customersBindingSource5;
        private CustomerTable customerTable;
        private System.Windows.Forms.BindingSource customersBindingSource6;
        private CustomerTableTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource customersBindingSource7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}