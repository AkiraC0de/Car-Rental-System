using System.Drawing;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    partial class frmAddNewVehicle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLowerInputs = new System.Windows.Forms.TableLayoutPanel();
            this.panelCarRental = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2TextBox10 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2TextBox12 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPurchaseDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox9 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2TextBox8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelBasicInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.tableBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelBasicInfoLeft = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.inputModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputManufacturer = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputVehicleIdentificationNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPlateNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBasicInfoRight = new System.Windows.Forms.Panel();
            this.vehicleImageFilename = new Guna.UI2.WinForms.Guna2TextBox();
            this.addImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputYearModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelBasicInfoHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLowerInputs.SuspendLayout();
            this.panelCarRental.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.panelPurchaseDetails.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.panelBasicInformation.SuspendLayout();
            this.tableBasicInfo.SuspendLayout();
            this.panelBasicInfoLeft.SuspendLayout();
            this.panelBasicInfoRight.SuspendLayout();
            this.panelBasicInfoHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.Color.Transparent;
            this.panelBg.BorderRadius = 25;
            this.panelBg.Controls.Add(this.panelMain);
            this.panelBg.CustomizableEdges.BottomLeft = false;
            this.panelBg.CustomizableEdges.BottomRight = false;
            this.panelBg.CustomizableEdges.TopRight = false;
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1274, 683);
            this.panelBg.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.tableLowerInputs);
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.panelBasicInformation);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(24, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1250, 683);
            this.panelMain.TabIndex = 11;
            // 
            // tableLowerInputs
            // 
            this.tableLowerInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLowerInputs.ColumnCount = 2;
            this.tableLowerInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.Controls.Add(this.panelCarRental, 1, 0);
            this.tableLowerInputs.Controls.Add(this.panelPurchaseDetails, 0, 0);
            this.tableLowerInputs.Location = new System.Drawing.Point(51, 623);
            this.tableLowerInputs.Name = "tableLowerInputs";
            this.tableLowerInputs.RowCount = 1;
            this.tableLowerInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.Size = new System.Drawing.Size(1146, 449);
            this.tableLowerInputs.TabIndex = 13;
            // 
            // panelCarRental
            // 
            this.panelCarRental.BorderRadius = 20;
            this.panelCarRental.Controls.Add(this.guna2ComboBox3);
            this.panelCarRental.Controls.Add(this.guna2ComboBox2);
            this.panelCarRental.Controls.Add(this.label20);
            this.panelCarRental.Controls.Add(this.guna2TextBox10);
            this.panelCarRental.Controls.Add(this.label17);
            this.panelCarRental.Controls.Add(this.label18);
            this.panelCarRental.Controls.Add(this.guna2TextBox12);
            this.panelCarRental.Controls.Add(this.label19);
            this.panelCarRental.Controls.Add(this.guna2Panel6);
            this.panelCarRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarRental.FillColor = System.Drawing.Color.White;
            this.panelCarRental.Location = new System.Drawing.Point(593, 0);
            this.panelCarRental.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelCarRental.Name = "panelCarRental";
            this.panelCarRental.Size = new System.Drawing.Size(553, 449);
            this.panelCarRental.TabIndex = 14;
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.BorderRadius = 10;
            this.guna2ComboBox3.BorderThickness = 2;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox3.IntegralHeight = false;
            this.guna2ComboBox3.ItemHeight = 50;
            this.guna2ComboBox3.Location = new System.Drawing.Point(277, 241);
            this.guna2ComboBox3.Margin = new System.Windows.Forms.Padding(10);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.Size = new System.Drawing.Size(227, 56);
            this.guna2ComboBox3.TabIndex = 24;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 10;
            this.guna2ComboBox2.BorderThickness = 2;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.IntegralHeight = false;
            this.guna2ComboBox2.ItemHeight = 50;
            this.guna2ComboBox2.Location = new System.Drawing.Point(25, 241);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(10);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(227, 56);
            this.guna2ComboBox2.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label20.Location = new System.Drawing.Point(272, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 26);
            this.label20.TabIndex = 27;
            this.label20.Text = "Transmition Type";
            // 
            // guna2TextBox10
            // 
            this.guna2TextBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox10.BorderRadius = 10;
            this.guna2TextBox10.BorderThickness = 2;
            this.guna2TextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox10.DefaultText = "";
            this.guna2TextBox10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox10.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox10.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox10.Location = new System.Drawing.Point(25, 355);
            this.guna2TextBox10.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox10.Name = "guna2TextBox10";
            this.guna2TextBox10.PlaceholderText = "";
            this.guna2TextBox10.SelectedText = "";
            this.guna2TextBox10.Size = new System.Drawing.Size(479, 55);
            this.guna2TextBox10.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label17.Location = new System.Drawing.Point(20, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 26);
            this.label17.TabIndex = 25;
            this.label17.Text = " Seating Capacity";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label18.Location = new System.Drawing.Point(20, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 26);
            this.label18.TabIndex = 23;
            this.label18.Text = "Fuel Type";
            // 
            // guna2TextBox12
            // 
            this.guna2TextBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox12.BorderRadius = 10;
            this.guna2TextBox12.BorderThickness = 2;
            this.guna2TextBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox12.DefaultText = "";
            this.guna2TextBox12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox12.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox12.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox12.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox12.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox12.Location = new System.Drawing.Point(25, 119);
            this.guna2TextBox12.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox12.Name = "guna2TextBox12";
            this.guna2TextBox12.PlaceholderText = "";
            this.guna2TextBox12.SelectedText = "";
            this.guna2TextBox12.Size = new System.Drawing.Size(479, 55);
            this.guna2TextBox12.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label19.Location = new System.Drawing.Point(20, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 26);
            this.label19.TabIndex = 21;
            this.label19.Text = "Daily Rate (₱)";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel6.BorderRadius = 20;
            this.guna2Panel6.Controls.Add(this.guna2CirclePictureBox4);
            this.guna2Panel6.Controls.Add(this.label1);
            this.guna2Panel6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Panel6.CustomizableEdges.BottomLeft = false;
            this.guna2Panel6.CustomizableEdges.BottomRight = false;
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.guna2Panel6.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(553, 64);
            this.guna2Panel6.TabIndex = 1;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox4.Image = global::VehicleManagementSystem.Properties.Resources.car_gear_icon;
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox4.TabIndex = 11;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rental Details";
            // 
            // panelPurchaseDetails
            // 
            this.panelPurchaseDetails.BorderRadius = 20;
            this.panelPurchaseDetails.Controls.Add(this.guna2DateTimePicker1);
            this.panelPurchaseDetails.Controls.Add(this.guna2TextBox9);
            this.panelPurchaseDetails.Controls.Add(this.label16);
            this.panelPurchaseDetails.Controls.Add(this.guna2TextBox8);
            this.panelPurchaseDetails.Controls.Add(this.label14);
            this.panelPurchaseDetails.Controls.Add(this.label13);
            this.panelPurchaseDetails.Controls.Add(this.guna2Panel5);
            this.panelPurchaseDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPurchaseDetails.FillColor = System.Drawing.Color.White;
            this.panelPurchaseDetails.Location = new System.Drawing.Point(0, 0);
            this.panelPurchaseDetails.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelPurchaseDetails.Name = "panelPurchaseDetails";
            this.panelPurchaseDetails.Size = new System.Drawing.Size(553, 449);
            this.panelPurchaseDetails.TabIndex = 11;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.BorderThickness = 6;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(36, 121);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(479, 55);
            this.guna2DateTimePicker1.TabIndex = 20;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 1, 20, 18, 53, 53, 702);
            // 
            // guna2TextBox9
            // 
            this.guna2TextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox9.BorderRadius = 10;
            this.guna2TextBox9.BorderThickness = 2;
            this.guna2TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox9.DefaultText = "";
            this.guna2TextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox9.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox9.Location = new System.Drawing.Point(36, 355);
            this.guna2TextBox9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox9.Name = "guna2TextBox9";
            this.guna2TextBox9.PlaceholderText = "";
            this.guna2TextBox9.SelectedText = "";
            this.guna2TextBox9.Size = new System.Drawing.Size(479, 55);
            this.guna2TextBox9.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label16.Location = new System.Drawing.Point(31, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(241, 26);
            this.label16.TabIndex = 19;
            this.label16.Text = "Current Odometer (Km)";
            // 
            // guna2TextBox8
            // 
            this.guna2TextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox8.BorderRadius = 10;
            this.guna2TextBox8.BorderThickness = 2;
            this.guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox8.DefaultText = "";
            this.guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox8.Location = new System.Drawing.Point(36, 242);
            this.guna2TextBox8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox8.Name = "guna2TextBox8";
            this.guna2TextBox8.PlaceholderText = "";
            this.guna2TextBox8.SelectedText = "";
            this.guna2TextBox8.Size = new System.Drawing.Size(479, 55);
            this.guna2TextBox8.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label14.Location = new System.Drawing.Point(31, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Purchase Price";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label13.Location = new System.Drawing.Point(31, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Purchase Date";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel5.BorderRadius = 20;
            this.guna2Panel5.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel5.Controls.Add(this.label12);
            this.guna2Panel5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Panel5.CustomizableEdges.BottomLeft = false;
            this.guna2Panel5.CustomizableEdges.BottomRight = false;
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(553, 64);
            this.guna2Panel5.TabIndex = 1;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox2.Image = global::VehicleManagementSystem.Properties.Resources.price_change_icon;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 11;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Purchase Details";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(51, 1424);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1152, 241);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox3);
            this.guna2Panel2.Controls.Add(this.label15);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1152, 64);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox3.Image = global::VehicleManagementSystem.Properties.Resources.price_change_icon;
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 11;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(66, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 29);
            this.label15.TabIndex = 8;
            this.label15.Text = "Purchase Details";
            // 
            // panelBasicInformation
            // 
            this.panelBasicInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBasicInformation.BackColor = System.Drawing.Color.Transparent;
            this.panelBasicInformation.BorderRadius = 20;
            this.panelBasicInformation.Controls.Add(this.tableBasicInfo);
            this.panelBasicInformation.Controls.Add(this.panelBasicInfoHeader);
            this.panelBasicInformation.FillColor = System.Drawing.Color.White;
            this.panelBasicInformation.Location = new System.Drawing.Point(48, 118);
            this.panelBasicInformation.Name = "panelBasicInformation";
            this.panelBasicInformation.Size = new System.Drawing.Size(1153, 448);
            this.panelBasicInformation.TabIndex = 9;
            // 
            // tableBasicInfo
            // 
            this.tableBasicInfo.ColumnCount = 2;
            this.tableBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.Controls.Add(this.panelBasicInfoLeft, 0, 0);
            this.tableBasicInfo.Controls.Add(this.panelBasicInfoRight, 1, 0);
            this.tableBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBasicInfo.Location = new System.Drawing.Point(0, 64);
            this.tableBasicInfo.Name = "tableBasicInfo";
            this.tableBasicInfo.RowCount = 1;
            this.tableBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.Size = new System.Drawing.Size(1153, 384);
            this.tableBasicInfo.TabIndex = 1;
            // 
            // panelBasicInfoLeft
            // 
            this.panelBasicInfoLeft.Controls.Add(this.label21);
            this.panelBasicInfoLeft.Controls.Add(this.inputModel);
            this.panelBasicInfoLeft.Controls.Add(this.inputManufacturer);
            this.panelBasicInfoLeft.Controls.Add(this.inputVehicleIdentificationNumber);
            this.panelBasicInfoLeft.Controls.Add(this.label6);
            this.panelBasicInfoLeft.Controls.Add(this.label5);
            this.panelBasicInfoLeft.Controls.Add(this.label4);
            this.panelBasicInfoLeft.Controls.Add(this.inputPlateNum);
            this.panelBasicInfoLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoLeft.Location = new System.Drawing.Point(3, 3);
            this.panelBasicInfoLeft.Name = "panelBasicInfoLeft";
            this.panelBasicInfoLeft.Size = new System.Drawing.Size(570, 378);
            this.panelBasicInfoLeft.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label21.Location = new System.Drawing.Point(304, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 26);
            this.label21.TabIndex = 26;
            this.label21.Text = "Model";
            // 
            // inputModel
            // 
            this.inputModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputModel.BorderRadius = 10;
            this.inputModel.BorderThickness = 2;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.DefaultText = "";
            this.inputModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputModel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputModel.Location = new System.Drawing.Point(309, 295);
            this.inputModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputModel.Name = "inputModel";
            this.inputModel.PlaceholderText = "ex: Vios";
            this.inputModel.SelectedText = "";
            this.inputModel.Size = new System.Drawing.Size(250, 55);
            this.inputModel.TabIndex = 25;
            // 
            // inputManufacturer
            // 
            this.inputManufacturer.BorderRadius = 10;
            this.inputManufacturer.BorderThickness = 2;
            this.inputManufacturer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputManufacturer.DefaultText = "";
            this.inputManufacturer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputManufacturer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputManufacturer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputManufacturer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputManufacturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputManufacturer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputManufacturer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputManufacturer.Location = new System.Drawing.Point(36, 295);
            this.inputManufacturer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputManufacturer.Name = "inputManufacturer";
            this.inputManufacturer.PlaceholderText = "ex: Toyota";
            this.inputManufacturer.SelectedText = "";
            this.inputManufacturer.Size = new System.Drawing.Size(250, 55);
            this.inputManufacturer.TabIndex = 24;
            // 
            // inputVehicleIdentificationNumber
            // 
            this.inputVehicleIdentificationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputVehicleIdentificationNumber.BorderRadius = 10;
            this.inputVehicleIdentificationNumber.BorderThickness = 2;
            this.inputVehicleIdentificationNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputVehicleIdentificationNumber.DefaultText = "";
            this.inputVehicleIdentificationNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputVehicleIdentificationNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputVehicleIdentificationNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputVehicleIdentificationNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputVehicleIdentificationNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputVehicleIdentificationNumber.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVehicleIdentificationNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputVehicleIdentificationNumber.Location = new System.Drawing.Point(36, 47);
            this.inputVehicleIdentificationNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputVehicleIdentificationNumber.Name = "inputVehicleIdentificationNumber";
            this.inputVehicleIdentificationNumber.PlaceholderText = "";
            this.inputVehicleIdentificationNumber.SelectedText = "";
            this.inputVehicleIdentificationNumber.Size = new System.Drawing.Size(523, 55);
            this.inputVehicleIdentificationNumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(31, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(31, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "License Plate Number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(31, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Identification Number (VIN)";
            // 
            // inputPlateNum
            // 
            this.inputPlateNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlateNum.BorderRadius = 10;
            this.inputPlateNum.BorderThickness = 2;
            this.inputPlateNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPlateNum.DefaultText = "";
            this.inputPlateNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputPlateNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputPlateNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPlateNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPlateNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPlateNum.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPlateNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPlateNum.Location = new System.Drawing.Point(36, 170);
            this.inputPlateNum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputPlateNum.Name = "inputPlateNum";
            this.inputPlateNum.PlaceholderText = "ex: 000-abc";
            this.inputPlateNum.SelectedText = "";
            this.inputPlateNum.Size = new System.Drawing.Size(523, 55);
            this.inputPlateNum.TabIndex = 10;
            // 
            // panelBasicInfoRight
            // 
            this.panelBasicInfoRight.Controls.Add(this.vehicleImageFilename);
            this.panelBasicInfoRight.Controls.Add(this.addImageBtn);
            this.panelBasicInfoRight.Controls.Add(this.label7);
            this.panelBasicInfoRight.Controls.Add(this.guna2TextBox6);
            this.panelBasicInfoRight.Controls.Add(this.inputYearModel);
            this.panelBasicInfoRight.Controls.Add(this.guna2ComboBox1);
            this.panelBasicInfoRight.Controls.Add(this.label9);
            this.panelBasicInfoRight.Controls.Add(this.label10);
            this.panelBasicInfoRight.Controls.Add(this.label11);
            this.panelBasicInfoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoRight.Location = new System.Drawing.Point(579, 3);
            this.panelBasicInfoRight.Name = "panelBasicInfoRight";
            this.panelBasicInfoRight.Size = new System.Drawing.Size(571, 378);
            this.panelBasicInfoRight.TabIndex = 1;
            // 
            // vehicleImageFilename
            // 
            this.vehicleImageFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleImageFilename.BorderRadius = 10;
            this.vehicleImageFilename.BorderThickness = 2;
            this.vehicleImageFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleImageFilename.DefaultText = "";
            this.vehicleImageFilename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleImageFilename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleImageFilename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleImageFilename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleImageFilename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleImageFilename.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleImageFilename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleImageFilename.Location = new System.Drawing.Point(180, 295);
            this.vehicleImageFilename.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.vehicleImageFilename.Name = "vehicleImageFilename";
            this.vehicleImageFilename.PlaceholderText = "ex: vehicleimage.png";
            this.vehicleImageFilename.ReadOnly = true;
            this.vehicleImageFilename.SelectedText = "";
            this.vehicleImageFilename.Size = new System.Drawing.Size(360, 55);
            this.vehicleImageFilename.TabIndex = 1;
            // 
            // addImageBtn
            // 
            this.addImageBtn.BorderRadius = 10;
            this.addImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addImageBtn.FillColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtn.ForeColor = System.Drawing.Color.White;
            this.addImageBtn.Image = global::VehicleManagementSystem.Properties.Resources.add_circle_icon;
            this.addImageBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.addImageBtn.Location = new System.Drawing.Point(17, 296);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(142, 54);
            this.addImageBtn.TabIndex = 100;
            this.addImageBtn.Text = "Add Image";
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vehicles Image";
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox6.BorderRadius = 10;
            this.guna2TextBox6.BorderThickness = 2;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(296, 47);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PlaceholderText = "ex: Red";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(244, 55);
            this.guna2TextBox6.TabIndex = 24;
            // 
            // inputYearModel
            // 
            this.inputYearModel.BorderRadius = 10;
            this.inputYearModel.BorderThickness = 2;
            this.inputYearModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputYearModel.DefaultText = "";
            this.inputYearModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputYearModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputYearModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputYearModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputYearModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputYearModel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputYearModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputYearModel.Location = new System.Drawing.Point(17, 47);
            this.inputYearModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputYearModel.Name = "inputYearModel";
            this.inputYearModel.PlaceholderText = "ex: 2005";
            this.inputYearModel.SelectedText = "";
            this.inputYearModel.Size = new System.Drawing.Size(250, 55);
            this.inputYearModel.TabIndex = 23;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 50;
            this.guna2ComboBox1.Location = new System.Drawing.Point(17, 170);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(523, 56);
            this.guna2ComboBox1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(12, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Year Model";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label11.Location = new System.Drawing.Point(291, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "Color";
            // 
            // panelBasicInfoHeader
            // 
            this.panelBasicInfoHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.BorderRadius = 20;
            this.panelBasicInfoHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.panelBasicInfoHeader.Controls.Add(this.label2);
            this.panelBasicInfoHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelBasicInfoHeader.CustomizableEdges.BottomLeft = false;
            this.panelBasicInfoHeader.CustomizableEdges.BottomRight = false;
            this.panelBasicInfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBasicInfoHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.panelBasicInfoHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBasicInfoHeader.Name = "panelBasicInfoHeader";
            this.panelBasicInfoHeader.Size = new System.Drawing.Size(1153, 64);
            this.panelBasicInfoHeader.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox1.Image = global::VehicleManagementSystem.Properties.Resources.pen_icon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Basic Vehicle Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(44, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input vehicle specifications and VIN.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(40, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bring in a New Vehicle";
            // 
            // frmAddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 683);
            this.Controls.Add(this.panelBg);
            this.DoubleBuffered = true;
            this.Name = "frmAddNewVehicle";
            this.Text = "AddNewVeh";
            this.panelBg.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLowerInputs.ResumeLayout(false);
            this.panelCarRental.ResumeLayout(false);
            this.panelCarRental.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.panelPurchaseDetails.ResumeLayout(false);
            this.panelPurchaseDetails.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.panelBasicInformation.ResumeLayout(false);
            this.tableBasicInfo.ResumeLayout(false);
            this.panelBasicInfoLeft.ResumeLayout(false);
            this.panelBasicInfoLeft.PerformLayout();
            this.panelBasicInfoRight.ResumeLayout(false);
            this.panelBasicInfoRight.PerformLayout();
            this.panelBasicInfoHeader.ResumeLayout(false);
            this.panelBasicInfoHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelBasicInformation;
        private Guna.UI2.WinForms.Guna2Panel panelBasicInfoHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox inputVehicleIdentificationNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox inputPlateNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox inputYearModel;
        private System.Windows.Forms.TableLayoutPanel tableBasicInfo;
        private System.Windows.Forms.Panel panelBasicInfoLeft;
        private System.Windows.Forms.Panel panelBasicInfoRight;
        private Guna.UI2.WinForms.Guna2Panel panelPurchaseDetails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLowerInputs;
        private Guna.UI2.WinForms.Guna2Panel panelCarRental;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox8;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox9;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2TextBox inputModel;
        private Guna.UI2.WinForms.Guna2TextBox inputManufacturer;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button addImageBtn;
        private Guna.UI2.WinForms.Guna2TextBox vehicleImageFilename;
    }
}