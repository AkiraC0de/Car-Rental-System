namespace VehicleManagementSystem.UserControls {
    partial class MaintenanceCardControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelMaintenanceType = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.progressCIrcle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDueOdometer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaintenanceType
            // 
            this.labelMaintenanceType.AutoSize = true;
            this.labelMaintenanceType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaintenanceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.labelMaintenanceType.Location = new System.Drawing.Point(16, 16);
            this.labelMaintenanceType.Name = "labelMaintenanceType";
            this.labelMaintenanceType.Size = new System.Drawing.Size(228, 29);
            this.labelMaintenanceType.TabIndex = 41;
            this.labelMaintenanceType.Text = "Change Engine Oil";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.BackColor = System.Drawing.Color.Transparent;
            this.labelInterval.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterval.ForeColor = System.Drawing.Color.Gray;
            this.labelInterval.Location = new System.Drawing.Point(17, 45);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(228, 21);
            this.labelInterval.TabIndex = 42;
            this.labelInterval.Text = "Every 5000 km or 3 months";
            // 
            // progressCIrcle
            // 
            this.progressCIrcle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressCIrcle.FillColor = System.Drawing.Color.LightGray;
            this.progressCIrcle.FillThickness = 6;
            this.progressCIrcle.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressCIrcle.ForeColor = System.Drawing.Color.DimGray;
            this.progressCIrcle.Location = new System.Drawing.Point(293, 97);
            this.progressCIrcle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressCIrcle.Minimum = 0;
            this.progressCIrcle.Name = "progressCIrcle";
            this.progressCIrcle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.progressCIrcle.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressCIrcle.ProgressThickness = 10;
            this.progressCIrcle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressCIrcle.Size = new System.Drawing.Size(112, 112);
            this.progressCIrcle.TabIndex = 43;
            this.progressCIrcle.Text = "guna2CircleProgressBar2";
            this.progressCIrcle.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.progressCIrcle.Value = 50;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.labelStatus);
            this.guna2Panel1.Controls.Add(this.labelDueDate);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.labelDueOdometer);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.progressCIrcle);
            this.guna2Panel1.Controls.Add(this.labelInterval);
            this.guna2Panel1.Controls.Add(this.labelMaintenanceType);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(423, 227);
            this.guna2Panel1.TabIndex = 42;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDueDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDueDate.Location = new System.Drawing.Point(17, 118);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(71, 24);
            this.labelDueDate.TabIndex = 47;
            this.labelDueDate.Text = "236km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Duedate";
            // 
            // labelDueOdometer
            // 
            this.labelDueOdometer.AutoSize = true;
            this.labelDueOdometer.BackColor = System.Drawing.Color.Transparent;
            this.labelDueOdometer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueOdometer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDueOdometer.Location = new System.Drawing.Point(17, 183);
            this.labelDueOdometer.Name = "labelDueOdometer";
            this.labelDueOdometer.Size = new System.Drawing.Size(221, 24);
            this.labelDueOdometer.TabIndex = 45;
            this.labelDueOdometer.Text = "in 236km (at 12000km)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Due Odomter";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.BackColor = System.Drawing.Color.White;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStatus.Location = new System.Drawing.Point(278, 16);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(127, 29);
            this.labelStatus.TabIndex = 48;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaintenanceCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "MaintenanceCardControl";
            this.Size = new System.Drawing.Size(423, 227);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMaintenanceType;
        private System.Windows.Forms.Label labelInterval;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressCIrcle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDueOdometer;
        private System.Windows.Forms.Label labelStatus;
    }
}
