namespace VehicleManagementSystem.Forms {
    partial class frmMaintenanceManagement {
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelBg = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSubMain = new Guna.UI2.WinForms.Guna2Panel();
            this.hr = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNav = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.maintenanceTypeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.rejectedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.panelBg.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 25;
            this.guna2GradientPanel1.Controls.Add(this.panelBg);
            this.guna2GradientPanel1.CustomizableEdges.BottomLeft = false;
            this.guna2GradientPanel1.CustomizableEdges.BottomRight = false;
            this.guna2GradientPanel1.CustomizableEdges.TopRight = false;
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1132, 546);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // panelBg
            // 
            this.panelBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBg.AutoScroll = true;
            this.panelBg.BackColor = System.Drawing.Color.Transparent;
            this.panelBg.BorderRadius = 5;
            this.panelBg.BorderThickness = 10;
            this.panelBg.Controls.Add(this.panelSubMain);
            this.panelBg.Controls.Add(this.hr);
            this.panelBg.Controls.Add(this.panelNav);
            this.panelBg.Controls.Add(this.label2);
            this.panelBg.Controls.Add(this.label3);
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelBg.Location = new System.Drawing.Point(22, 0);
            this.panelBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1110, 546);
            this.panelBg.TabIndex = 0;
            // 
            // panelSubMain
            // 
            this.panelSubMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubMain.Location = new System.Drawing.Point(14, 106);
            this.panelSubMain.Name = "panelSubMain";
            this.panelSubMain.Size = new System.Drawing.Size(1047, 624);
            this.panelSubMain.TabIndex = 52;
            // 
            // hr
            // 
            this.hr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hr.BackColor = System.Drawing.Color.Transparent;
            this.hr.Location = new System.Drawing.Point(14, 84);
            this.hr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(1047, 4);
            this.hr.TabIndex = 49;
            // 
            // panelNav
            // 
            this.panelNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNav.BackColor = System.Drawing.Color.Transparent;
            this.panelNav.Controls.Add(this.dashboardBtn);
            this.panelNav.Controls.Add(this.maintenanceTypeBtn);
            this.panelNav.Controls.Add(this.rejectedBtn);
            this.panelNav.Location = new System.Drawing.Point(507, 25);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(554, 61);
            this.panelNav.TabIndex = 48;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboardBtn.FillColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboardBtn.Location = new System.Drawing.Point(56, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(159, 61);
            this.dashboardBtn.TabIndex = 5;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // maintenanceTypeBtn
            // 
            this.maintenanceTypeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maintenanceTypeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maintenanceTypeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maintenanceTypeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maintenanceTypeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maintenanceTypeBtn.FillColor = System.Drawing.Color.Transparent;
            this.maintenanceTypeBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maintenanceTypeBtn.Location = new System.Drawing.Point(215, 0);
            this.maintenanceTypeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maintenanceTypeBtn.Name = "maintenanceTypeBtn";
            this.maintenanceTypeBtn.Size = new System.Drawing.Size(180, 61);
            this.maintenanceTypeBtn.TabIndex = 3;
            this.maintenanceTypeBtn.Text = "Maintenance Types";
            this.maintenanceTypeBtn.Click += new System.EventHandler(this.approvedBtn_Click);
            // 
            // rejectedBtn
            // 
            this.rejectedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rejectedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rejectedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rejectedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rejectedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rejectedBtn.FillColor = System.Drawing.Color.Transparent;
            this.rejectedBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rejectedBtn.Location = new System.Drawing.Point(395, 0);
            this.rejectedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rejectedBtn.Name = "rejectedBtn";
            this.rejectedBtn.Size = new System.Drawing.Size(159, 61);
            this.rejectedBtn.TabIndex = 4;
            this.rejectedBtn.Text = "Bulk Schedule";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Easily manage your vehicle mainenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "Maintenance";
            // 
            // frmMaintenanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 546);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMaintenanceManagement";
            this.Text = "MaintenanceManagement";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel panelBg;
        private Guna.UI2.WinForms.Guna2Panel hr;
        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private Guna.UI2.WinForms.Guna2Button maintenanceTypeBtn;
        private Guna.UI2.WinForms.Guna2Button rejectedBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelSubMain;
    }
}