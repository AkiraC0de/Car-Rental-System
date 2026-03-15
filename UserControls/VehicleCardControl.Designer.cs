using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.UserControls {
    partial class VehicleCardControl {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelPicture = new Guna.UI2.WinForms.Guna2Panel();
            this.panelStatusColor = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureVehicle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelMainHeader = new System.Windows.Forms.Label();
            this.labelDailyRate = new System.Windows.Forms.Label();
            this.labelSubHader = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.panelPicture.SuspendLayout();
            this.panelStatusColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(400, 290);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(7, 6);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelBg
            // 
            this.panelBg.BorderRadius = 15;
            this.panelBg.Controls.Add(this.panelPicture);
            this.panelBg.Controls.Add(this.guna2Panel2);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.White;
            this.panelBg.FillColor2 = System.Drawing.Color.White;
            this.panelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(494, 285);
            this.panelBg.TabIndex = 2;
            // 
            // panelPicture
            // 
            this.panelPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPicture.BorderRadius = 15;
            this.panelPicture.Controls.Add(this.panelStatusColor);
            this.panelPicture.Controls.Add(this.pictureVehicle);
            this.panelPicture.CustomizableEdges.BottomLeft = false;
            this.panelPicture.CustomizableEdges.BottomRight = false;
            this.panelPicture.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelPicture.Location = new System.Drawing.Point(0, 2);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(494, 216);
            this.panelPicture.TabIndex = 3;
            // 
            // panelStatusColor
            // 
            this.panelStatusColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatusColor.AutoSize = true;
            this.panelStatusColor.BorderRadius = 5;
            this.panelStatusColor.Controls.Add(this.labelStatus);
            this.panelStatusColor.FillColor = System.Drawing.Color.Green;
            this.panelStatusColor.Location = new System.Drawing.Point(413, 12);
            this.panelStatusColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStatusColor.Name = "panelStatusColor";
            this.panelStatusColor.Size = new System.Drawing.Size(81, 23);
            this.panelStatusColor.TabIndex = 1;
            // 
            // pictureVehicle
            // 
            this.pictureVehicle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureVehicle.FillColor = System.Drawing.Color.Transparent;
            this.pictureVehicle.Image = global::VehicleManagementSystem.Properties.Resources.default_car_model;
            this.pictureVehicle.ImageRotate = 0F;
            this.pictureVehicle.Location = new System.Drawing.Point(0, 24);
            this.pictureVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureVehicle.Name = "pictureVehicle";
            this.pictureVehicle.Size = new System.Drawing.Size(494, 192);
            this.pictureVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVehicle.TabIndex = 0;
            this.pictureVehicle.TabStop = false;
            this.pictureVehicle.Click += new System.EventHandler(this.Card_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.labelMainHeader);
            this.guna2Panel2.Controls.Add(this.labelDailyRate);
            this.guna2Panel2.Controls.Add(this.labelSubHader);
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.CustomizableEdges.TopRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 211);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(494, 74);
            this.guna2Panel2.TabIndex = 2;
            this.guna2Panel2.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMainHeader.Location = new System.Drawing.Point(14, 9);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(167, 32);
            this.labelMainHeader.TabIndex = 0;
            this.labelMainHeader.Text = "DDS-8080";
            this.labelMainHeader.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelDailyRate
            // 
            this.labelDailyRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDailyRate.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyRate.ForeColor = System.Drawing.Color.Gray;
            this.labelDailyRate.Location = new System.Drawing.Point(336, 9);
            this.labelDailyRate.Name = "labelDailyRate";
            this.labelDailyRate.Size = new System.Drawing.Size(144, 25);
            this.labelDailyRate.TabIndex = 2;
            this.labelDailyRate.Text = "₱500/day";
            this.labelDailyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDailyRate.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelSubHader
            // 
            this.labelSubHader.AutoEllipsis = true;
            this.labelSubHader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubHader.ForeColor = System.Drawing.Color.Gray;
            this.labelSubHader.Location = new System.Drawing.Point(15, 41);
            this.labelSubHader.Name = "labelSubHader";
            this.labelSubHader.Size = new System.Drawing.Size(304, 19);
            this.labelSubHader.TabIndex = 1;
            this.labelSubHader.Text = "Toyota - Vios 2020";
            this.labelSubHader.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 23);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "₱500/day";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VehicleCardControl";
            this.Size = new System.Drawing.Size(494, 285);
            this.Click += new System.EventHandler(this.Card_Click);
            this.panelBg.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            this.panelStatusColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelPicture;
        private Guna.UI2.WinForms.Guna2PictureBox pictureVehicle;
        private System.Windows.Forms.Label labelMainHeader;
        private System.Windows.Forms.Label labelDailyRate;
        private System.Windows.Forms.Label labelSubHader;
        private Guna.UI2.WinForms.Guna2Panel panelStatusColor;
        private System.Windows.Forms.Label labelStatus;
    }
}
