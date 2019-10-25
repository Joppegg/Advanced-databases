using System;

namespace Windows_Application
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.tabDestination = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.lblDeletePersonError = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDeleteDestination = new System.Windows.Forms.Label();
            this.dataGridViewDestination = new System.Windows.Forms.DataGridView();
            this.btnUpdateDestination = new System.Windows.Forms.Button();
            this.btnDeleteDestination = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDeleteBooking = new System.Windows.Forms.Label();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDestination.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(518, 286);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(126, 45);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(113, 26);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "Add new person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Enabled = false;
            this.btnDeletePerson.Location = new System.Drawing.Point(525, 45);
            this.btnDeletePerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(119, 26);
            this.btnDeletePerson.TabIndex = 15;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Enabled = false;
            this.btnUpdatePerson.Location = new System.Drawing.Point(415, 45);
            this.btnUpdatePerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(104, 26);
            this.btnUpdatePerson.TabIndex = 16;
            this.btnUpdatePerson.Text = "Update Person";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // tabDestination
            // 
            this.tabDestination.Controls.Add(this.tabCustomer);
            this.tabDestination.Controls.Add(this.tabPage2);
            this.tabDestination.Controls.Add(this.tabPage1);
            this.tabDestination.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDestination.Location = new System.Drawing.Point(-2, 0);
            this.tabDestination.Margin = new System.Windows.Forms.Padding(2);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.SelectedIndex = 0;
            this.tabDestination.Size = new System.Drawing.Size(865, 418);
            this.tabDestination.TabIndex = 17;
            this.tabDestination.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabDestination_Selected);
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.LightGray;
            this.tabCustomer.Controls.Add(this.lblDeletePersonError);
            this.tabCustomer.Controls.Add(this.btnUpdatePerson);
            this.tabCustomer.Controls.Add(this.dataGridView1);
            this.tabCustomer.Controls.Add(this.btnDeletePerson);
            this.tabCustomer.Controls.Add(this.btnAddPerson);
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomer.Size = new System.Drawing.Size(857, 389);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer";
            // 
            // lblDeletePersonError
            // 
            this.lblDeletePersonError.AutoSize = true;
            this.lblDeletePersonError.Location = new System.Drawing.Point(123, 363);
            this.lblDeletePersonError.Name = "lblDeletePersonError";
            this.lblDeletePersonError.Size = new System.Drawing.Size(0, 16);
            this.lblDeletePersonError.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.lblDeleteDestination);
            this.tabPage2.Controls.Add(this.dataGridViewDestination);
            this.tabPage2.Controls.Add(this.btnUpdateDestination);
            this.tabPage2.Controls.Add(this.btnDeleteDestination);
            this.tabPage2.Controls.Add(this.btnAddDestination);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(857, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Destination";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblDeleteDestination
            // 
            this.lblDeleteDestination.AutoSize = true;
            this.lblDeleteDestination.Location = new System.Drawing.Point(56, 248);
            this.lblDeleteDestination.Name = "lblDeleteDestination";
            this.lblDeleteDestination.Size = new System.Drawing.Size(0, 16);
            this.lblDeleteDestination.TabIndex = 12;
            // 
            // dataGridViewDestination
            // 
            this.dataGridViewDestination.AllowUserToAddRows = false;
            this.dataGridViewDestination.AllowUserToDeleteRows = false;
            this.dataGridViewDestination.AllowUserToResizeColumns = false;
            this.dataGridViewDestination.AllowUserToResizeRows = false;
            this.dataGridViewDestination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestination.Location = new System.Drawing.Point(126, 75);
            this.dataGridViewDestination.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDestination.MultiSelect = false;
            this.dataGridViewDestination.Name = "dataGridViewDestination";
            this.dataGridViewDestination.ReadOnly = true;
            this.dataGridViewDestination.RowHeadersVisible = false;
            this.dataGridViewDestination.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDestination.RowTemplate.Height = 24;
            this.dataGridViewDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDestination.Size = new System.Drawing.Size(518, 286);
            this.dataGridViewDestination.TabIndex = 10;
            this.dataGridViewDestination.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestination_CellClick);
            this.dataGridViewDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestination_CellContentClick);
            // 
            // btnUpdateDestination
            // 
            this.btnUpdateDestination.Enabled = false;
            this.btnUpdateDestination.Location = new System.Drawing.Point(394, 42);
            this.btnUpdateDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDestination.Name = "btnUpdateDestination";
            this.btnUpdateDestination.Size = new System.Drawing.Size(122, 29);
            this.btnUpdateDestination.TabIndex = 2;
            this.btnUpdateDestination.Text = "Update destination";
            this.btnUpdateDestination.UseVisualStyleBackColor = true;
            this.btnUpdateDestination.Click += new System.EventHandler(this.btnUpdateDestination_Click);
            // 
            // btnDeleteDestination
            // 
            this.btnDeleteDestination.Enabled = false;
            this.btnDeleteDestination.Location = new System.Drawing.Point(520, 42);
            this.btnDeleteDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDestination.Name = "btnDeleteDestination";
            this.btnDeleteDestination.Size = new System.Drawing.Size(122, 30);
            this.btnDeleteDestination.TabIndex = 1;
            this.btnDeleteDestination.Text = "Delete destination";
            this.btnDeleteDestination.UseVisualStyleBackColor = true;
            this.btnDeleteDestination.Click += new System.EventHandler(this.btnDeleteDestination_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(126, 44);
            this.btnAddDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(122, 27);
            this.btnAddDestination.TabIndex = 0;
            this.btnAddDestination.Text = "Add destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.lblDeleteBooking);
            this.tabPage1.Controls.Add(this.btnUpdateBooking);
            this.tabPage1.Controls.Add(this.btnDeleteBooking);
            this.tabPage1.Controls.Add(this.btnAddBooking);
            this.tabPage1.Controls.Add(this.dataGridViewBooking);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(857, 389);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bookings";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // lblDeleteBooking
            // 
            this.lblDeleteBooking.AutoSize = true;
            this.lblDeleteBooking.Location = new System.Drawing.Point(39, 203);
            this.lblDeleteBooking.Name = "lblDeleteBooking";
            this.lblDeleteBooking.Size = new System.Drawing.Size(0, 16);
            this.lblDeleteBooking.TabIndex = 5;
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Enabled = false;
            this.btnUpdateBooking.Location = new System.Drawing.Point(421, 41);
            this.btnUpdateBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(112, 30);
            this.btnUpdateBooking.TabIndex = 4;
            this.btnUpdateBooking.Text = "Update booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Enabled = false;
            this.btnDeleteBooking.Location = new System.Drawing.Point(535, 41);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(109, 30);
            this.btnDeleteBooking.TabIndex = 2;
            this.btnDeleteBooking.Text = "Delete booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(126, 39);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(123, 32);
            this.btnAddBooking.TabIndex = 1;
            this.btnAddBooking.Text = "Add booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.AllowUserToAddRows = false;
            this.dataGridViewBooking.AllowUserToDeleteRows = false;
            this.dataGridViewBooking.AllowUserToResizeColumns = false;
            this.dataGridViewBooking.AllowUserToResizeRows = false;
            this.dataGridViewBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(126, 75);
            this.dataGridViewBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBooking.MultiSelect = false;
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.ReadOnly = true;
            this.dataGridViewBooking.RowHeadersVisible = false;
            this.dataGridViewBooking.RowTemplate.Height = 24;
            this.dataGridViewBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooking.Size = new System.Drawing.Size(518, 286);
            this.dataGridViewBooking.TabIndex = 0;
            this.dataGridViewBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellClick);
            this.dataGridViewBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 415);
            this.Controls.Add(this.tabDestination);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDestination.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.TabControl tabDestination;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateDestination;
        private System.Windows.Forms.Button btnDeleteDestination;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.DataGridView dataGridViewDestination;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Label lblDeletePersonError;
        private System.Windows.Forms.Label lblDeleteDestination;
        private System.Windows.Forms.Label lblDeleteBooking;
    }
}

