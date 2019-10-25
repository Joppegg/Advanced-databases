namespace Windows_Application
{
    partial class AddCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerIdNumber = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.lblAddCustomerError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(212, 182);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(116, 28);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(123, 81);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(113, 105);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerAddress.TabIndex = 5;
            this.lblCustomerAddress.Text = "Customer Address:";
            // 
            // lblCustomerIdNumber
            // 
            this.lblCustomerIdNumber.AutoSize = true;
            this.lblCustomerIdNumber.Location = new System.Drawing.Point(8, 126);
            this.lblCustomerIdNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerIdNumber.Name = "lblCustomerIdNumber";
            this.lblCustomerIdNumber.Size = new System.Drawing.Size(200, 13);
            this.lblCustomerIdNumber.TabIndex = 6;
            this.lblCustomerIdNumber.Text = "Customer ID Number (YYMMDDXXXX): *";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(212, 74);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(116, 20);
            this.textBoxCustomerName.TabIndex = 0;
            this.textBoxCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(212, 98);
            this.textBoxCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(116, 20);
            this.textBoxCustomerAddress.TabIndex = 1;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(212, 123);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(116, 20);
            this.textBoxCustomerID.TabIndex = 2;
            // 
            // lblAddCustomerError
            // 
            this.lblAddCustomerError.AutoSize = true;
            this.lblAddCustomerError.ForeColor = System.Drawing.Color.Red;
            this.lblAddCustomerError.Location = new System.Drawing.Point(213, 153);
            this.lblAddCustomerError.Name = "lblAddCustomerError";
            this.lblAddCustomerError.Size = new System.Drawing.Size(0, 13);
            this.lblAddCustomerError.TabIndex = 7;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 312);
            this.Controls.Add(this.lblAddCustomerError);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.lblCustomerIdNumber);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnAddCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerIdNumber;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label lblAddCustomerError;
    }
}