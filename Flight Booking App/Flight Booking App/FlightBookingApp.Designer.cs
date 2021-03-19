
namespace Flight_Booking_App
{
    partial class FlightBookingApp
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblschedule = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.cv = new System.Windows.Forms.Label();
            this.lblTravelDoc = new System.Windows.Forms.Label();
            this.radioButtonPassport = new System.Windows.Forms.RadioButton();
            this.radioButtonIdCard = new System.Windows.Forms.RadioButton();
            this.txtDocNumber = new System.Windows.Forms.TextBox();
            this.lblDocNumber = new System.Windows.Forms.Label();
            this.lblDocIssueDate = new System.Windows.Forms.Label();
            this.lblDocExpiryDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(53, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(49, 19);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(119, 15);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(163, 20);
            this.txtfrom.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNone);
            this.groupBox1.Controls.Add(this.radioButtonIdCard);
            this.groupBox1.Controls.Add(this.radioButtonPassport);
            this.groupBox1.Location = new System.Drawing.Point(203, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(524, 15);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(163, 20);
            this.txtTo.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(490, 16);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // lblschedule
            // 
            this.lblschedule.AutoSize = true;
            this.lblschedule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschedule.Location = new System.Drawing.Point(44, 51);
            this.lblschedule.Name = "lblschedule";
            this.lblschedule.Size = new System.Drawing.Size(461, 16);
            this.lblschedule.TabIndex = 5;
            this.lblschedule.Text = "Choose your schedule (Click and Drag to choose a range, or use the shift key)";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(131, 76);
            this.monthCalendar1.MaxSelectionCount = 61;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 2, 1, 0, 0, 0, 0), new System.DateTime(2021, 3, 31, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Transparent;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(562, 251);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(191, 20);
            this.txtLName.TabIndex = 10;
            this.txtLName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(466, 251);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(90, 19);
            this.lblLName.TabIndex = 9;
            this.lblLName.Text = "Last Name";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLName.Click += new System.EventHandler(this.lblLName_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(159, 250);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(194, 20);
            this.txtFName.TabIndex = 8;
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv.Location = new System.Drawing.Point(53, 249);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(91, 19);
            this.cv.TabIndex = 7;
            this.cv.Text = "First Name";
            // 
            // lblTravelDoc
            // 
            this.lblTravelDoc.AutoSize = true;
            this.lblTravelDoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelDoc.Location = new System.Drawing.Point(53, 285);
            this.lblTravelDoc.Name = "lblTravelDoc";
            this.lblTravelDoc.Size = new System.Drawing.Size(144, 19);
            this.lblTravelDoc.TabIndex = 11;
            this.lblTravelDoc.Text = "Travel Document:";
            this.lblTravelDoc.Click += new System.EventHandler(this.lblTravelDoc_Click);
            // 
            // radioButtonPassport
            // 
            this.radioButtonPassport.AutoSize = true;
            this.radioButtonPassport.Location = new System.Drawing.Point(6, 15);
            this.radioButtonPassport.Name = "radioButtonPassport";
            this.radioButtonPassport.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPassport.TabIndex = 0;
            this.radioButtonPassport.TabStop = true;
            this.radioButtonPassport.Text = "Passport";
            this.radioButtonPassport.UseVisualStyleBackColor = true;
            this.radioButtonPassport.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonIdCard
            // 
            this.radioButtonIdCard.AutoSize = true;
            this.radioButtonIdCard.Location = new System.Drawing.Point(78, 15);
            this.radioButtonIdCard.Name = "radioButtonIdCard";
            this.radioButtonIdCard.Size = new System.Drawing.Size(61, 17);
            this.radioButtonIdCard.TabIndex = 1;
            this.radioButtonIdCard.TabStop = true;
            this.radioButtonIdCard.Text = "ID Card";
            this.radioButtonIdCard.UseVisualStyleBackColor = true;
            this.radioButtonIdCard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Location = new System.Drawing.Point(595, 283);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(191, 20);
            this.txtDocNumber.TabIndex = 13;
            // 
            // lblDocNumber
            // 
            this.lblDocNumber.AutoSize = true;
            this.lblDocNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocNumber.Location = new System.Drawing.Point(442, 285);
            this.lblDocNumber.Name = "lblDocNumber";
            this.lblDocNumber.Size = new System.Drawing.Size(153, 19);
            this.lblDocNumber.TabIndex = 12;
            this.lblDocNumber.Text = "Document Number";
            this.lblDocNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDocIssueDate
            // 
            this.lblDocIssueDate.AutoSize = true;
            this.lblDocIssueDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocIssueDate.Location = new System.Drawing.Point(31, 334);
            this.lblDocIssueDate.Name = "lblDocIssueDate";
            this.lblDocIssueDate.Size = new System.Drawing.Size(172, 19);
            this.lblDocIssueDate.TabIndex = 14;
            this.lblDocIssueDate.Text = "Document Issue Date";
            // 
            // lblDocExpiryDate
            // 
            this.lblDocExpiryDate.AutoSize = true;
            this.lblDocExpiryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocExpiryDate.Location = new System.Drawing.Point(415, 336);
            this.lblDocExpiryDate.Name = "lblDocExpiryDate";
            this.lblDocExpiryDate.Size = new System.Drawing.Size(180, 19);
            this.lblDocExpiryDate.TabIndex = 15;
            this.lblDocExpiryDate.Text = "Document Expiry Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(601, 335);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaggage.Location = new System.Drawing.Point(53, 375);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(244, 19);
            this.lblBaggage.TabIndex = 18;
            this.lblBaggage.Text = "Baggage (Provide an Estimate)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 374);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBookFlight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.ForeColor = System.Drawing.Color.Black;
            this.btnBookFlight.Location = new System.Drawing.Point(6, 409);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(795, 42);
            this.btnBookFlight.TabIndex = 20;
            this.btnBookFlight.Text = "Book your flight (without paying)";
            this.btnBookFlight.UseVisualStyleBackColor = false;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(145, 15);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 2;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // FlightBookingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblBaggage);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDocExpiryDate);
            this.Controls.Add(this.lblDocIssueDate);
            this.Controls.Add(this.txtDocNumber);
            this.Controls.Add(this.lblDocNumber);
            this.Controls.Add(this.lblTravelDoc);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblschedule);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.lblFrom);
            this.Name = "FlightBookingApp";
            this.Text = "Book your Flight";
            this.Load += new System.EventHandler(this.FlightBookingApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblschedule;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.Label lblTravelDoc;
        private System.Windows.Forms.RadioButton radioButtonPassport;
        private System.Windows.Forms.RadioButton radioButtonIdCard;
        private System.Windows.Forms.TextBox txtDocNumber;
        private System.Windows.Forms.Label lblDocNumber;
        private System.Windows.Forms.Label lblDocIssueDate;
        private System.Windows.Forms.Label lblDocExpiryDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.RadioButton radioButtonNone;
    }
}

