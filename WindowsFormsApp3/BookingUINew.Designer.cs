namespace WindowsFormsApp3
{
    partial class BookingUINew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBookingPeriod = new System.Windows.Forms.GroupBox();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWorkingHrs = new System.Windows.Forms.Label();
            this.groupBoxbackhoeDetails = new System.Windows.Forms.GroupBox();
            this.txtRatings3 = new System.Windows.Forms.TextBox();
            this.txtRatings2 = new System.Windows.Forms.TextBox();
            this.txtRatings1 = new System.Windows.Forms.TextBox();
            this.lblRatings = new System.Windows.Forms.Label();
            this.dropDownNoOfBackhoes3 = new System.Windows.Forms.ComboBox();
            this.dropDownNoOfBackhoes2 = new System.Windows.Forms.ComboBox();
            this.dropDownNoOfBackhoes1 = new System.Windows.Forms.ComboBox();
            this.dropDownBackhoeTypes3 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropDownBackhoeTypes2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropDownBackhoeTypes1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblBackhoeType = new System.Windows.Forms.Label();
            this.lblNoOfBackhoes = new System.Windows.Forms.Label();
            this.groupBoxCallerDetails = new System.Windows.Forms.GroupBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.dateCaller = new System.Windows.Forms.DateTimePicker();
            this.txtCallerTpNo = new System.Windows.Forms.TextBox();
            this.txtCallerName = new System.Windows.Forms.TextBox();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.lblCalledDateTime = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.grpBookingPeriod.SuspendLayout();
            this.groupBoxbackhoeDetails.SuspendLayout();
            this.groupBoxCallerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(220, 42);
            this.txtCustomerID.MaxLength = 223;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(223, 20);
            this.txtCustomerID.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(23)))), ((int)(((byte)(247)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(788, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 50);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(254)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(573, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 50);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // grpBookingPeriod
            // 
            this.grpBookingPeriod.Controls.Add(this.txtWorkingHours);
            this.grpBookingPeriod.Controls.Add(this.dateEndDate);
            this.grpBookingPeriod.Controls.Add(this.dateStartDate);
            this.grpBookingPeriod.Controls.Add(this.lblBookingDate);
            this.grpBookingPeriod.Controls.Add(this.label4);
            this.grpBookingPeriod.Controls.Add(this.lblWorkingHrs);
            this.grpBookingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingPeriod.Location = new System.Drawing.Point(41, 78);
            this.grpBookingPeriod.Name = "grpBookingPeriod";
            this.grpBookingPeriod.Size = new System.Drawing.Size(448, 234);
            this.grpBookingPeriod.TabIndex = 21;
            this.grpBookingPeriod.TabStop = false;
            this.grpBookingPeriod.Text = "Booking Period";
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Location = new System.Drawing.Point(177, 129);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(65, 22);
            this.txtWorkingHours.TabIndex = 16;
            // 
            // dateEndDate
            // 
            this.dateEndDate.Location = new System.Drawing.Point(177, 81);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(263, 22);
            this.dateEndDate.TabIndex = 15;
            this.dateEndDate.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(176, 30);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(264, 22);
            this.dateStartDate.TabIndex = 14;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(19, 35);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(120, 16);
            this.lblBookingDate.TabIndex = 8;
            this.lblBookingDate.Text = "Booking Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Booking End Date";
            // 
            // lblWorkingHrs
            // 
            this.lblWorkingHrs.AutoSize = true;
            this.lblWorkingHrs.Location = new System.Drawing.Point(17, 135);
            this.lblWorkingHrs.Name = "lblWorkingHrs";
            this.lblWorkingHrs.Size = new System.Drawing.Size(149, 16);
            this.lblWorkingHrs.TabIndex = 9;
            this.lblWorkingHrs.Text = "Working Hours Per Day";
            // 
            // groupBoxbackhoeDetails
            // 
            this.groupBoxbackhoeDetails.Controls.Add(this.txtRatings3);
            this.groupBoxbackhoeDetails.Controls.Add(this.txtRatings2);
            this.groupBoxbackhoeDetails.Controls.Add(this.txtRatings1);
            this.groupBoxbackhoeDetails.Controls.Add(this.lblRatings);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownNoOfBackhoes3);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownNoOfBackhoes2);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownNoOfBackhoes1);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownBackhoeTypes3);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownBackhoeTypes2);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownBackhoeTypes1);
            this.groupBoxbackhoeDetails.Controls.Add(this.lblBackhoeType);
            this.groupBoxbackhoeDetails.Controls.Add(this.lblNoOfBackhoes);
            this.groupBoxbackhoeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxbackhoeDetails.Location = new System.Drawing.Point(516, 78);
            this.groupBoxbackhoeDetails.Name = "groupBoxbackhoeDetails";
            this.groupBoxbackhoeDetails.Size = new System.Drawing.Size(515, 234);
            this.groupBoxbackhoeDetails.TabIndex = 20;
            this.groupBoxbackhoeDetails.TabStop = false;
            this.groupBoxbackhoeDetails.Text = "Backhoe Details";
            // 
            // txtRatings3
            // 
            this.txtRatings3.Location = new System.Drawing.Point(287, 174);
            this.txtRatings3.Name = "txtRatings3";
            this.txtRatings3.Size = new System.Drawing.Size(87, 22);
            this.txtRatings3.TabIndex = 24;
            // 
            // txtRatings2
            // 
            this.txtRatings2.Location = new System.Drawing.Point(287, 129);
            this.txtRatings2.Name = "txtRatings2";
            this.txtRatings2.Size = new System.Drawing.Size(87, 22);
            this.txtRatings2.TabIndex = 23;
            this.txtRatings2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRatings1
            // 
            this.txtRatings1.Location = new System.Drawing.Point(287, 87);
            this.txtRatings1.Name = "txtRatings1";
            this.txtRatings1.Size = new System.Drawing.Size(87, 22);
            this.txtRatings1.TabIndex = 22;
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Location = new System.Drawing.Point(269, 36);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(118, 16);
            this.lblRatings.TabIndex = 21;
            this.lblRatings.Text = "Ratings (Per Hour)";
            // 
            // dropDownNoOfBackhoes3
            // 
            this.dropDownNoOfBackhoes3.BackColor = System.Drawing.Color.White;
            this.dropDownNoOfBackhoes3.ForeColor = System.Drawing.Color.Black;
            this.dropDownNoOfBackhoes3.FormattingEnabled = true;
            this.dropDownNoOfBackhoes3.Location = new System.Drawing.Point(435, 173);
            this.dropDownNoOfBackhoes3.Name = "dropDownNoOfBackhoes3";
            this.dropDownNoOfBackhoes3.Size = new System.Drawing.Size(35, 24);
            this.dropDownNoOfBackhoes3.TabIndex = 20;
            // 
            // dropDownNoOfBackhoes2
            // 
            this.dropDownNoOfBackhoes2.BackColor = System.Drawing.Color.White;
            this.dropDownNoOfBackhoes2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropDownNoOfBackhoes2.FormattingEnabled = true;
            this.dropDownNoOfBackhoes2.Location = new System.Drawing.Point(435, 127);
            this.dropDownNoOfBackhoes2.Name = "dropDownNoOfBackhoes2";
            this.dropDownNoOfBackhoes2.Size = new System.Drawing.Size(35, 24);
            this.dropDownNoOfBackhoes2.TabIndex = 19;
            // 
            // dropDownNoOfBackhoes1
            // 
            this.dropDownNoOfBackhoes1.BackColor = System.Drawing.Color.White;
            this.dropDownNoOfBackhoes1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropDownNoOfBackhoes1.FormattingEnabled = true;
            this.dropDownNoOfBackhoes1.Location = new System.Drawing.Point(435, 83);
            this.dropDownNoOfBackhoes1.Name = "dropDownNoOfBackhoes1";
            this.dropDownNoOfBackhoes1.Size = new System.Drawing.Size(35, 24);
            this.dropDownNoOfBackhoes1.TabIndex = 18;
            // 
            // dropDownBackhoeTypes3
            // 
            this.dropDownBackhoeTypes3.BackColor = System.Drawing.Color.Transparent;
            this.dropDownBackhoeTypes3.ForeColor = System.Drawing.Color.White;
            this.dropDownBackhoeTypes3.Items = new string[0];
            this.dropDownBackhoeTypes3.Location = new System.Drawing.Point(9, 174);
            this.dropDownBackhoeTypes3.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.dropDownBackhoeTypes3.Name = "dropDownBackhoeTypes3";
            this.dropDownBackhoeTypes3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes3.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes3.selectedIndex = -1;
            this.dropDownBackhoeTypes3.Size = new System.Drawing.Size(216, 22);
            this.dropDownBackhoeTypes3.TabIndex = 14;
            // 
            // dropDownBackhoeTypes2
            // 
            this.dropDownBackhoeTypes2.BackColor = System.Drawing.Color.Transparent;
            this.dropDownBackhoeTypes2.ForeColor = System.Drawing.Color.White;
            this.dropDownBackhoeTypes2.Items = new string[0];
            this.dropDownBackhoeTypes2.Location = new System.Drawing.Point(9, 129);
            this.dropDownBackhoeTypes2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dropDownBackhoeTypes2.Name = "dropDownBackhoeTypes2";
            this.dropDownBackhoeTypes2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes2.selectedIndex = -1;
            this.dropDownBackhoeTypes2.Size = new System.Drawing.Size(216, 22);
            this.dropDownBackhoeTypes2.TabIndex = 13;
            // 
            // dropDownBackhoeTypes1
            // 
            this.dropDownBackhoeTypes1.BackColor = System.Drawing.Color.Transparent;
            this.dropDownBackhoeTypes1.ForeColor = System.Drawing.Color.White;
            this.dropDownBackhoeTypes1.Items = new string[0];
            this.dropDownBackhoeTypes1.Location = new System.Drawing.Point(9, 87);
            this.dropDownBackhoeTypes1.Margin = new System.Windows.Forms.Padding(5);
            this.dropDownBackhoeTypes1.Name = "dropDownBackhoeTypes1";
            this.dropDownBackhoeTypes1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes1.selectedIndex = -1;
            this.dropDownBackhoeTypes1.Size = new System.Drawing.Size(216, 22);
            this.dropDownBackhoeTypes1.TabIndex = 12;
            this.dropDownBackhoeTypes1.onItemSelected += new System.EventHandler(this.dropDownBackhoeTypes1_onItemSelected);
            // 
            // lblBackhoeType
            // 
            this.lblBackhoeType.AutoSize = true;
            this.lblBackhoeType.Location = new System.Drawing.Point(6, 36);
            this.lblBackhoeType.Name = "lblBackhoeType";
            this.lblBackhoeType.Size = new System.Drawing.Size(97, 16);
            this.lblBackhoeType.TabIndex = 7;
            this.lblBackhoeType.Text = "Backhoe Type";
            // 
            // lblNoOfBackhoes
            // 
            this.lblNoOfBackhoes.AutoSize = true;
            this.lblNoOfBackhoes.Location = new System.Drawing.Point(403, 36);
            this.lblNoOfBackhoes.Name = "lblNoOfBackhoes";
            this.lblNoOfBackhoes.Size = new System.Drawing.Size(106, 16);
            this.lblNoOfBackhoes.TabIndex = 11;
            this.lblNoOfBackhoes.Text = "No Of Backhoes";
            // 
            // groupBoxCallerDetails
            // 
            this.groupBoxCallerDetails.Controls.Add(this.txtNIC);
            this.groupBoxCallerDetails.Controls.Add(this.lblNIC);
            this.groupBoxCallerDetails.Controls.Add(this.dateCaller);
            this.groupBoxCallerDetails.Controls.Add(this.txtCallerTpNo);
            this.groupBoxCallerDetails.Controls.Add(this.txtCallerName);
            this.groupBoxCallerDetails.Controls.Add(this.lblCallerName);
            this.groupBoxCallerDetails.Controls.Add(this.lblCalledDateTime);
            this.groupBoxCallerDetails.Controls.Add(this.lblMobileNo);
            this.groupBoxCallerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCallerDetails.Location = new System.Drawing.Point(41, 356);
            this.groupBoxCallerDetails.Name = "groupBoxCallerDetails";
            this.groupBoxCallerDetails.Size = new System.Drawing.Size(990, 112);
            this.groupBoxCallerDetails.TabIndex = 19;
            this.groupBoxCallerDetails.TabStop = false;
            this.groupBoxCallerDetails.Text = "Caller Details";
            this.groupBoxCallerDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(178, 66);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(224, 22);
            this.txtNIC.TabIndex = 19;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(19, 72);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(39, 16);
            this.lblNIC.TabIndex = 18;
            this.lblNIC.Text = "NIC : ";
            // 
            // dateCaller
            // 
            this.dateCaller.Location = new System.Drawing.Point(612, 31);
            this.dateCaller.Name = "dateCaller";
            this.dateCaller.Size = new System.Drawing.Size(263, 22);
            this.dateCaller.TabIndex = 17;
            this.dateCaller.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // txtCallerTpNo
            // 
            this.txtCallerTpNo.Location = new System.Drawing.Point(612, 66);
            this.txtCallerTpNo.Name = "txtCallerTpNo";
            this.txtCallerTpNo.Size = new System.Drawing.Size(263, 22);
            this.txtCallerTpNo.TabIndex = 7;
            // 
            // txtCallerName
            // 
            this.txtCallerName.Location = new System.Drawing.Point(178, 31);
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(224, 22);
            this.txtCallerName.TabIndex = 6;
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Location = new System.Drawing.Point(19, 37);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(54, 16);
            this.lblCallerName.TabIndex = 1;
            this.lblCallerName.Text = "Name : ";
            this.lblCallerName.Click += new System.EventHandler(this.lblCallerName_Click);
            // 
            // lblCalledDateTime
            // 
            this.lblCalledDateTime.AutoSize = true;
            this.lblCalledDateTime.Location = new System.Drawing.Point(472, 37);
            this.lblCalledDateTime.Name = "lblCalledDateTime";
            this.lblCalledDateTime.Size = new System.Drawing.Size(98, 16);
            this.lblCalledDateTime.TabIndex = 5;
            this.lblCalledDateTime.Text = "Date And Time";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Location = new System.Drawing.Point(472, 72);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(106, 16);
            this.lblMobileNo.TabIndex = 2;
            this.lblMobileNo.Text = "Mobile Number :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(38, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(168, 16);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "Customer NIC / Contract ID ";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.Location = new System.Drawing.Point(57, 508);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(112, 20);
            this.lblTotalCharge.TabIndex = 25;
            this.lblTotalCharge.Text = "Total Charge";
            this.lblTotalCharge.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.Location = new System.Drawing.Point(219, 510);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.Size = new System.Drawing.Size(140, 20);
            this.txtTotalCharges.TabIndex = 26;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(616, 42);
            this.txtBookingID.MaxLength = 223;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(223, 20);
            this.txtBookingID.TabIndex = 28;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(513, 43);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(85, 16);
            this.lblBookingID.TabIndex = 27;
            this.lblBookingID.Text = "Boooking ID ";
            // 
            // BookingUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBookingPeriod);
            this.Controls.Add(this.groupBoxbackhoeDetails);
            this.Controls.Add(this.groupBoxCallerDetails);
            this.Controls.Add(this.lblID);
            this.Name = "BookingUINew";
            this.Size = new System.Drawing.Size(1069, 582);
            this.Load += new System.EventHandler(this.BookingUINew_Load);
            this.grpBookingPeriod.ResumeLayout(false);
            this.grpBookingPeriod.PerformLayout();
            this.groupBoxbackhoeDetails.ResumeLayout(false);
            this.groupBoxbackhoeDetails.PerformLayout();
            this.groupBoxCallerDetails.ResumeLayout(false);
            this.groupBoxCallerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBookingPeriod;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWorkingHrs;
        private System.Windows.Forms.GroupBox groupBoxbackhoeDetails;
        private System.Windows.Forms.ComboBox dropDownNoOfBackhoes3;
        private System.Windows.Forms.ComboBox dropDownNoOfBackhoes2;
        private System.Windows.Forms.ComboBox dropDownNoOfBackhoes1;
        private Bunifu.Framework.UI.BunifuDropdown dropDownBackhoeTypes3;
        private Bunifu.Framework.UI.BunifuDropdown dropDownBackhoeTypes2;
        private Bunifu.Framework.UI.BunifuDropdown dropDownBackhoeTypes1;
        private System.Windows.Forms.Label lblBackhoeType;
        private System.Windows.Forms.Label lblNoOfBackhoes;
        private System.Windows.Forms.GroupBox groupBoxCallerDetails;
        private System.Windows.Forms.DateTimePicker dateCaller;
        private System.Windows.Forms.TextBox txtCallerTpNo;
        private System.Windows.Forms.TextBox txtCallerName;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.Label lblCalledDateTime;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.TextBox txtRatings3;
        private System.Windows.Forms.TextBox txtRatings2;
        private System.Windows.Forms.TextBox txtRatings1;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.TextBox txtTotalCharges;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
    }
}
