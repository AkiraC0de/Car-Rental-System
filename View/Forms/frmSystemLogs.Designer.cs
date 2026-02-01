namespace ActivityLogs
{
    partial class LogsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.WarningBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StaffCheckBoxx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AdminCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.FailedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuccessBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AllTypesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FilterTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UserCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Activity Logs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "All actions performed in the system";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.UserCheckBox);
            this.guna2Panel1.Controls.Add(this.WarningBtn);
            this.guna2Panel1.Controls.Add(this.StaffCheckBoxx);
            this.guna2Panel1.Controls.Add(this.AdminCheckBox);
            this.guna2Panel1.Controls.Add(this.FailedBtn);
            this.guna2Panel1.Controls.Add(this.SuccessBtn);
            this.guna2Panel1.Controls.Add(this.AllTypesBtn);
            this.guna2Panel1.Controls.Add(this.FilterTxtBox);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 99);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(721, 74);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // WarningBtn
            // 
            this.WarningBtn.AutoRoundedCorners = true;
            this.WarningBtn.BorderThickness = 1;
            this.WarningBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WarningBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WarningBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WarningBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WarningBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.WarningBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WarningBtn.ForeColor = System.Drawing.Color.Black;
            this.WarningBtn.Location = new System.Drawing.Point(465, 20);
            this.WarningBtn.Name = "WarningBtn";
            this.WarningBtn.Size = new System.Drawing.Size(97, 28);
            this.WarningBtn.TabIndex = 6;
            this.WarningBtn.Text = "Warning";
            // 
            // StaffCheckBoxx
            // 
            this.StaffCheckBoxx.AutoSize = true;
            this.StaffCheckBoxx.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.StaffCheckBoxx.CheckedState.BorderRadius = 0;
            this.StaffCheckBoxx.CheckedState.BorderThickness = 0;
            this.StaffCheckBoxx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StaffCheckBoxx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.StaffCheckBoxx.Location = new System.Drawing.Point(641, 20);
            this.StaffCheckBoxx.Name = "StaffCheckBoxx";
            this.StaffCheckBoxx.Size = new System.Drawing.Size(59, 24);
            this.StaffCheckBoxx.TabIndex = 5;
            this.StaffCheckBoxx.Text = "Staff";
            this.StaffCheckBoxx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.StaffCheckBoxx.UncheckedState.BorderRadius = 0;
            this.StaffCheckBoxx.UncheckedState.BorderThickness = 1;
            this.StaffCheckBoxx.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.AdminCheckBox.CheckedState.BorderRadius = 0;
            this.AdminCheckBox.CheckedState.BorderThickness = 0;
            this.AdminCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheckBox.Location = new System.Drawing.Point(572, 20);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(72, 24);
            this.AdminCheckBox.TabIndex = 4;
            this.AdminCheckBox.Text = "Admin";
            this.AdminCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.AdminCheckBox.UncheckedState.BorderRadius = 0;
            this.AdminCheckBox.UncheckedState.BorderThickness = 1;
            this.AdminCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdminCheckBox.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // FailedBtn
            // 
            this.FailedBtn.AutoRoundedCorners = true;
            this.FailedBtn.BorderThickness = 1;
            this.FailedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FailedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FailedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FailedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FailedBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.FailedBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FailedBtn.ForeColor = System.Drawing.Color.Black;
            this.FailedBtn.Location = new System.Drawing.Point(362, 20);
            this.FailedBtn.Name = "FailedBtn";
            this.FailedBtn.Size = new System.Drawing.Size(97, 28);
            this.FailedBtn.TabIndex = 3;
            this.FailedBtn.Text = "Failed";
            // 
            // SuccessBtn
            // 
            this.SuccessBtn.AutoRoundedCorners = true;
            this.SuccessBtn.BorderThickness = 1;
            this.SuccessBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SuccessBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SuccessBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SuccessBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SuccessBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.SuccessBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SuccessBtn.ForeColor = System.Drawing.Color.Black;
            this.SuccessBtn.Location = new System.Drawing.Point(259, 20);
            this.SuccessBtn.Name = "SuccessBtn";
            this.SuccessBtn.Size = new System.Drawing.Size(97, 28);
            this.SuccessBtn.TabIndex = 2;
            this.SuccessBtn.Text = "Success";
            this.SuccessBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AllTypesBtn
            // 
            this.AllTypesBtn.AutoRoundedCorners = true;
            this.AllTypesBtn.BorderThickness = 1;
            this.AllTypesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllTypesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllTypesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllTypesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllTypesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.AllTypesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllTypesBtn.ForeColor = System.Drawing.Color.Black;
            this.AllTypesBtn.Location = new System.Drawing.Point(154, 20);
            this.AllTypesBtn.Name = "AllTypesBtn";
            this.AllTypesBtn.Size = new System.Drawing.Size(97, 28);
            this.AllTypesBtn.TabIndex = 1;
            this.AllTypesBtn.Text = "All Types";
            this.AllTypesBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FilterTxtBox
            // 
            this.FilterTxtBox.BorderColor = System.Drawing.Color.Black;
            this.FilterTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FilterTxtBox.DefaultText = "";
            this.FilterTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FilterTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FilterTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FilterTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FilterTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterTxtBox.Location = new System.Drawing.Point(11, 20);
            this.FilterTxtBox.Name = "FilterTxtBox";
            this.FilterTxtBox.PlaceholderText = "";
            this.FilterTxtBox.SelectedText = "";
            this.FilterTxtBox.Size = new System.Drawing.Size(137, 28);
            this.FilterTxtBox.TabIndex = 0;
            // 
            // DataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeight = 40;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.ActionColumn,
            this.RoleColumn,
            this.StatusColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = "10:30 AM";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid.GridColor = System.Drawing.Color.Gray;
            this.DataGrid.Location = new System.Drawing.Point(35, 191);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.Size = new System.Drawing.Size(721, 247);
            this.DataGrid.TabIndex = 6;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGrid.ThemeStyle.ReadOnly = true;
            this.DataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.DataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UserCheckBox
            // 
            this.UserCheckBox.AutoSize = true;
            this.UserCheckBox.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.UserCheckBox.CheckedState.BorderRadius = 0;
            this.UserCheckBox.CheckedState.BorderThickness = 0;
            this.UserCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.UserCheckBox.Location = new System.Drawing.Point(608, 40);
            this.UserCheckBox.Name = "UserCheckBox";
            this.UserCheckBox.Size = new System.Drawing.Size(57, 24);
            this.UserCheckBox.TabIndex = 7;
            this.UserCheckBox.Text = "User";
            this.UserCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.UserCheckBox.UncheckedState.BorderRadius = 0;
            this.UserCheckBox.UncheckedState.BorderThickness = 1;
            this.UserCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // TimeColumn
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TimeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.TimeColumn.FillWeight = 65.65144F;
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // ActionColumn
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "Marked Honda Civic for Maintenance";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ActionColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ActionColumn.FillWeight = 203.0457F;
            this.ActionColumn.HeaderText = "Action";
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            // 
            // RoleColumn
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "Admin";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.RoleColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.RoleColumn.FillWeight = 65.65144F;
            this.RoleColumn.HeaderText = "Role";
            this.RoleColumn.MinimumWidth = 100;
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.NullValue = "Warning";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.StatusColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.StatusColumn.FillWeight = 65.65144F;
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button FailedBtn;
        private Guna.UI2.WinForms.Guna2Button SuccessBtn;
        private Guna.UI2.WinForms.Guna2Button AllTypesBtn;
        private Guna.UI2.WinForms.Guna2TextBox FilterTxtBox;
        private Guna.UI2.WinForms.Guna2CheckBox AdminCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox StaffCheckBoxx;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
        private Guna.UI2.WinForms.Guna2Button WarningBtn;
        private Guna.UI2.WinForms.Guna2CheckBox UserCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}

