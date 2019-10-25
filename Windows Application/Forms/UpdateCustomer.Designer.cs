namespace Windows_Application
{
    partial class UpdateCustomer
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
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerNbr = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerIdNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerNbr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblUpdateCustomerError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(245, 173);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(112, 29);
            this.btnUpdateCustomer.TabIndex = 4;
            this.btnUpdateCustomer.Text = "Update customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(245, 75);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(103, 20);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // textBoxCustomerNbr
            // 
            this.textBoxCustomerNbr.Enabled = false;
            this.textBoxCustomerNbr.Location = new System.Drawing.Point(245, 51);
            this.textBoxCustomerNbr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerNbr.Name = "textBoxCustomerNbr";
            this.textBoxCustomerNbr.Size = new System.Drawing.Size(103, 20);
            this.textBoxCustomerNbr.TabIndex = 0;
            this.textBoxCustomerNbr.TextChanged += new System.EventHandler(this.textBoxCustomerNbr_TextChanged);
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(245, 102);
            this.textBoxCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(103, 20);
            this.textBoxCustomerAddress.TabIndex = 2;
            // 
            // textBoxCustomerIdNumber
            // 
            this.textBoxCustomerIdNumber.Location = new System.Drawing.Point(245, 126);
            this.textBoxCustomerIdNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomerIdNumber.Name = "textBoxCustomerIdNumber";
            this.textBoxCustomerIdNumber.Size = new System.Drawing.Size(103, 20);
            this.textBoxCustomerIdNumber.TabIndex = 3;
            // 
            // lblCustomerNbr
            // 
            this.lblCustomerNbr.AutoSize = true;
            this.lblCustomerNbr.Location = new System.Drawing.Point(149, 54);
            this.lblCustomerNbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerNbr.Name = "lblCustomerNbr";
            this.lblCustomerNbr.Size = new System.Drawing.Size(92, 13);
            this.lblCustomerNbr.TabIndex = 5;
            this.lblCustomerNbr.Text = "Customer number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer SSN (YYMMDDXXXX):";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(146, 105);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerAddress.TabIndex = 7;
            this.lblCustomerAddress.Text = "Customer Address:";
            // 
            // lblUpdateCustomerError
            // 
            this.lblUpdateCustomerError.AutoSize = true;
            this.lblUpdateCustomerError.ForeColor = System.Drawing.Color.Red;
            this.lblUpdateCustomerError.Location = new System.Drawing.Point(242, 158);
            this.lblUpdateCustomerError.Name = "lblUpdateCustomerError";
            this.lblUpdateCustomerError.Size = new System.Drawing.Size(0, 13);
            this.lblUpdateCustomerError.TabIndex = 9;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 314);
            this.Controls.Add(this.lblUpdateCustomerError);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerNbr);
            this.Controls.Add(this.textBoxCustomerIdNumber);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.textBoxCustomerNbr);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerNbr;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerIdNumber;
        private System.Windows.Forms.Label lblCustomerNbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblUpdateCustomerError;
    }
}