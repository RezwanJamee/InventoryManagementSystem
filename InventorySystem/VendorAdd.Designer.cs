namespace InventorySystem
{
    partial class VendorAdd
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
            this.AddVendorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddEmailTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VendorNameLabel = new System.Windows.Forms.Label();
            this.AddAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddVendorNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddVendorLabel
            // 
            this.AddVendorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddVendorLabel.AutoSize = true;
            this.AddVendorLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVendorLabel.Location = new System.Drawing.Point(331, 38);
            this.AddVendorLabel.Name = "AddVendorLabel";
            this.AddVendorLabel.Size = new System.Drawing.Size(213, 32);
            this.AddVendorLabel.TabIndex = 19;
            this.AddVendorLabel.Text = "Add new Vendor:";
            this.AddVendorLabel.Click += new System.EventHandler(this.AddVendorLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(231, 171);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 16);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // AddEmailTextBox
            // 
            this.AddEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEmailTextBox.Location = new System.Drawing.Point(348, 170);
            this.AddEmailTextBox.Name = "AddEmailTextBox";
            this.AddEmailTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddEmailTextBox.TabIndex = 17;
            this.AddEmailTextBox.TextChanged += new System.EventHandler(this.AddEmailTextBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(348, 356);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 37);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(484, 356);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(88, 37);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(231, 280);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(70, 16);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VendorNameLabel
            // 
            this.VendorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VendorNameLabel.AutoSize = true;
            this.VendorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorNameLabel.Location = new System.Drawing.Point(228, 122);
            this.VendorNameLabel.Name = "VendorNameLabel";
            this.VendorNameLabel.Size = new System.Drawing.Size(107, 16);
            this.VendorNameLabel.TabIndex = 14;
            this.VendorNameLabel.Text = "Vendor Name:";
            this.VendorNameLabel.Click += new System.EventHandler(this.VendorNameLabel_Click);
            // 
            // AddAddressTextBox
            // 
            this.AddAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAddressTextBox.Location = new System.Drawing.Point(348, 279);
            this.AddAddressTextBox.Name = "AddAddressTextBox";
            this.AddAddressTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddAddressTextBox.TabIndex = 7;
            this.AddAddressTextBox.TextChanged += new System.EventHandler(this.AddAddressTextBox_TextChanged);
            // 
            // AddPhoneNumberTextBox
            // 
            this.AddPhoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddPhoneNumberTextBox.Location = new System.Drawing.Point(348, 224);
            this.AddPhoneNumberTextBox.Name = "AddPhoneNumberTextBox";
            this.AddPhoneNumberTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddPhoneNumberTextBox.TabIndex = 8;
            this.AddPhoneNumberTextBox.TextChanged += new System.EventHandler(this.AddPhoneNumberTextBox_TextChanged);
            // 
            // AddVendorNameTextBox
            // 
            this.AddVendorNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddVendorNameTextBox.Location = new System.Drawing.Point(348, 121);
            this.AddVendorNameTextBox.Name = "AddVendorNameTextBox";
            this.AddVendorNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.AddVendorNameTextBox.TabIndex = 10;
            this.AddVendorNameTextBox.TextChanged += new System.EventHandler(this.AddVendorNameTextBox_TextChanged);
            // 
            // VendorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddVendorLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddEmailTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VendorNameLabel);
            this.Controls.Add(this.AddAddressTextBox);
            this.Controls.Add(this.AddPhoneNumberTextBox);
            this.Controls.Add(this.AddVendorNameTextBox);
            this.Name = "VendorAdd";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddVendorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox AddEmailTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VendorNameLabel;
        private System.Windows.Forms.TextBox AddAddressTextBox;
        private System.Windows.Forms.TextBox AddPhoneNumberTextBox;
        private System.Windows.Forms.TextBox AddVendorNameTextBox;
    }
}