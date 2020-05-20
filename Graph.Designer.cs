namespace InventorySystem
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SideBtn_Dashboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Stocks_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.password_Username_Test_V02DataSet1 = new InventorySystem.Password_Username_Test_V02DataSet1();
            this.stocksTableAdapter = new InventorySystem.Password_Username_Test_V02DataSet1TableAdapters.StocksTableAdapter();
            this.Customers_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Products_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Vendors_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.passwordUsernameTestV02DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.password_Username_Test_V02DataSet2 = new InventorySystem.Password_Username_Test_V02DataSet2();
            this.passwordUsernameTestV02DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new InventorySystem.Password_Username_Test_V02DataSet2TableAdapters.VendorsTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new InventorySystem.Password_Username_Test_V02DataSet2TableAdapters.CustomerTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new InventorySystem.Password_Username_Test_V02DataSet2TableAdapters.ProductsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stocks_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_Username_Test_V02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customers_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vendors_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordUsernameTestV02DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_Username_Test_V02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordUsernameTestV02DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 64);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.Admin_Img;
            this.pictureBox1.Location = new System.Drawing.Point(1119, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1065, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.SideBtn_Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 637);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SideBtn_Dashboard
            // 
            this.SideBtn_Dashboard.BackColor = System.Drawing.Color.White;
            this.SideBtn_Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SideBtn_Dashboard.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideBtn_Dashboard.Image = global::InventorySystem.Properties.Resources.DashboardIcon;
            this.SideBtn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideBtn_Dashboard.Location = new System.Drawing.Point(3, 3);
            this.SideBtn_Dashboard.Name = "SideBtn_Dashboard";
            this.SideBtn_Dashboard.Size = new System.Drawing.Size(206, 67);
            this.SideBtn_Dashboard.TabIndex = 0;
            this.SideBtn_Dashboard.Text = "DASHBOARD";
            this.SideBtn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SideBtn_Dashboard.UseVisualStyleBackColor = false;
            this.SideBtn_Dashboard.Click += new System.EventHandler(this.SideBtn_Dashboard_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::InventorySystem.Properties.Resources.VendorsIcon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "        VENDORS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::InventorySystem.Properties.Resources.CustomersIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "CUSTOMERS";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::InventorySystem.Properties.Resources.StockIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = " STOCKS";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "     TRENDS\r\n    (GRAPHS)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::InventorySystem.Properties.Resources.LogOutIcon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 441);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 69);
            this.button6.TabIndex = 5;
            this.button6.Text = "      LOGOUT";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Stocks_Graph
            // 
            this.Stocks_Graph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Stocks_Graph.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.Stocks_Graph.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Stocks_Graph.BorderlineColor = System.Drawing.Color.Gray;
            chartArea21.Name = "ChartArea1";
            this.Stocks_Graph.ChartAreas.Add(chartArea21);
            this.Stocks_Graph.DataSource = this.stocksBindingSource;
            legend21.Name = "Legend1";
            this.Stocks_Graph.Legends.Add(legend21);
            this.Stocks_Graph.Location = new System.Drawing.Point(261, 91);
            this.Stocks_Graph.Name = "Stocks_Graph";
            this.Stocks_Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series21.IsXValueIndexed = true;
            series21.Legend = "Legend1";
            series21.Name = "Stocks";
            series21.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series21.SmartLabelStyle.Enabled = false;
            series21.XValueMember = "Product_Name";
            series21.YValueMembers = "Stocks";
            this.Stocks_Graph.Series.Add(series21);
            this.Stocks_Graph.Size = new System.Drawing.Size(437, 271);
            this.Stocks_Graph.TabIndex = 6;
            this.Stocks_Graph.Text = "Stocks_Graphs";
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.password_Username_Test_V02DataSet1;
            // 
            // password_Username_Test_V02DataSet1
            // 
            this.password_Username_Test_V02DataSet1.DataSetName = "Password_Username_Test_V02DataSet1";
            this.password_Username_Test_V02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // Customers_Graph
            // 
            this.Customers_Graph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Customers_Graph.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.Customers_Graph.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Customers_Graph.BorderlineColor = System.Drawing.Color.Gray;
            chartArea22.Name = "ChartArea1";
            this.Customers_Graph.ChartAreas.Add(chartArea22);
            this.Customers_Graph.DataSource = this.customerBindingSource;
            legend22.Name = "Legend1";
            this.Customers_Graph.Legends.Add(legend22);
            this.Customers_Graph.Location = new System.Drawing.Point(261, 412);
            this.Customers_Graph.Name = "Customers_Graph";
            this.Customers_Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series22.IsXValueIndexed = true;
            series22.Legend = "Legend1";
            series22.Name = "Customers";
            series22.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series22.SmartLabelStyle.Enabled = false;
            series22.XValueMember = "Customer Name";
            series22.YValueMembers = "Total Orders";
            this.Customers_Graph.Series.Add(series22);
            this.Customers_Graph.Size = new System.Drawing.Size(437, 274);
            this.Customers_Graph.TabIndex = 7;
            this.Customers_Graph.Text = "Stocks_Graphs";
            // 
            // Products_Graph
            // 
            this.Products_Graph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Products_Graph.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.Products_Graph.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Products_Graph.BorderlineColor = System.Drawing.Color.Gray;
            chartArea23.Name = "ChartArea1";
            this.Products_Graph.ChartAreas.Add(chartArea23);
            this.Products_Graph.DataSource = this.productsBindingSource;
            legend23.Name = "Legend1";
            this.Products_Graph.Legends.Add(legend23);
            this.Products_Graph.Location = new System.Drawing.Point(731, 412);
            this.Products_Graph.Name = "Products_Graph";
            this.Products_Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series23.IsXValueIndexed = true;
            series23.Legend = "Legend1";
            series23.Name = "Products";
            series23.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series23.SmartLabelStyle.Enabled = false;
            series23.XValueMember = "Product Name";
            series23.YValueMembers = "Price(in $) per product";
            this.Products_Graph.Series.Add(series23);
            this.Products_Graph.Size = new System.Drawing.Size(408, 274);
            this.Products_Graph.TabIndex = 8;
            this.Products_Graph.Text = "Stocks_Graphs";
            // 
            // Vendors_Graph
            // 
            this.Vendors_Graph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Vendors_Graph.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.Vendors_Graph.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Vendors_Graph.BorderlineColor = System.Drawing.Color.Gray;
            chartArea24.Name = "ChartArea1";
            this.Vendors_Graph.ChartAreas.Add(chartArea24);
            this.Vendors_Graph.DataSource = this.vendorsBindingSource;
            legend24.Name = "Legend1";
            this.Vendors_Graph.Legends.Add(legend24);
            this.Vendors_Graph.Location = new System.Drawing.Point(731, 91);
            this.Vendors_Graph.Name = "Vendors_Graph";
            this.Vendors_Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series24.IsXValueIndexed = true;
            series24.Legend = "Legend1";
            series24.Name = "Vendors";
            series24.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series24.SmartLabelStyle.Enabled = false;
            series24.XValueMember = "Vendor(or Company) Name";
            series24.YValueMembers = "Total products";
            this.Vendors_Graph.Series.Add(series24);
            this.Vendors_Graph.Size = new System.Drawing.Size(408, 271);
            this.Vendors_Graph.TabIndex = 9;
            this.Vendors_Graph.Text = "Customers_Graphs";
            title6.Name = "Vendors_Graph";
            this.Vendors_Graph.Titles.Add(title6);
            // 
            // passwordUsernameTestV02DataSet1BindingSource
            // 
            this.passwordUsernameTestV02DataSet1BindingSource.DataSource = this.password_Username_Test_V02DataSet1;
            this.passwordUsernameTestV02DataSet1BindingSource.Position = 0;
            // 
            // password_Username_Test_V02DataSet2
            // 
            this.password_Username_Test_V02DataSet2.DataSetName = "Password_Username_Test_V02DataSet2";
            this.password_Username_Test_V02DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordUsernameTestV02DataSet2BindingSource
            // 
            this.passwordUsernameTestV02DataSet2BindingSource.DataSource = this.password_Username_Test_V02DataSet2;
            this.passwordUsernameTestV02DataSet2BindingSource.Position = 0;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.passwordUsernameTestV02DataSet2BindingSource;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.passwordUsernameTestV02DataSet2BindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.passwordUsernameTestV02DataSet2BindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 711);
            this.Controls.Add(this.Vendors_Graph);
            this.Controls.Add(this.Products_Graph);
            this.Controls.Add(this.Customers_Graph);
            this.Controls.Add(this.Stocks_Graph);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stocks_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_Username_Test_V02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customers_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vendors_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordUsernameTestV02DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_Username_Test_V02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordUsernameTestV02DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SideBtn_Dashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataVisualization.Charting.Chart Stocks_Graph;
        private Password_Username_Test_V02DataSet1 password_Username_Test_V02DataSet1;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private Password_Username_Test_V02DataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart Customers_Graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart Products_Graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart Vendors_Graph;
        private System.Windows.Forms.BindingSource passwordUsernameTestV02DataSet1BindingSource;
        private System.Windows.Forms.BindingSource passwordUsernameTestV02DataSet2BindingSource;
        private Password_Username_Test_V02DataSet2 password_Username_Test_V02DataSet2;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private Password_Username_Test_V02DataSet2TableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Password_Username_Test_V02DataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Password_Username_Test_V02DataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}