namespace InventorySystem
{
    partial class Edit_Credentials
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username_textfield = new System.Windows.Forms.TextBox();
            this.Password_textfield = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.password_Username_Test_V02DataSet = new InventorySystem.Password_Username_Test_V02DataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new InventorySystem.Password_Username_Test_V02DataSetTableAdapters.LoginTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.password_Username_Test_V02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // Username_textfield
            // 
            this.Username_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_textfield.Location = new System.Drawing.Point(267, 242);
            this.Username_textfield.Name = "Username_textfield";
            this.Username_textfield.Size = new System.Drawing.Size(330, 26);
            this.Username_textfield.TabIndex = 3;
            this.Username_textfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_textfield
            // 
            this.Password_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textfield.Location = new System.Drawing.Point(267, 348);
            this.Password_textfield.Name = "Password_textfield";
            this.Password_textfield.Size = new System.Drawing.Size(330, 26);
            this.Password_textfield.TabIndex = 5;
            this.Password_textfield.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_Username_Test_V02DataSet
            // 
            this.password_Username_Test_V02DataSet.DataSetName = "Password_Username_Test_V02DataSet";
            this.password_Username_Test_V02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.password_Username_Test_V02DataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Edit_Credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_textfield);
            this.Controls.Add(this.Username_textfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Credentials";
            this.Text = "Edit_Credentials";
            this.Load += new System.EventHandler(this.Edit_Credentials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.password_Username_Test_V02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username_textfield;
        private System.Windows.Forms.TextBox Password_textfield;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Password_Username_Test_V02DataSet password_Username_Test_V02DataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Password_Username_Test_V02DataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}