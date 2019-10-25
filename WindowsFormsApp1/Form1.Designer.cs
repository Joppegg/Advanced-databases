namespace WindowsFormsApp1
{
    partial class Form1
    {
   
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewColumns = new System.Windows.Forms.DataGridView();
            this.dataGridViewTob = new System.Windows.Forms.DataGridView();
            this.dataGridViewRows = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRows)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewColumns
            // 
            this.dataGridViewColumns.AllowUserToAddRows = false;
            this.dataGridViewColumns.AllowUserToDeleteRows = false;
            this.dataGridViewColumns.AllowUserToResizeColumns = false;
            this.dataGridViewColumns.AllowUserToResizeRows = false;
            this.dataGridViewColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumns.ColumnHeadersVisible = false;
            this.dataGridViewColumns.Location = new System.Drawing.Point(248, 184);
            this.dataGridViewColumns.MultiSelect = false;
            this.dataGridViewColumns.Name = "dataGridViewColumns";
            this.dataGridViewColumns.ReadOnly = true;
            this.dataGridViewColumns.RowHeadersVisible = false;
            this.dataGridViewColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewColumns.Size = new System.Drawing.Size(208, 181);
            this.dataGridViewColumns.TabIndex = 1;
            // 
            // dataGridViewTob
            // 
            this.dataGridViewTob.AllowUserToAddRows = false;
            this.dataGridViewTob.AllowUserToDeleteRows = false;
            this.dataGridViewTob.AllowUserToResizeColumns = false;
            this.dataGridViewTob.AllowUserToResizeRows = false;
            this.dataGridViewTob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTob.ColumnHeadersVisible = false;
            this.dataGridViewTob.Location = new System.Drawing.Point(29, 184);
            this.dataGridViewTob.MultiSelect = false;
            this.dataGridViewTob.Name = "dataGridViewTob";
            this.dataGridViewTob.ReadOnly = true;
            this.dataGridViewTob.RowHeadersVisible = false;
            this.dataGridViewTob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTob.Size = new System.Drawing.Size(196, 181);
            this.dataGridViewTob.TabIndex = 2;
            this.dataGridViewTob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewRows
            // 
            this.dataGridViewRows.AllowUserToAddRows = false;
            this.dataGridViewRows.AllowUserToDeleteRows = false;
            this.dataGridViewRows.AllowUserToResizeColumns = false;
            this.dataGridViewRows.AllowUserToResizeRows = false;
            this.dataGridViewRows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRows.ColumnHeadersVisible = false;
            this.dataGridViewRows.Location = new System.Drawing.Point(489, 184);
            this.dataGridViewRows.MultiSelect = false;
            this.dataGridViewRows.Name = "dataGridViewRows";
            this.dataGridViewRows.ReadOnly = true;
            this.dataGridViewRows.RowHeadersVisible = false;
            this.dataGridViewRows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRows.Size = new System.Drawing.Size(208, 181);
            this.dataGridViewRows.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(169, 377);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = " ";
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(87, 168);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(68, 13);
            this.lblTables.TabIndex = 5;
            this.lblTables.Text = "Table names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Column names:";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(562, 168);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(65, 13);
            this.lblRowCount.TabIndex = 7;
            this.lblRowCount.Text = "Row count: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dataGridViewRows);
            this.Controls.Add(this.dataGridViewTob);
            this.Controls.Add(this.dataGridViewColumns);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewColumns;
        private System.Windows.Forms.DataGridView dataGridViewTob;
        private System.Windows.Forms.DataGridView dataGridViewRows;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRowCount;
    }
}

