namespace InventorySystem
{
    partial class ProductsAdd
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
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.AddProductTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.StocksLabel = new System.Windows.Forms.Label();
            this.AddPriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.Location = new System.Drawing.Point(299, 35);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(221, 32);
            this.AddProductLabel.TabIndex = 39;
            this.AddProductLabel.Text = "Add new Product:";
            // 
            // ProductLabel
            // 
            this.ProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(167, 151);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(110, 16);
            this.ProductLabel.TabIndex = 38;
            this.ProductLabel.Text = "Product Name:";
            // 
            // AddProductTextBox
            // 
            this.AddProductTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductTextBox.Location = new System.Drawing.Point(305, 147);
            this.AddProductTextBox.Name = "AddProductTextBox";
            this.AddProductTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddProductTextBox.TabIndex = 37;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(305, 319);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 37);
            this.ExitButton.TabIndex = 36;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(441, 319);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(88, 37);
            this.SubmitButton.TabIndex = 35;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // StocksLabel
            // 
            this.StocksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StocksLabel.AutoSize = true;
            this.StocksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksLabel.Location = new System.Drawing.Point(167, 234);
            this.StocksLabel.Name = "StocksLabel";
            this.StocksLabel.Size = new System.Drawing.Size(131, 16);
            this.StocksLabel.TabIndex = 33;
            this.StocksLabel.Text = "Price per product:";
            // 
            // AddPriceTextBox
            // 
            this.AddPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddPriceTextBox.Location = new System.Drawing.Point(305, 230);
            this.AddPriceTextBox.Name = "AddPriceTextBox";
            this.AddPriceTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddPriceTextBox.TabIndex = 31;
            // 
            // ProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProductLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.AddProductTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.StocksLabel);
            this.Controls.Add(this.AddPriceTextBox);
            this.Name = "ProductsAdd";
            this.Text = "ProductsAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox AddProductTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label StocksLabel;
        private System.Windows.Forms.TextBox AddPriceTextBox;
    }
}