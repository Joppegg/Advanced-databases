namespace Windows_Application
{
    partial class UpdateBooking
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
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.dateTimePickerHome = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDestinationBooking = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomerBooking = new System.Windows.Forms.DataGridView();
            this.textBoxBookingNbrShow = new System.Windows.Forms.TextBox();
            this.lblUpdateBookingError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinationBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Enabled = false;
            this.btnConfirmBooking.Location = new System.Drawing.Point(457, 310);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(141, 31);
            this.btnConfirmBooking.TabIndex = 12;
            this.btnConfirmBooking.Text = "Update Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // dateTimePickerHome
            // 
            this.dateTimePickerHome.Location = new System.Drawing.Point(330, 235);
            this.dateTimePickerHome.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHome.Name = "dateTimePickerHome";
            this.dateTimePickerHome.Size = new System.Drawing.Size(339, 20);
            this.dateTimePickerHome.TabIndex = 11;
            this.dateTimePickerHome.ValueChanged += new System.EventHandler(this.dateTimePickerHome_ValueChanged);
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(330, 42);
            this.dateTimePickerOut.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(314, 20);
            this.dateTimePickerOut.TabIndex = 10;
            this.dateTimePickerOut.ValueChanged += new System.EventHandler(this.dateTimePickerOut_ValueChanged);
            // 
            // dataGridViewDestinationBooking
            // 
            this.dataGridViewDestinationBooking.AllowUserToAddRows = false;
            this.dataGridViewDestinationBooking.AllowUserToDeleteRows = false;
            this.dataGridViewDestinationBooking.AllowUserToResizeColumns = false;
            this.dataGridViewDestinationBooking.AllowUserToResizeRows = false;
            this.dataGridViewDestinationBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDestinationBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestinationBooking.Location = new System.Drawing.Point(9, 221);
            this.dataGridViewDestinationBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDestinationBooking.MultiSelect = false;
            this.dataGridViewDestinationBooking.Name = "dataGridViewDestinationBooking";
            this.dataGridViewDestinationBooking.ReadOnly = true;
            this.dataGridViewDestinationBooking.RowHeadersVisible = false;
            this.dataGridViewDestinationBooking.RowTemplate.Height = 24;
            this.dataGridViewDestinationBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDestinationBooking.Size = new System.Drawing.Size(292, 170);
            this.dataGridViewDestinationBooking.TabIndex = 9;
            // 
            // dataGridViewCustomerBooking
            // 
            this.dataGridViewCustomerBooking.AllowUserToAddRows = false;
            this.dataGridViewCustomerBooking.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerBooking.AllowUserToResizeColumns = false;
            this.dataGridViewCustomerBooking.AllowUserToResizeRows = false;
            this.dataGridViewCustomerBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerBooking.Location = new System.Drawing.Point(10, 32);
            this.dataGridViewCustomerBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomerBooking.MultiSelect = false;
            this.dataGridViewCustomerBooking.Name = "dataGridViewCustomerBooking";
            this.dataGridViewCustomerBooking.ReadOnly = true;
            this.dataGridViewCustomerBooking.RowHeadersVisible = false;
            this.dataGridViewCustomerBooking.RowTemplate.Height = 24;
            this.dataGridViewCustomerBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomerBooking.Size = new System.Drawing.Size(291, 154);
            this.dataGridViewCustomerBooking.TabIndex = 8;
            this.dataGridViewCustomerBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerBooking_CellContentClick);
            // 
            // textBoxBookingNbrShow
            // 
            this.textBoxBookingNbrShow.Enabled = false;
            this.textBoxBookingNbrShow.Location = new System.Drawing.Point(238, 2);
            this.textBoxBookingNbrShow.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookingNbrShow.Name = "textBoxBookingNbrShow";
            this.textBoxBookingNbrShow.Size = new System.Drawing.Size(159, 20);
            this.textBoxBookingNbrShow.TabIndex = 13;
            this.textBoxBookingNbrShow.TextChanged += new System.EventHandler(this.textBoxBookingNbrShow_TextChanged);
            // 
            // lblUpdateBookingError
            // 
            this.lblUpdateBookingError.AutoSize = true;
            this.lblUpdateBookingError.Location = new System.Drawing.Point(464, 343);
            this.lblUpdateBookingError.Name = "lblUpdateBookingError";
            this.lblUpdateBookingError.Size = new System.Drawing.Size(0, 13);
            this.lblUpdateBookingError.TabIndex = 14;
            // 
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 401);
            this.Controls.Add(this.lblUpdateBookingError);
            this.Controls.Add(this.textBoxBookingNbrShow);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.dateTimePickerHome);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dataGridViewDestinationBooking);
            this.Controls.Add(this.dataGridViewCustomerBooking);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateBooking";
            this.Text = "Update_Booking";
            this.Load += new System.EventHandler(this.UpdateBooking_Load);
            this.Shown += new System.EventHandler(this.UpdateBooking_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinationBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerHome;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DataGridView dataGridViewDestinationBooking;
        private System.Windows.Forms.DataGridView dataGridViewCustomerBooking;
        private System.Windows.Forms.TextBox textBoxBookingNbrShow;
        private System.Windows.Forms.Label lblUpdateBookingError;
    }
}