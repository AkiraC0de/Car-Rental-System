namespace VehicleManagementSystem.View.Forms
{
    partial class frmPendingBooking
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
            this.bookingDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
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
            this.vehicleNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblBookingIDValue = new System.Windows.Forms.Label();
            this.bookingsConflictsMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoBookingConflicts = new System.Windows.Forms.Label();
            this.lblBookingConflicts = new System.Windows.Forms.Label();
            this.conflictFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelMain.SuspendLayout();
            this.bookingDetailsPanel.SuspendLayout();
            this.bookingsConflictsMainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
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
            // bookingDetailsPanel
            // 
            this.bookingDetailsPanel.Controls.Add(this.saveBtn);
            this.bookingDetailsPanel.Controls.Add(this.cancelBtn);
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
            this.rentalDateEndDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateEndDTP.Location = new System.Drawing.Point(34, 597);
            this.rentalDateEndDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalDateEndDTP.Name = "rentalDateEndDTP";
            this.rentalDateEndDTP.Size = new System.Drawing.Size(344, 30);
            this.rentalDateEndDTP.TabIndex = 55;
            // 
            // rentalDateStartDTP
            // 
            this.rentalDateStartDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateStartDTP.CustomFormat = "MMMMdd, yyyy hh:mm tt";
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
            this.lblNoBookingConflicts.Location = new System.Drawing.Point(4, 14);
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
            this.lblBookingConflicts.Location = new System.Drawing.Point(39, 11);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::VehicleManagementSystem.Properties.Resources.file;
            this.saveBtn.ImageOffset = new System.Drawing.Point(-10, 0);
            this.saveBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.saveBtn.Location = new System.Drawing.Point(969, 640);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(243, 60);
            this.saveBtn.TabIndex = 61;
            this.saveBtn.Text = "Approve";
            this.saveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BorderColor = System.Drawing.Color.Silver;
            this.cancelBtn.BorderRadius = 10;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = global::VehicleManagementSystem.Properties.Resources.file__1_;
            this.cancelBtn.ImageOffset = new System.Drawing.Point(-10, 0);
            this.cancelBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancelBtn.Location = new System.Drawing.Point(664, 640);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(246, 60);
            this.cancelBtn.TabIndex = 60;
            this.cancelBtn.Text = "Reject";
            this.cancelBtn.Click += new System.EventHandler(this.rejectBtn_Click);
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
            // frmPendingBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1698, 890);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPendingBooking";
            this.Text = "frmPendingBooking";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            this.bookingsConflictsMainPanel.ResumeLayout(false);
            this.bookingsConflictsMainPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
    }
}