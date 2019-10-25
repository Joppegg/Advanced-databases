namespace Windows_Application
{
    partial class AddBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
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
            this.lblAddBookingSelectCustomer = new System.Windows.Forms.Label();
            this.dataGridViewCustomerBooking = new System.Windows.Forms.DataGridView();
            this.dataGridViewDestinationBooking = new System.Windows.Forms.DataGridView();
            this.lblSelectDestinationBooking = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHome = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.lblAddBookingError = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinationBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddBookingSelectCustomer
            // 
            this.lblAddBookingSelectCustomer.AutoSize = true;
            this.lblAddBookingSelectCustomer.Location = new System.Drawing.Point(9, 28);
            this.lblAddBookingSelectCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddBookingSelectCustomer.Name = "lblAddBookingSelectCustomer";
            this.lblAddBookingSelectCustomer.Size = new System.Drawing.Size(86, 13);
            this.lblAddBookingSelectCustomer.TabIndex = 0;
            this.lblAddBookingSelectCustomer.Text = "Select customer:";
            // 
            // dataGridViewCustomerBooking
            // 
            this.dataGridViewCustomerBooking.AllowUserToAddRows = false;
            this.dataGridViewCustomerBooking.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerBooking.AllowUserToResizeColumns = false;
            this.dataGridViewCustomerBooking.AllowUserToResizeRows = false;
            this.dataGridViewCustomerBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerBooking.Location = new System.Drawing.Point(11, 41);
            this.dataGridViewCustomerBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomerBooking.MultiSelect = false;
            this.dataGridViewCustomerBooking.Name = "dataGridViewCustomerBooking";
            this.dataGridViewCustomerBooking.ReadOnly = true;
            this.dataGridViewCustomerBooking.RowHeadersVisible = false;
            this.dataGridViewCustomerBooking.RowTemplate.Height = 24;
            this.dataGridViewCustomerBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomerBooking.Size = new System.Drawing.Size(291, 154);
            this.dataGridViewCustomerBooking.TabIndex = 1;
            this.dataGridViewCustomerBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerBooking_CellClick);
            this.dataGridViewCustomerBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewDestinationBooking
            // 
            this.dataGridViewDestinationBooking.AllowUserToAddRows = false;
            this.dataGridViewDestinationBooking.AllowUserToDeleteRows = false;
            this.dataGridViewDestinationBooking.AllowUserToResizeColumns = false;
            this.dataGridViewDestinationBooking.AllowUserToResizeRows = false;
            this.dataGridViewDestinationBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDestinationBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestinationBooking.Enabled = false;
            this.dataGridViewDestinationBooking.Location = new System.Drawing.Point(10, 231);
            this.dataGridViewDestinationBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDestinationBooking.MultiSelect = false;
            this.dataGridViewDestinationBooking.Name = "dataGridViewDestinationBooking";
            this.dataGridViewDestinationBooking.ReadOnly = true;
            this.dataGridViewDestinationBooking.RowHeadersVisible = false;
            this.dataGridViewDestinationBooking.RowTemplate.Height = 24;
            this.dataGridViewDestinationBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDestinationBooking.Size = new System.Drawing.Size(292, 170);
            this.dataGridViewDestinationBooking.TabIndex = 4;
            this.dataGridViewDestinationBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestinationBooking_CellClick);
            this.dataGridViewDestinationBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestinationBooking_CellContentClick);
            // 
            // lblSelectDestinationBooking
            // 
            this.lblSelectDestinationBooking.AutoSize = true;
            this.lblSelectDestinationBooking.Location = new System.Drawing.Point(9, 216);
            this.lblSelectDestinationBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectDestinationBooking.Name = "lblSelectDestinationBooking";
            this.lblSelectDestinationBooking.Size = new System.Drawing.Size(94, 13);
            this.lblSelectDestinationBooking.TabIndex = 3;
            this.lblSelectDestinationBooking.Text = "Select destination:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Enabled = false;
            this.dateTimePickerOut.Location = new System.Drawing.Point(332, 43);
            this.dateTimePickerOut.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(338, 20);
            this.dateTimePickerOut.TabIndex = 2;
            this.dateTimePickerOut.Value = new System.DateTime(2019, 3, 5, 13, 38, 39, 0);
            this.dateTimePickerOut.ValueChanged += new System.EventHandler(this.dateTimePickerOut_ValueChanged);
            // 
            // dateTimePickerHome
            // 
            this.dateTimePickerHome.Enabled = false;
            this.dateTimePickerHome.Location = new System.Drawing.Point(332, 231);
            this.dateTimePickerHome.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHome.Name = "dateTimePickerHome";
            this.dateTimePickerHome.Size = new System.Drawing.Size(339, 20);
            this.dateTimePickerHome.TabIndex = 5;
            this.dateTimePickerHome.ValueChanged += new System.EventHandler(this.dateTimePickerHome_ValueChanged);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Enabled = false;
            this.btnConfirmBooking.Location = new System.Drawing.Point(529, 354);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(141, 31);
            this.btnConfirmBooking.TabIndex = 6;
            this.btnConfirmBooking.Text = "Add booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddBookingError
            // 
            this.lblAddBookingError.AutoSize = true;
            this.lblAddBookingError.Location = new System.Drawing.Point(526, 399);
            this.lblAddBookingError.Name = "lblAddBookingError";
            this.lblAddBookingError.Size = new System.Drawing.Size(0, 13);
            this.lblAddBookingError.TabIndex = 7;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(329, 28);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(124, 13);
            this.lblDepartureDate.TabIndex = 8;
            this.lblDepartureDate.Text = "Select date of departure:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(329, 216);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(106, 13);
            this.lblReturnDate.TabIndex = 9;
            this.lblReturnDate.Text = "Select date of return:";
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 441);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblAddBookingError);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.dateTimePickerHome);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.lblSelectDestinationBooking);
            this.Controls.Add(this.dataGridViewDestinationBooking);
            this.Controls.Add(this.dataGridViewCustomerBooking);
            this.Controls.Add(this.lblAddBookingSelectCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.Load += new System.EventHandler(this.AddBooking_Load);
            this.Shown += new System.EventHandler(this.AddBooking_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinationBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddBookingSelectCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomerBooking;
        private System.Windows.Forms.DataGridView dataGridViewDestinationBooking;
        private System.Windows.Forms.Label lblSelectDestinationBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerHome;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Label lblAddBookingError;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblReturnDate;
    }
}