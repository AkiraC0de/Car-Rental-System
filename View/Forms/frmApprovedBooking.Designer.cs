namespace VehicleManagementSystem.View.Forms
{
    partial class frmApprovedBooking
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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bookingDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.currentOdometerTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentFuelLevelTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.releaseUnitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rentalDateEndDTP = new System.Windows.Forms.DateTimePicker();
            this.rentalDateStartDTP = new System.Windows.Forms.DateTimePicker();
            this.lblRentalTimeValue = new System.Windows.Forms.Label();
            this.lblRentalTime = new System.Windows.Forms.Label();
            this.lblRentalPeriod = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.lblDateofRequestValue = new System.Windows.Forms.Label();
            this.lblDateOfRequest = new System.Windows.Forms.Label();
            this.customerContactNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerContactNum = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.customerLicenseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerLicense = new System.Windows.Forms.Label();
            this.vehicleLicenseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.vehicleNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.bookingsConflictsMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoBookingConflicts = new System.Windows.Forms.Label();
            this.lblBookingConflicts = new System.Windows.Forms.Label();
            this.conflictFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblBookingIDValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bookingDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            this.bookingsConflictsMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Controls.Add(this.backBtn);
            this.panelMain.Controls.Add(this.lblBookingIDValue);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1698, 890);
            this.panelMain.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel1.Controls.Add(this.bookingDetailsPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bookingsConflictsMainPanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1668, 791);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // bookingDetailsPanel
            // 
            this.bookingDetailsPanel.Controls.Add(this.currentOdometerTextBox);
            this.bookingDetailsPanel.Controls.Add(this.label1);
            this.bookingDetailsPanel.Controls.Add(this.currentFuelLevelTextBox);
            this.bookingDetailsPanel.Controls.Add(this.label4);
            this.bookingDetailsPanel.Controls.Add(this.releaseUnitBtn);
            this.bookingDetailsPanel.Controls.Add(this.cancelBookingBtn);
            this.bookingDetailsPanel.Controls.Add(this.lblPriceValue);
            this.bookingDetailsPanel.Controls.Add(this.lblPrice);
            this.bookingDetailsPanel.Controls.Add(this.rentalDateEndDTP);
            this.bookingDetailsPanel.Controls.Add(this.rentalDateStartDTP);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalTimeValue);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalTime);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalPeriod);
            this.bookingDetailsPanel.Controls.Add(this.lblto);
            this.bookingDetailsPanel.Controls.Add(this.lblDateofRequestValue);
            this.bookingDetailsPanel.Controls.Add(this.lblDateOfRequest);
            this.bookingDetailsPanel.Controls.Add(this.customerContactNumTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerContactNum);
            this.bookingDetailsPanel.Controls.Add(this.customerEmailTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerEmail);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerInfo);
            this.bookingDetailsPanel.Controls.Add(this.lastNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblLastName);
            this.bookingDetailsPanel.Controls.Add(this.customerLicenseTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerLicense);
            this.bookingDetailsPanel.Controls.Add(this.vehicleLicenseTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblLicenseNum);
            this.bookingDetailsPanel.Controls.Add(this.vehiclePictureBox);
            this.bookingDetailsPanel.Controls.Add(this.vehicleNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblVehicleName);
            this.bookingDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblFirstName);
            this.bookingDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDetailsPanel.Location = new System.Drawing.Point(4, 5);
            this.bookingDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingDetailsPanel.Name = "bookingDetailsPanel";
            this.bookingDetailsPanel.Size = new System.Drawing.Size(1254, 781);
            this.bookingDetailsPanel.TabIndex = 42;
            // 
            // currentOdometerTextBox
            // 
            this.currentOdometerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentOdometerTextBox.BorderRadius = 10;
            this.currentOdometerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentOdometerTextBox.DefaultText = "";
            this.currentOdometerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentOdometerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentOdometerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentOdometerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentOdometerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentOdometerTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOdometerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentOdometerTextBox.Location = new System.Drawing.Point(969, 551);
            this.currentOdometerTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.currentOdometerTextBox.Multiline = true;
            this.currentOdometerTextBox.Name = "currentOdometerTextBox";
            this.currentOdometerTextBox.PlaceholderText = "";
            this.currentOdometerTextBox.SelectedText = "";
            this.currentOdometerTextBox.Size = new System.Drawing.Size(241, 45);
            this.currentOdometerTextBox.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(965, 512);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Current Odometer";
            // 
            // currentFuelLevelTextBox
            // 
            this.currentFuelLevelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFuelLevelTextBox.BorderRadius = 10;
            this.currentFuelLevelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentFuelLevelTextBox.DefaultText = "";
            this.currentFuelLevelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentFuelLevelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentFuelLevelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentFuelLevelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentFuelLevelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentFuelLevelTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFuelLevelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentFuelLevelTextBox.Location = new System.Drawing.Point(664, 551);
            this.currentFuelLevelTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.currentFuelLevelTextBox.Multiline = true;
            this.currentFuelLevelTextBox.Name = "currentFuelLevelTextBox";
            this.currentFuelLevelTextBox.PlaceholderText = "";
            this.currentFuelLevelTextBox.SelectedText = "";
            this.currentFuelLevelTextBox.Size = new System.Drawing.Size(246, 45);
            this.currentFuelLevelTextBox.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 512);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Current Fuel Level";
            // 
            // releaseUnitBtn
            // 
            this.releaseUnitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseUnitBtn.BorderRadius = 10;
            this.releaseUnitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.releaseUnitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.releaseUnitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.releaseUnitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.releaseUnitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.releaseUnitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.releaseUnitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseUnitBtn.ForeColor = System.Drawing.Color.White;
            this.releaseUnitBtn.Image = global::VehicleManagementSystem.Properties.Resources.file;
            this.releaseUnitBtn.ImageOffset = new System.Drawing.Point(-10, 0);
            this.releaseUnitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.releaseUnitBtn.Location = new System.Drawing.Point(969, 643);
            this.releaseUnitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.releaseUnitBtn.Name = "releaseUnitBtn";
            this.releaseUnitBtn.Size = new System.Drawing.Size(243, 60);
            this.releaseUnitBtn.TabIndex = 61;
            this.releaseUnitBtn.Text = "Release Unit";
            this.releaseUnitBtn.Click += new System.EventHandler(this.releaseBtn_Click);
            // 
            // cancelBookingBtn
            // 
            this.cancelBookingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBookingBtn.BorderColor = System.Drawing.Color.Silver;
            this.cancelBookingBtn.BorderRadius = 10;
            this.cancelBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBookingBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.cancelBookingBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBookingBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBookingBtn.Image = global::VehicleManagementSystem.Properties.Resources.file__1_;
            this.cancelBookingBtn.ImageOffset = new System.Drawing.Point(-3, 0);
            this.cancelBookingBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancelBookingBtn.Location = new System.Drawing.Point(664, 643);
            this.cancelBookingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBookingBtn.Name = "cancelBookingBtn";
            this.cancelBookingBtn.Size = new System.Drawing.Size(246, 60);
            this.cancelBookingBtn.TabIndex = 60;
            this.cancelBookingBtn.Text = "Cancel Booking";
            this.cancelBookingBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPriceValue.Location = new System.Drawing.Point(125, 706);
            this.lblPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(86, 25);
            this.lblPriceValue.TabIndex = 57;
            this.lblPriceValue.Text = "P20002";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(37, 708);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 24);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "Price:";
            // 
            // rentalDateEndDTP
            // 
            this.rentalDateEndDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateEndDTP.CustomFormat = "MMMMdd, yyyy hh:mm tt";
            this.rentalDateEndDTP.Enabled = false;
            this.rentalDateEndDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateEndDTP.Location = new System.Drawing.Point(34, 597);
            this.rentalDateEndDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalDateEndDTP.Name = "rentalDateEndDTP";
            this.rentalDateEndDTP.Size = new System.Drawing.Size(328, 30);
            this.rentalDateEndDTP.TabIndex = 55;
            // 
            // rentalDateStartDTP
            // 
            this.rentalDateStartDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateStartDTP.CustomFormat = "MMMMdd, yyyy hh:mm tt";
            this.rentalDateStartDTP.Enabled = false;
            this.rentalDateStartDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateStartDTP.Location = new System.Drawing.Point(34, 532);
            this.rentalDateStartDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalDateStartDTP.Name = "rentalDateStartDTP";
            this.rentalDateStartDTP.Size = new System.Drawing.Size(328, 30);
            this.rentalDateStartDTP.TabIndex = 54;
            // 
            // lblRentalTimeValue
            // 
            this.lblRentalTimeValue.AutoSize = true;
            this.lblRentalTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTimeValue.Location = new System.Drawing.Point(153, 659);
            this.lblRentalTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalTimeValue.Name = "lblRentalTimeValue";
            this.lblRentalTimeValue.Size = new System.Drawing.Size(130, 25);
            this.lblRentalTimeValue.TabIndex = 53;
            this.lblRentalTimeValue.Text = "0 day 2 hours";
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.AutoSize = true;
            this.lblRentalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTime.Location = new System.Drawing.Point(37, 659);
            this.lblRentalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.Size = new System.Drawing.Size(98, 24);
            this.lblRentalTime.TabIndex = 52;
            this.lblRentalTime.Text = "Duration:";
            // 
            // lblRentalPeriod
            // 
            this.lblRentalPeriod.AutoSize = true;
            this.lblRentalPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPeriod.Location = new System.Drawing.Point(37, 503);
            this.lblRentalPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Size = new System.Drawing.Size(137, 24);
            this.lblRentalPeriod.TabIndex = 51;
            this.lblRentalPeriod.Text = "Rental Period";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.Transparent;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(163, 567);
            this.lblto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(28, 25);
            this.lblto.TabIndex = 50;
            this.lblto.Text = "to";
            // 
            // lblDateofRequestValue
            // 
            this.lblDateofRequestValue.AutoSize = true;
            this.lblDateofRequestValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDateofRequestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofRequestValue.Location = new System.Drawing.Point(38, 449);
            this.lblDateofRequestValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateofRequestValue.Name = "lblDateofRequestValue";
            this.lblDateofRequestValue.Size = new System.Drawing.Size(244, 25);
            this.lblDateofRequestValue.TabIndex = 49;
            this.lblDateofRequestValue.Text = "March  27, 2026 02:02 AM";
            // 
            // lblDateOfRequest
            // 
            this.lblDateOfRequest.AutoSize = true;
            this.lblDateOfRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfRequest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfRequest.Location = new System.Drawing.Point(37, 416);
            this.lblDateOfRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfRequest.Name = "lblDateOfRequest";
            this.lblDateOfRequest.Size = new System.Drawing.Size(175, 24);
            this.lblDateOfRequest.TabIndex = 48;
            this.lblDateOfRequest.Text = "Date of Request: ";
            // 
            // customerContactNumTextBox
            // 
            this.customerContactNumTextBox.BorderRadius = 10;
            this.customerContactNumTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerContactNumTextBox.DefaultText = "";
            this.customerContactNumTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerContactNumTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerContactNumTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerContactNumTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerContactNumTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerContactNumTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerContactNumTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerContactNumTextBox.Location = new System.Drawing.Point(41, 333);
            this.customerContactNumTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.customerContactNumTextBox.Multiline = true;
            this.customerContactNumTextBox.Name = "customerContactNumTextBox";
            this.customerContactNumTextBox.PlaceholderText = "";
            this.customerContactNumTextBox.ReadOnly = true;
            this.customerContactNumTextBox.SelectedText = "";
            this.customerContactNumTextBox.Size = new System.Drawing.Size(176, 45);
            this.customerContactNumTextBox.TabIndex = 47;
            // 
            // lblCustomerContactNum
            // 
            this.lblCustomerContactNum.AutoSize = true;
            this.lblCustomerContactNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerContactNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContactNum.Location = new System.Drawing.Point(37, 299);
            this.lblCustomerContactNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerContactNum.Name = "lblCustomerContactNum";
            this.lblCustomerContactNum.Size = new System.Drawing.Size(164, 24);
            this.lblCustomerContactNum.TabIndex = 46;
            this.lblCustomerContactNum.Text = "Contact Number";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.BorderRadius = 10;
            this.customerEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerEmailTextBox.DefaultText = "";
            this.customerEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerEmailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerEmailTextBox.Location = new System.Drawing.Point(41, 228);
            this.customerEmailTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.customerEmailTextBox.Multiline = true;
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.PlaceholderText = "";
            this.customerEmailTextBox.ReadOnly = true;
            this.customerEmailTextBox.SelectedText = "";
            this.customerEmailTextBox.Size = new System.Drawing.Size(401, 45);
            this.customerEmailTextBox.TabIndex = 45;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(37, 189);
            this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(144, 24);
            this.lblCustomerEmail.TabIndex = 44;
            this.lblCustomerEmail.Text = "Email Address";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(36, 14);
            this.lblCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(176, 29);
            this.lblCustomerInfo.TabIndex = 43;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderRadius = 10;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "fs";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(266, 112);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(176, 45);
            this.lastNameTextBox.TabIndex = 42;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(275, 73);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(110, 24);
            this.lblLastName.TabIndex = 41;
            this.lblLastName.Text = "Last Name";
            // 
            // customerLicenseTextBox
            // 
            this.customerLicenseTextBox.BorderRadius = 10;
            this.customerLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerLicenseTextBox.DefaultText = "";
            this.customerLicenseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerLicenseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerLicenseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerLicenseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerLicenseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerLicenseTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLicenseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerLicenseTextBox.Location = new System.Drawing.Point(266, 333);
            this.customerLicenseTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.customerLicenseTextBox.Multiline = true;
            this.customerLicenseTextBox.Name = "customerLicenseTextBox";
            this.customerLicenseTextBox.PlaceholderText = "";
            this.customerLicenseTextBox.ReadOnly = true;
            this.customerLicenseTextBox.SelectedText = "";
            this.customerLicenseTextBox.Size = new System.Drawing.Size(176, 45);
            this.customerLicenseTextBox.TabIndex = 40;
            // 
            // lblCustomerLicense
            // 
            this.lblCustomerLicense.AutoSize = true;
            this.lblCustomerLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerLicense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLicense.Location = new System.Drawing.Point(263, 294);
            this.lblCustomerLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerLicense.Name = "lblCustomerLicense";
            this.lblCustomerLicense.Size = new System.Drawing.Size(163, 24);
            this.lblCustomerLicense.TabIndex = 39;
            this.lblCustomerLicense.Text = "License Number";
            // 
            // vehicleLicenseTextBox
            // 
            this.vehicleLicenseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleLicenseTextBox.BorderRadius = 10;
            this.vehicleLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleLicenseTextBox.DefaultText = "";
            this.vehicleLicenseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleLicenseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleLicenseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleLicenseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleLicenseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleLicenseTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLicenseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleLicenseTextBox.Location = new System.Drawing.Point(969, 436);
            this.vehicleLicenseTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.vehicleLicenseTextBox.Multiline = true;
            this.vehicleLicenseTextBox.Name = "vehicleLicenseTextBox";
            this.vehicleLicenseTextBox.PlaceholderText = "";
            this.vehicleLicenseTextBox.ReadOnly = true;
            this.vehicleLicenseTextBox.SelectedText = "";
            this.vehicleLicenseTextBox.Size = new System.Drawing.Size(241, 45);
            this.vehicleLicenseTextBox.TabIndex = 38;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNum.Location = new System.Drawing.Point(965, 397);
            this.lblLicenseNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(136, 24);
            this.lblLicenseNum.TabIndex = 37;
            this.lblLicenseNum.Text = "License Plate";
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.vehiclePictureBox.Location = new System.Drawing.Point(664, 0);
            this.vehiclePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(548, 365);
            this.vehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vehiclePictureBox.TabIndex = 36;
            this.vehiclePictureBox.TabStop = false;
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleNameTextBox.BorderRadius = 10;
            this.vehicleNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleNameTextBox.DefaultText = "";
            this.vehicleNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNameTextBox.Location = new System.Drawing.Point(664, 436);
            this.vehicleNameTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.vehicleNameTextBox.Multiline = true;
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.PlaceholderText = "";
            this.vehicleNameTextBox.ReadOnly = true;
            this.vehicleNameTextBox.SelectedText = "";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(246, 45);
            this.vehicleNameTextBox.TabIndex = 35;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleName.Location = new System.Drawing.Point(660, 397);
            this.lblVehicleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(77, 24);
            this.lblVehicleName.TabIndex = 34;
            this.lblVehicleName.Text = "Vehicle";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderRadius = 10;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(41, 112);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(9, 15, 9, 15);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(176, 45);
            this.firstNameTextBox.TabIndex = 33;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(37, 73);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 24);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name";
            // 
            // bookingsConflictsMainPanel
            // 
            this.bookingsConflictsMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingsConflictsMainPanel.Controls.Add(this.lblNoBookingConflicts);
            this.bookingsConflictsMainPanel.Controls.Add(this.lblBookingConflicts);
            this.bookingsConflictsMainPanel.Controls.Add(this.conflictFlowPanel);
            this.bookingsConflictsMainPanel.Location = new System.Drawing.Point(1266, 5);
            this.bookingsConflictsMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingsConflictsMainPanel.Name = "bookingsConflictsMainPanel";
            this.bookingsConflictsMainPanel.Size = new System.Drawing.Size(398, 703);
            this.bookingsConflictsMainPanel.TabIndex = 42;
            // 
            // lblNoBookingConflicts
            // 
            this.lblNoBookingConflicts.AutoSize = true;
            this.lblNoBookingConflicts.BackColor = System.Drawing.Color.Transparent;
            this.lblNoBookingConflicts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBookingConflicts.ForeColor = System.Drawing.Color.Green;
            this.lblNoBookingConflicts.Location = new System.Drawing.Point(72, 14);
            this.lblNoBookingConflicts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoBookingConflicts.Name = "lblNoBookingConflicts";
            this.lblNoBookingConflicts.Size = new System.Drawing.Size(266, 29);
            this.lblNoBookingConflicts.TabIndex = 45;
            this.lblNoBookingConflicts.Text = "No Booking Conflicts.";
            // 
            // lblBookingConflicts
            // 
            this.lblBookingConflicts.AutoSize = true;
            this.lblBookingConflicts.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingConflicts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingConflicts.Location = new System.Drawing.Point(72, 14);
            this.lblBookingConflicts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingConflicts.Name = "lblBookingConflicts";
            this.lblBookingConflicts.Size = new System.Drawing.Size(220, 29);
            this.lblBookingConflicts.TabIndex = 44;
            this.lblBookingConflicts.Text = "Booking Conflicts";
            // 
            // conflictFlowPanel
            // 
            this.conflictFlowPanel.AutoScroll = true;
            this.conflictFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conflictFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.conflictFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.conflictFlowPanel.Location = new System.Drawing.Point(0, 65);
            this.conflictFlowPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conflictFlowPanel.Name = "conflictFlowPanel";
            this.conflictFlowPanel.Size = new System.Drawing.Size(400, 638);
            this.conflictFlowPanel.TabIndex = 38;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.BorderThickness = 4;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::VehicleManagementSystem.Properties.Resources.chevron_backward_icon;
            this.backBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Location = new System.Drawing.Point(18, 23);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(57, 52);
            this.backBtn.TabIndex = 44;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblBookingIDValue
            // 
            this.lblBookingIDValue.AutoSize = true;
            this.lblBookingIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingIDValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBookingIDValue.Location = new System.Drawing.Point(282, 23);
            this.lblBookingIDValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingIDValue.Name = "lblBookingIDValue";
            this.lblBookingIDValue.Size = new System.Drawing.Size(151, 35);
            this.lblBookingIDValue.TabIndex = 43;
            this.lblBookingIDValue.Text = "67676767";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(101, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Review pending bookings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(98, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 35);
            this.label3.TabIndex = 39;
            this.label3.Text = "Booking ID:";
            // 
            // frmApprovedBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1698, 890);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmApprovedBooking";
            this.Text = "frmPendingBooking";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            this.bookingsConflictsMainPanel.ResumeLayout(false);
            this.bookingsConflictsMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel conflictFlowPanel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel bookingDetailsPanel;
        private System.Windows.Forms.Label lblDateofRequestValue;
        private System.Windows.Forms.Label lblDateOfRequest;
        private Guna.UI2.WinForms.Guna2TextBox customerContactNumTextBox;
        private System.Windows.Forms.Label lblCustomerContactNum;
        private Guna.UI2.WinForms.Guna2TextBox customerEmailTextBox;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerInfo;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox customerLicenseTextBox;
        private System.Windows.Forms.Label lblCustomerLicense;
        private Guna.UI2.WinForms.Guna2TextBox vehicleLicenseTextBox;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.PictureBox vehiclePictureBox;
        private Guna.UI2.WinForms.Guna2TextBox vehicleNameTextBox;
        private System.Windows.Forms.Label lblVehicleName;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker rentalDateEndDTP;
        private System.Windows.Forms.DateTimePicker rentalDateStartDTP;
        private System.Windows.Forms.Label lblRentalTimeValue;
        private System.Windows.Forms.Label lblRentalTime;
        private System.Windows.Forms.Label lblRentalPeriod;
        private System.Windows.Forms.Label lblto;
        private Guna.UI2.WinForms.Guna2Panel bookingsConflictsMainPanel;
        private System.Windows.Forms.Label lblBookingConflicts;
        private System.Windows.Forms.Label lblBookingIDValue;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Label lblNoBookingConflicts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button releaseUnitBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBookingBtn;
        private Guna.UI2.WinForms.Guna2TextBox currentOdometerTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox currentFuelLevelTextBox;
        private System.Windows.Forms.Label label4;
    }
}