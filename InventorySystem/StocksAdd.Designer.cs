namespace InventorySystem
{
    partial class StocksAdd
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
            this.AddStocksLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.AddProductTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.StocksLabel = new System.Windows.Forms.Label();
            this.VendorNameLabel = new System.Windows.Forms.Label();
            this.AddStocksTextBox = new System.Windows.Forms.TextBox();
            this.AddVendorNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddStocksLabel
            // 
            this.AddStocksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStocksLabel.AutoSize = true;
            this.AddStocksLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStocksLabel.Location = new System.Drawing.Point(314, 29);
            this.AddStocksLabel.Name = "AddStocksLabel";
            this.AddStocksLabel.Size = new System.Drawing.Size(202, 32);
            this.AddStocksLabel.TabIndex = 30;
            this.AddStocksLabel.Text = "Add new Stocks:";
            this.AddStocksLabel.Click += new System.EventHandler(this.AddStocksLabel_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(203, 200);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(110, 16);
            this.ProductLabel.TabIndex = 29;
            this.ProductLabel.Text = "Product Name:";
            this.ProductLabel.Click += new System.EventHandler(this.ProductLabel_Click);
            // 
            // AddProductTextBox
            // 
            this.AddProductTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductTextBox.Location = new System.Drawing.Point(320, 199);
            this.AddProductTextBox.Name = "AddProductTextBox";
            this.AddProductTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddProductTextBox.TabIndex = 28;
            this.AddProductTextBox.TextChanged += new System.EventHandler(this.AddProductTextBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(320, 351);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 37);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(456, 351);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(88, 37);
            this.SubmitButton.TabIndex = 26;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // StocksLabel
            // 
            this.StocksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StocksLabel.AutoSize = true;
            this.StocksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksLabel.Location = new System.Drawing.Point(200, 283);
            this.StocksLabel.Name = "StocksLabel";
            this.StocksLabel.Size = new System.Drawing.Size(59, 16);
            this.StocksLabel.TabIndex = 24;
            this.StocksLabel.Text = "Stocks:";
            this.StocksLabel.Click += new System.EventHandler(this.StocksLabel_Click);
            // 
            // VendorNameLabel
            // 
            this.VendorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VendorNameLabel.AutoSize = true;
            this.VendorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorNameLabel.Location = new System.Drawing.Point(200, 117);
            this.VendorNameLabel.Name = "VendorNameLabel";
            this.VendorNameLabel.Size = new System.Drawing.Size(107, 16);
            this.VendorNameLabel.TabIndex = 25;
            this.VendorNameLabel.Text = "Vendor Name:";
            this.VendorNameLabel.Click += new System.EventHandler(this.VendorNameLabel_Click);
            // 
            // AddStocksTextBox
            // 
            this.AddStocksTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStocksTextBox.Location = new System.Drawing.Point(320, 282);
            this.AddStocksTextBox.Name = "AddStocksTextBox";
            this.AddStocksTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddStocksTextBox.TabIndex = 21;
            this.AddStocksTextBox.TextChanged += new System.EventHandler(this.AddStocksTextBox_TextChanged);
            // 
            // AddVendorNameTextBox
            // 
            this.AddVendorNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddVendorNameTextBox.Location = new System.Drawing.Point(320, 116);
            this.AddVendorNameTextBox.Name = "AddVendorNameTextBox";
            this.AddVendorNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddVendorNameTextBox.TabIndex = 22;
            this.AddVendorNameTextBox.TextChanged += new System.EventHandler(this.AddVendorNameTextBox_TextChanged);
            // 
            // StocksAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStocksLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.AddProductTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.StocksLabel);
            this.Controls.Add(this.VendorNameLabel);
            this.Controls.Add(this.AddStocksTextBox);
            this.Controls.Add(this.AddVendorNameTextBox);
            this.Name = "StocksAdd";
            this.Text = "StocksAdd";
            this.Load += new System.EventHandler(this.StocksAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddStocksLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox AddProductTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label StocksLabel;
        private System.Windows.Forms.Label VendorNameLabel;
        private System.Windows.Forms.TextBox AddStocksTextBox;
        private System.Windows.Forms.TextBox AddVendorNameTextBox;
    }
}