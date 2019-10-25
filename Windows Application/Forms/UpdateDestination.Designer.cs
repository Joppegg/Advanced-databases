namespace Windows_Application
{
    partial class UpdateDestination
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
            this.lblDestinationHotel = new System.Windows.Forms.Label();
            this.lblDestinationCity = new System.Windows.Forms.Label();
            this.btnUpdateDestination = new System.Windows.Forms.Button();
            this.textBoxDestinationCountry = new System.Windows.Forms.TextBox();
            this.textBoxDestinationCity = new System.Windows.Forms.TextBox();
            this.textBoxDestinationHotel = new System.Windows.Forms.TextBox();
            this.textBoxDestinationNbr = new System.Windows.Forms.TextBox();
            this.lblDestinationNbr = new System.Windows.Forms.Label();
            this.lblUpdateDestinationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDestinationCountry
            // 
            this.lblDestinationCountry.AutoSize = true;
            this.lblDestinationCountry.Location = new System.Drawing.Point(100, 61);
            this.lblDestinationCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationCountry.Name = "lblDestinationCountry";
            this.lblDestinationCountry.Size = new System.Drawing.Size(101, 13);
            this.lblDestinationCountry.TabIndex = 7;
            this.lblDestinationCountry.Text = "Destination country:";
            // 
            // lblDestinationHotel
            // 
            this.lblDestinationHotel.AutoSize = true;
            this.lblDestinationHotel.Location = new System.Drawing.Point(100, 110);
            this.lblDestinationHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationHotel.Name = "lblDestinationHotel";
            this.lblDestinationHotel.Size = new System.Drawing.Size(89, 13);
            this.lblDestinationHotel.TabIndex = 9;
            this.lblDestinationHotel.Text = "Destination hotel:";
            // 
            // lblDestinationCity
            // 
            this.lblDestinationCity.AutoSize = true;
            this.lblDestinationCity.Location = new System.Drawing.Point(100, 86);
            this.lblDestinationCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationCity.Name = "lblDestinationCity";
            this.lblDestinationCity.Size = new System.Drawing.Size(82, 13);
            this.lblDestinationCity.TabIndex = 8;
            this.lblDestinationCity.Text = "Destination city:";
            // 
            // btnUpdateDestination
            // 
            this.btnUpdateDestination.Location = new System.Drawing.Point(214, 188);
            this.btnUpdateDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDestination.Name = "btnUpdateDestination";
            this.btnUpdateDestination.Size = new System.Drawing.Size(137, 37);
            this.btnUpdateDestination.TabIndex = 5;
            this.btnUpdateDestination.Text = "Update destination";
            this.btnUpdateDestination.UseVisualStyleBackColor = true;
            this.btnUpdateDestination.Click += new System.EventHandler(this.btnUpdateDestination_Click);
            // 
            // textBoxDestinationCountry
            // 
            this.textBoxDestinationCountry.Location = new System.Drawing.Point(235, 61);
            this.textBoxDestinationCountry.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationCountry.Name = "textBoxDestinationCountry";
            this.textBoxDestinationCountry.Size = new System.Drawing.Size(110, 20);
            this.textBoxDestinationCountry.TabIndex = 1;
            this.textBoxDestinationCountry.TextChanged += new System.EventHandler(this.textBoxDestinationCountry_TextChanged);
            // 
            // textBoxDestinationCity
            // 
            this.textBoxDestinationCity.Location = new System.Drawing.Point(235, 86);
            this.textBoxDestinationCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationCity.Name = "textBoxDestinationCity";
            this.textBoxDestinationCity.Size = new System.Drawing.Size(110, 20);
            this.textBoxDestinationCity.TabIndex = 2;
            // 
            // textBoxDestinationHotel
            // 
            this.textBoxDestinationHotel.Location = new System.Drawing.Point(235, 110);
            this.textBoxDestinationHotel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationHotel.Name = "textBoxDestinationHotel";
            this.textBoxDestinationHotel.Size = new System.Drawing.Size(110, 20);
            this.textBoxDestinationHotel.TabIndex = 3;
            // 
            // textBoxDestinationNbr
            // 
            this.textBoxDestinationNbr.Enabled = false;
            this.textBoxDestinationNbr.Location = new System.Drawing.Point(235, 18);
            this.textBoxDestinationNbr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDestinationNbr.Name = "textBoxDestinationNbr";
            this.textBoxDestinationNbr.Size = new System.Drawing.Size(93, 20);
            this.textBoxDestinationNbr.TabIndex = 0;
            // 
            // lblDestinationNbr
            // 
            this.lblDestinationNbr.AutoSize = true;
            this.lblDestinationNbr.Location = new System.Drawing.Point(122, 20);
            this.lblDestinationNbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationNbr.Name = "lblDestinationNbr";
            this.lblDestinationNbr.Size = new System.Drawing.Size(101, 13);
            this.lblDestinationNbr.TabIndex = 6;
            this.lblDestinationNbr.Text = "Destination number:";
            // 
            // lblUpdateDestinationError
            // 
            this.lblUpdateDestinationError.AutoSize = true;
            this.lblUpdateDestinationError.Location = new System.Drawing.Point(236, 141);
            this.lblUpdateDestinationError.Name = "lblUpdateDestinationError";
            this.lblUpdateDestinationError.Size = new System.Drawing.Size(0, 13);
            this.lblUpdateDestinationError.TabIndex = 4;
            // 
            // UpdateDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblUpdateDestinationError);
            this.Controls.Add(this.lblDestinationNbr);
            this.Controls.Add(this.textBoxDestinationNbr);
            this.Controls.Add(this.textBoxDestinationHotel);
            this.Controls.Add(this.textBoxDestinationCity);
            this.Controls.Add(this.textBoxDestinationCountry);
            this.Controls.Add(this.btnUpdateDestination);
            this.Controls.Add(this.lblDestinationCity);
            this.Controls.Add(this.lblDestinationHotel);
            this.Controls.Add(this.lblDestinationCountry);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateDestination";
            this.Text = "UpdateDestination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinationCountry;
        private System.Windows.Forms.Label lblDestinationHotel;
        private System.Windows.Forms.Label lblDestinationCity;
        private System.Windows.Forms.Button btnUpdateDestination;
        private System.Windows.Forms.TextBox textBoxDestinationCountry;
        private System.Windows.Forms.TextBox textBoxDestinationCity;
        private System.Windows.Forms.TextBox textBoxDestinationHotel;
        private System.Windows.Forms.TextBox textBoxDestinationNbr;
        private System.Windows.Forms.Label lblDestinationNbr;
        private System.Windows.Forms.Label lblUpdateDestinationError;
    }
}