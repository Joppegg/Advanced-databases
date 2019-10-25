namespace DBReaderForm
{
    partial class Form1
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabDestinations = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TabPage();
            this.lblDestinations = new System.Windows.Forms.Label();
            this.dataGridViewDestinations = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabDestinations.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.Destination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeColumns = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(62, 108);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomers.MultiSelect = false;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(539, 262);
            this.dataGridViewCustomers.TabIndex = 1;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // tabDestinations
            // 
            this.tabDestinations.Controls.Add(this.tabCustomers);
            this.tabDestinations.Controls.Add(this.Destination);
            this.tabDestinations.Controls.Add(this.tabPage1);
            this.tabDestinations.Location = new System.Drawing.Point(-1, 2);
            this.tabDestinations.Margin = new System.Windows.Forms.Padding(2);
            this.tabDestinations.Name = "tabDestinations";
            this.tabDestinations.SelectedIndex = 0;
            this.tabDestinations.Size = new System.Drawing.Size(728, 483);
            this.tabDestinations.TabIndex = 2;
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCustomers.Controls.Add(this.lblError);
            this.tabCustomers.Controls.Add(this.lblCustomers);
            this.tabCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Size = new System.Drawing.Size(720, 457);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(264, 400);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(275, 88);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(86, 18);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "Customers:";
            // 
            // Destination
            // 
            this.Destination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Destination.Controls.Add(this.lblDestinations);
            this.Destination.Controls.Add(this.dataGridViewDestinations);
            this.Destination.Location = new System.Drawing.Point(4, 22);
            this.Destination.Margin = new System.Windows.Forms.Padding(2);
            this.Destination.Name = "Destination";
            this.Destination.Padding = new System.Windows.Forms.Padding(2);
            this.Destination.Size = new System.Drawing.Size(720, 457);
            this.Destination.TabIndex = 1;
            this.Destination.Text = "Destinations";
            // 
            // lblDestinations
            // 
            this.lblDestinations.AutoSize = true;
            this.lblDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinations.Location = new System.Drawing.Point(267, 88);
            this.lblDestinations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinations.Name = "lblDestinations";
            this.lblDestinations.Size = new System.Drawing.Size(94, 18);
            this.lblDestinations.TabIndex = 3;
            this.lblDestinations.Text = "Destinations:";
            // 
            // dataGridViewDestinations
            // 
            this.dataGridViewDestinations.AllowUserToAddRows = false;
            this.dataGridViewDestinations.AllowUserToDeleteRows = false;
            this.dataGridViewDestinations.AllowUserToResizeColumns = false;
            this.dataGridViewDestinations.AllowUserToResizeRows = false;
            this.dataGridViewDestinations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestinations.Location = new System.Drawing.Point(62, 108);
            this.dataGridViewDestinations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDestinations.MultiSelect = false;
            this.dataGridViewDestinations.Name = "dataGridViewDestinations";
            this.dataGridViewDestinations.ReadOnly = true;
            this.dataGridViewDestinations.RowTemplate.Height = 24;
            this.dataGridViewDestinations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDestinations.Size = new System.Drawing.Size(539, 262);
            this.dataGridViewDestinations.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewBookings);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(720, 457);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bookings";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bookings:";
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AllowUserToAddRows = false;
            this.dataGridViewBookings.AllowUserToDeleteRows = false;
            this.dataGridViewBookings.AllowUserToResizeColumns = false;
            this.dataGridViewBookings.AllowUserToResizeRows = false;
            this.dataGridViewBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(62, 108);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBookings.MultiSelect = false;
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.RowTemplate.Height = 24;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(539, 262);
            this.dataGridViewBookings.TabIndex = 3;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(DBReaderForm.ServiceReference1.Booking);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DBReaderForm.localhost.Customer);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(DBReaderForm.localhost.Customer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 475);
            this.Controls.Add(this.tabDestinations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabDestinations.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.Destination.ResumeLayout(false);
            this.Destination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TabControl tabDestinations;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage Destination;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewDestinations;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblDestinations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
    }
}

