namespace Windows_Application
{
    partial class AddDestination
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
            this.lblDestinationCountry = new System.Windows.Forms.Label();
            this.lblDestinationCity = new System.Windows.Forms.Label();
            this.lblDestinationHotel = new System.Windows.Forms.Label();
            this.textBoxDestinationCountry = new System.Windows.Forms.TextBox();
            this.textBoxDestinationCity = new System.Windows.Forms.TextBox();
            this.textBoxDestinationHotel = new System.Windows.Forms.TextBox();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.lblAddDestinationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDestinationCountry
            // 
            this.lblDestinationCountry.AutoSize = true;
            this.lblDestinationCountry.Location = new System.Drawing.Point(87, 65);
            this.lblDestinationCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationCountry.Name = "lblDestinationCountry";
            this.lblDestinationCountry.Size = new System.Drawing.Size(101, 13);
            this.lblDestinationCountry.TabIndex = 4;
            this.lblDestinationCountry.Text = "Destination country:";
            // 
            // lblDestinationCity
            // 
            this.lblDestinationCity.AutoSize = true;
            this.lblDestinationCity.Location = new System.Drawing.Point(87, 94);
            this.lblDestinationCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationCity.Name = "lblDestinationCity";
            this.lblDestinationCity.Size = new System.Drawing.Size(82, 13);
            this.lblDestinationCity.TabIndex = 5;
            this.lblDestinationCity.Text = "Destination city:";
            // 
            // lblDestinationHotel
            // 
            this.lblDestinationHotel.AutoSize = true;
            this.lblDestinationHotel.Location = new System.Drawing.Point(87, 123);
            this.lblDestinationHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationHotel.Name = "lblDestinationHotel";
            this.lblDestinationHotel.Size = new System.Drawing.Size(89, 13);
            this.lblDestinationHotel.TabIndex = 6;
            this.lblDestinationHotel.Text = "Destination hotel:";
            // 
            // textBoxDestinationCountry
            // 
            this.textBoxDestinationCountry.Location = new System.Drawing.Point(206, 65);
            this.textBoxDestinationCountry.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationCountry.Name = "textBoxDestinationCountry";
            this.textBoxDestinationCountry.Size = new System.Drawing.Size(98, 20);
            this.textBoxDestinationCountry.TabIndex = 0;
            // 
            // textBoxDestinationCity
            // 
            this.textBoxDestinationCity.Location = new System.Drawing.Point(206, 94);
            this.textBoxDestinationCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationCity.Name = "textBoxDestinationCity";
            this.textBoxDestinationCity.Size = new System.Drawing.Size(98, 20);
            this.textBoxDestinationCity.TabIndex = 1;
            // 
            // textBoxDestinationHotel
            // 
            this.textBoxDestinationHotel.Location = new System.Drawing.Point(206, 123);
            this.textBoxDestinationHotel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationHotel.Name = "textBoxDestinationHotel";
            this.textBoxDestinationHotel.Size = new System.Drawing.Size(98, 20);
            this.textBoxDestinationHotel.TabIndex = 2;
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(178, 180);
            this.btnAddDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(147, 28);
            this.btnAddDestination.TabIndex = 3;
            this.btnAddDestination.Text = "Add destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // lblAddDestinationError
            // 
            this.lblAddDestinationError.AutoSize = true;
            this.lblAddDestinationError.Location = new System.Drawing.Point(206, 147);
            this.lblAddDestinationError.Name = "lblAddDestinationError";
            this.lblAddDestinationError.Size = new System.Drawing.Size(0, 13);
            this.lblAddDestinationError.TabIndex = 7;
            // 
            // AddDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblAddDestinationError);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.textBoxDestinationHotel);
            this.Controls.Add(this.textBoxDestinationCity);
            this.Controls.Add(this.textBoxDestinationCountry);
            this.Controls.Add(this.lblDestinationHotel);
            this.Controls.Add(this.lblDestinationCity);
            this.Controls.Add(this.lblDestinationCountry);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDestination";
            this.Text = "AddDestination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinationCountry;
        private System.Windows.Forms.Label lblDestinationCity;
        private System.Windows.Forms.Label lblDestinationHotel;
        private System.Windows.Forms.TextBox textBoxDestinationCountry;
        private System.Windows.Forms.TextBox textBoxDestinationCity;
        private System.Windows.Forms.TextBox textBoxDestinationHotel;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Label lblAddDestinationError;
    }
}