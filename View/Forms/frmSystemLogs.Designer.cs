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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.UserCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.WarningBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StaffCheckBoxx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AdminCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.FailedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuccessBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AllTypesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FilterTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvLogs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.titlePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Activity Logs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(13, 50);
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
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 84);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 74);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // UserCheckBox
            // 
            this.UserCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserCheckBox.AutoSize = true;
            this.UserCheckBox.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.UserCheckBox.CheckedState.BorderRadius = 0;
            this.UserCheckBox.CheckedState.BorderThickness = 0;
            this.UserCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.UserCheckBox.Location = new System.Drawing.Point(687, 40);
            this.UserCheckBox.Name = "UserCheckBox";
            this.UserCheckBox.Size = new System.Drawing.Size(57, 24);
            this.UserCheckBox.TabIndex = 7;
            this.UserCheckBox.Text = "User";
            this.UserCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.UserCheckBox.UncheckedState.BorderRadius = 0;
            this.UserCheckBox.UncheckedState.BorderThickness = 1;
            this.UserCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // WarningBtn
            // 
            this.WarningBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningBtn.AutoRoundedCorners = true;
            this.WarningBtn.BorderThickness = 1;
            this.WarningBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WarningBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WarningBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WarningBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WarningBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.WarningBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WarningBtn.ForeColor = System.Drawing.Color.Black;
            this.WarningBtn.Location = new System.Drawing.Point(544, 20);
            this.WarningBtn.Name = "WarningBtn";
            this.WarningBtn.Size = new System.Drawing.Size(97, 28);
            this.WarningBtn.TabIndex = 6;
            this.WarningBtn.Text = "Warning";
            // 
            // StaffCheckBoxx
            // 
            this.StaffCheckBoxx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffCheckBoxx.AutoSize = true;
            this.StaffCheckBoxx.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.StaffCheckBoxx.CheckedState.BorderRadius = 0;
            this.StaffCheckBoxx.CheckedState.BorderThickness = 0;
            this.StaffCheckBoxx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StaffCheckBoxx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.StaffCheckBoxx.Location = new System.Drawing.Point(718, 20);
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
            this.AdminCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.AdminCheckBox.CheckedState.BorderRadius = 0;
            this.AdminCheckBox.CheckedState.BorderThickness = 0;
            this.AdminCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheckBox.Location = new System.Drawing.Point(651, 20);
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
            this.FailedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FailedBtn.AutoRoundedCorners = true;
            this.FailedBtn.BorderThickness = 1;
            this.FailedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FailedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FailedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FailedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FailedBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.FailedBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FailedBtn.ForeColor = System.Drawing.Color.Black;
            this.FailedBtn.Location = new System.Drawing.Point(441, 20);
            this.FailedBtn.Name = "FailedBtn";
            this.FailedBtn.Size = new System.Drawing.Size(97, 28);
            this.FailedBtn.TabIndex = 3;
            this.FailedBtn.Text = "Failed";
            // 
            // SuccessBtn
            // 
            this.SuccessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuccessBtn.AutoRoundedCorners = true;
            this.SuccessBtn.BorderThickness = 1;
            this.SuccessBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SuccessBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SuccessBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SuccessBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SuccessBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.SuccessBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SuccessBtn.ForeColor = System.Drawing.Color.Black;
            this.SuccessBtn.Location = new System.Drawing.Point(338, 20);
            this.SuccessBtn.Name = "SuccessBtn";
            this.SuccessBtn.Size = new System.Drawing.Size(97, 28);
            this.SuccessBtn.TabIndex = 2;
            this.SuccessBtn.Text = "Success";
            this.SuccessBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AllTypesBtn
            // 
            this.AllTypesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTypesBtn.AutoRoundedCorners = true;
            this.AllTypesBtn.BorderThickness = 1;
            this.AllTypesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllTypesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllTypesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllTypesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllTypesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.AllTypesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllTypesBtn.ForeColor = System.Drawing.Color.Black;
            this.AllTypesBtn.Location = new System.Drawing.Point(233, 20);
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
            this.FilterTxtBox.Location = new System.Drawing.Point(35, 20);
            this.FilterTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterTxtBox.Name = "FilterTxtBox";
            this.FilterTxtBox.PlaceholderText = "";
            this.FilterTxtBox.SelectedText = "";
            this.FilterTxtBox.Size = new System.Drawing.Size(137, 28);
            this.FilterTxtBox.TabIndex = 0;
            // 
            // dgvLogs
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLogs.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = "10:30 AM";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.GridColor = System.Drawing.Color.Gray;
            this.dgvLogs.Location = new System.Drawing.Point(0, 158);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowHeadersWidth = 62;
            this.dgvLogs.Size = new System.Drawing.Size(800, 316);
            this.dgvLogs.TabIndex = 6;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLogs.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLogs.ThemeStyle.ReadOnly = true;
            this.dgvLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLogs.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellContentClick);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.label2);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(800, 84);
            this.titlePanel.TabIndex = 7;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvLogs);
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.titlePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 474);
            this.mainPanel.TabIndex = 8;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.mainPanel);
            this.Name = "LogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            this.Shown += new System.EventHandler(this.LogsForm_Shown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Guna.UI2.WinForms.Guna2DataGridView dgvLogs;
        private Guna.UI2.WinForms.Guna2Button WarningBtn;
        private Guna.UI2.WinForms.Guna2CheckBox UserCheckBox;
        private Guna.UI2.WinForms.Guna2Panel titlePanel;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}

