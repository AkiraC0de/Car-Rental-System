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
            this.hr = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNav = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.approvedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.rejectedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.completedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSubMain = new Guna.UI2.WinForms.Guna2Panel();
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
            this.panelNav.Controls.Add(this.approvedBtn);
            this.panelNav.Controls.Add(this.rejectedBtn);
            this.panelNav.Controls.Add(this.completedBtn);
            this.panelNav.Location = new System.Drawing.Point(376, 25);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(685, 61);
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
            this.dashboardBtn.Location = new System.Drawing.Point(22, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(159, 61);
            this.dashboardBtn.TabIndex = 5;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // approvedBtn
            // 
            this.approvedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.approvedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.approvedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.approvedBtn.FillColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.approvedBtn.Location = new System.Drawing.Point(181, 0);
            this.approvedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approvedBtn.Name = "approvedBtn";
            this.approvedBtn.Size = new System.Drawing.Size(180, 61);
            this.approvedBtn.TabIndex = 3;
            this.approvedBtn.Text = "Maintenance Types";
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
            this.rejectedBtn.Location = new System.Drawing.Point(361, 0);
            this.rejectedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rejectedBtn.Name = "rejectedBtn";
            this.rejectedBtn.Size = new System.Drawing.Size(159, 61);
            this.rejectedBtn.TabIndex = 4;
            this.rejectedBtn.Text = "Bulk Schedule";
            // 
            // completedBtn
            // 
            this.completedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.completedBtn.FillColor = System.Drawing.Color.Transparent;
            this.completedBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.completedBtn.Location = new System.Drawing.Point(520, 0);
            this.completedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.Size = new System.Drawing.Size(165, 61);
            this.completedBtn.TabIndex = 4;
            this.completedBtn.Text = "Calendar";
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
            // panelSubMain
            // 
            this.panelSubMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubMain.Location = new System.Drawing.Point(14, 106);
            this.panelSubMain.Name = "panelSubMain";
            this.panelSubMain.Size = new System.Drawing.Size(1047, 624);
            this.panelSubMain.TabIndex = 52;
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
        private Guna.UI2.WinForms.Guna2Button approvedBtn;
        private Guna.UI2.WinForms.Guna2Button rejectedBtn;
        private Guna.UI2.WinForms.Guna2Button completedBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelSubMain;
    }
}