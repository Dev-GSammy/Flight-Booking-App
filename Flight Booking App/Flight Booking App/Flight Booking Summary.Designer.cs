
namespace Flight_Booking_App
{
    partial class Flight_Booking_Summary
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
            this.lblconfirm = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTripStartDate = new System.Windows.Forms.Label();
            this.lblTripEndDate = new System.Windows.Forms.Label();
            this.lblDocNumber = new System.Windows.Forms.Label();
            this.lblDocIssueDate = new System.Windows.Forms.Label();
            this.lblDocExpiryDate = new System.Windows.Forms.Label();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Button();
            this.Rfullname = new System.Windows.Forms.Label();
            this.rDepartureCity = new System.Windows.Forms.Label();
            this.rDestination = new System.Windows.Forms.Label();
            this.rTripStartDate = new System.Windows.Forms.Label();
            this.rTripEndDate = new System.Windows.Forms.Label();
            this.rDocumentNumber = new System.Windows.Forms.Label();
            this.rDocumentIssueDate = new System.Windows.Forms.Label();
            this.rDocumentExpiryDate = new System.Windows.Forms.Label();
            this.rBaggage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirm.Location = new System.Drawing.Point(89, 18);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(467, 19);
            this.lblconfirm.TabIndex = 0;
            this.lblconfirm.Text = "Here are your details. Please confirm and affirm if true or not.";
            this.lblconfirm.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.BackColor = System.Drawing.Color.CadetBlue;
            this.lblCorrect.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(174, 372);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(113, 40);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "Correct";
            this.lblCorrect.UseVisualStyleBackColor = false;
            this.lblCorrect.Click += new System.EventHandler(this.lblCorrect_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(50, 54);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 19);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(50, 84);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(125, 19);
            this.lblDeparture.TabIndex = 3;
            this.lblDeparture.Text = "Departure City:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(50, 117);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 19);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // lblTripStartDate
            // 
            this.lblTripStartDate.AutoSize = true;
            this.lblTripStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripStartDate.Location = new System.Drawing.Point(50, 152);
            this.lblTripStartDate.Name = "lblTripStartDate";
            this.lblTripStartDate.Size = new System.Drawing.Size(123, 19);
            this.lblTripStartDate.TabIndex = 5;
            this.lblTripStartDate.Text = "Trip Start Date:";
            // 
            // lblTripEndDate
            // 
            this.lblTripEndDate.AutoSize = true;
            this.lblTripEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripEndDate.Location = new System.Drawing.Point(50, 186);
            this.lblTripEndDate.Name = "lblTripEndDate";
            this.lblTripEndDate.Size = new System.Drawing.Size(118, 19);
            this.lblTripEndDate.TabIndex = 6;
            this.lblTripEndDate.Text = "Trip End Date:";
            // 
            // lblDocNumber
            // 
            this.lblDocNumber.AutoSize = true;
            this.lblDocNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocNumber.Location = new System.Drawing.Point(50, 223);
            this.lblDocNumber.Name = "lblDocNumber";
            this.lblDocNumber.Size = new System.Drawing.Size(159, 19);
            this.lblDocNumber.TabIndex = 7;
            this.lblDocNumber.Text = "Document Number:";
            // 
            // lblDocIssueDate
            // 
            this.lblDocIssueDate.AutoSize = true;
            this.lblDocIssueDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocIssueDate.Location = new System.Drawing.Point(50, 258);
            this.lblDocIssueDate.Name = "lblDocIssueDate";
            this.lblDocIssueDate.Size = new System.Drawing.Size(178, 19);
            this.lblDocIssueDate.TabIndex = 8;
            this.lblDocIssueDate.Text = "Document Issue Date:";
            // 
            // lblDocExpiryDate
            // 
            this.lblDocExpiryDate.AutoSize = true;
            this.lblDocExpiryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocExpiryDate.Location = new System.Drawing.Point(50, 300);
            this.lblDocExpiryDate.Name = "lblDocExpiryDate";
            this.lblDocExpiryDate.Size = new System.Drawing.Size(186, 19);
            this.lblDocExpiryDate.TabIndex = 9;
            this.lblDocExpiryDate.Text = "Document Expiry Date:";
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaggage.Location = new System.Drawing.Point(50, 336);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(221, 19);
            this.lblBaggage.TabIndex = 10;
            this.lblBaggage.Text = "Baggage Estimated Weight:";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.BackColor = System.Drawing.Color.CadetBlue;
            this.lblIncorrect.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.Location = new System.Drawing.Point(369, 372);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(113, 40);
            this.lblIncorrect.TabIndex = 11;
            this.lblIncorrect.Text = "Incorrect";
            this.lblIncorrect.UseVisualStyleBackColor = false;
            this.lblIncorrect.Click += new System.EventHandler(this.lblIncorrect_Click);
            // 
            // Rfullname
            // 
            this.Rfullname.AutoSize = true;
            this.Rfullname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rfullname.Location = new System.Drawing.Point(306, 54);
            this.Rfullname.Name = "Rfullname";
            this.Rfullname.Size = new System.Drawing.Size(32, 18);
            this.Rfullname.TabIndex = 12;
            this.Rfullname.Text = "......";
            // 
            // rDepartureCity
            // 
            this.rDepartureCity.AutoSize = true;
            this.rDepartureCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDepartureCity.Location = new System.Drawing.Point(306, 85);
            this.rDepartureCity.Name = "rDepartureCity";
            this.rDepartureCity.Size = new System.Drawing.Size(32, 18);
            this.rDepartureCity.TabIndex = 13;
            this.rDepartureCity.Text = "......";
            // 
            // rDestination
            // 
            this.rDestination.AutoSize = true;
            this.rDestination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDestination.Location = new System.Drawing.Point(306, 117);
            this.rDestination.Name = "rDestination";
            this.rDestination.Size = new System.Drawing.Size(32, 18);
            this.rDestination.TabIndex = 14;
            this.rDestination.Text = "......";
            // 
            // rTripStartDate
            // 
            this.rTripStartDate.AutoSize = true;
            this.rTripStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTripStartDate.Location = new System.Drawing.Point(306, 152);
            this.rTripStartDate.Name = "rTripStartDate";
            this.rTripStartDate.Size = new System.Drawing.Size(32, 18);
            this.rTripStartDate.TabIndex = 15;
            this.rTripStartDate.Text = "......";
            // 
            // rTripEndDate
            // 
            this.rTripEndDate.AutoSize = true;
            this.rTripEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTripEndDate.Location = new System.Drawing.Point(306, 186);
            this.rTripEndDate.Name = "rTripEndDate";
            this.rTripEndDate.Size = new System.Drawing.Size(32, 18);
            this.rTripEndDate.TabIndex = 16;
            this.rTripEndDate.Text = "......";
            // 
            // rDocumentNumber
            // 
            this.rDocumentNumber.AutoSize = true;
            this.rDocumentNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDocumentNumber.Location = new System.Drawing.Point(306, 224);
            this.rDocumentNumber.Name = "rDocumentNumber";
            this.rDocumentNumber.Size = new System.Drawing.Size(32, 18);
            this.rDocumentNumber.TabIndex = 17;
            this.rDocumentNumber.Text = "......";
            // 
            // rDocumentIssueDate
            // 
            this.rDocumentIssueDate.AutoSize = true;
            this.rDocumentIssueDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDocumentIssueDate.Location = new System.Drawing.Point(306, 258);
            this.rDocumentIssueDate.Name = "rDocumentIssueDate";
            this.rDocumentIssueDate.Size = new System.Drawing.Size(32, 18);
            this.rDocumentIssueDate.TabIndex = 18;
            this.rDocumentIssueDate.Text = "......";
            // 
            // rDocumentExpiryDate
            // 
            this.rDocumentExpiryDate.AutoSize = true;
            this.rDocumentExpiryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDocumentExpiryDate.Location = new System.Drawing.Point(306, 300);
            this.rDocumentExpiryDate.Name = "rDocumentExpiryDate";
            this.rDocumentExpiryDate.Size = new System.Drawing.Size(32, 18);
            this.rDocumentExpiryDate.TabIndex = 19;
            this.rDocumentExpiryDate.Text = "......";
            // 
            // rBaggage
            // 
            this.rBaggage.AutoSize = true;
            this.rBaggage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBaggage.Location = new System.Drawing.Point(306, 336);
            this.rBaggage.Name = "rBaggage";
            this.rBaggage.Size = new System.Drawing.Size(32, 18);
            this.rBaggage.TabIndex = 20;
            this.rBaggage.Text = "......";
            // 
            // Flight_Booking_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 424);
            this.Controls.Add(this.rBaggage);
            this.Controls.Add(this.rDocumentExpiryDate);
            this.Controls.Add(this.rDocumentIssueDate);
            this.Controls.Add(this.rDocumentNumber);
            this.Controls.Add(this.rTripEndDate);
            this.Controls.Add(this.rTripStartDate);
            this.Controls.Add(this.rDestination);
            this.Controls.Add(this.rDepartureCity);
            this.Controls.Add(this.Rfullname);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblBaggage);
            this.Controls.Add(this.lblDocExpiryDate);
            this.Controls.Add(this.lblDocIssueDate);
            this.Controls.Add(this.lblDocNumber);
            this.Controls.Add(this.lblTripEndDate);
            this.Controls.Add(this.lblTripStartDate);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblconfirm);
            this.Name = "Flight_Booking_Summary";
            this.Text = "Flight_Booking_Summary";
            this.Load += new System.EventHandler(this.Flight_Booking_Summary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Button lblCorrect;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTripStartDate;
        private System.Windows.Forms.Label lblTripEndDate;
        private System.Windows.Forms.Label lblDocNumber;
        private System.Windows.Forms.Label lblDocIssueDate;
        private System.Windows.Forms.Label lblDocExpiryDate;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.Button lblIncorrect;
        private System.Windows.Forms.Label Rfullname;
        private System.Windows.Forms.Label rDepartureCity;
        private System.Windows.Forms.Label rDestination;
        private System.Windows.Forms.Label rTripStartDate;
        private System.Windows.Forms.Label rTripEndDate;
        private System.Windows.Forms.Label rDocumentNumber;
        private System.Windows.Forms.Label rDocumentIssueDate;
        private System.Windows.Forms.Label rDocumentExpiryDate;
        private System.Windows.Forms.Label rBaggage;
    }
}