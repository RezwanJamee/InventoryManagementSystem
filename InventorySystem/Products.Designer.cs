namespace InventorySystem
{
    partial class Products
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testDevPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDevPDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDevPDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new InventorySystem.ProductDataSet();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new InventorySystem.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDevPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDevPDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDevPDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.button1.Click += new System.EventHandler(this.DashBoardButton_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::InventorySystem.Properties.Resources.CustomersIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "CUSTOMERS";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.CustomersButton);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::InventorySystem.Properties.Resources.LogOutIcon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 69);
            this.button6.TabIndex = 5;
            this.button6.Text = "      LOGOUT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 64);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.Admin_Img;
            this.pictureBox1.Location = new System.Drawing.Point(856, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(786, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataMember = "DataBase";
            this.dataBaseBindingSource.DataSource = this.testDevPDataSetBindingSource;
            // 
            // dataBaseBindingSource1
            // 
            this.dataBaseBindingSource1.DataMember = "DataBase";
            this.dataBaseBindingSource1.DataSource = this.testDevPDataSetBindingSource1;
            // 
            // dataBaseBindingSource2
            // 
            this.dataBaseBindingSource2.DataMember = "DataBase";
            this.dataBaseBindingSource2.DataSource = this.testDevPDataSetBindingSource1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.productsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(373, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 339);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price per Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price per Product";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.productDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource testDevPDataSetBindingSource;
        //private TestDevPDataSet testDevPDataSet;
        private System.Windows.Forms.BindingSource testDevPDataSetBindingSource1;
        private System.Windows.Forms.BindingSource dataBaseBindingSource;
        //private TestDevPDataSetTableAdapters.DataBaseTableAdapter dataBaseTableAdapter;
        private System.Windows.Forms.BindingSource dataBaseBindingSource1;
        private System.Windows.Forms.BindingSource testDevPDataSetBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBaseBindingSource2;
        //private TestDevPDataSet1 testDevPDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        //private TestDevPDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}