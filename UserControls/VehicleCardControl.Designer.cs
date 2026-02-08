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
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureVehicle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBoxTransmission = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrentOdometer = new System.Windows.Forms.Label();
            this.labelDailyRate = new System.Windows.Forms.Label();
            this.labelSubHader = new System.Windows.Forms.Label();
            this.labelMainHeader = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(450, 362);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
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
            this.panelBg.Size = new System.Drawing.Size(381, 508);
            this.panelBg.TabIndex = 2;
            // 
            // panelPicture
            // 
            this.panelPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPicture.BorderRadius = 15;
            this.panelPicture.Controls.Add(this.labelStatus);
            this.panelPicture.Controls.Add(this.pictureVehicle);
            this.panelPicture.CustomizableEdges.BottomLeft = false;
            this.panelPicture.CustomizableEdges.BottomRight = false;
            this.panelPicture.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(381, 225);
            this.panelPicture.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(208, 185);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(170, 29);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "label1";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureVehicle
            // 
            this.pictureVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureVehicle.Image = global::VehicleManagementSystem.Properties.Resources.default_car_model;
            this.pictureVehicle.ImageRotate = 0F;
            this.pictureVehicle.Location = new System.Drawing.Point(0, 0);
            this.pictureVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureVehicle.Name = "pictureVehicle";
            this.pictureVehicle.Size = new System.Drawing.Size(381, 225);
            this.pictureVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVehicle.TabIndex = 0;
            this.pictureVehicle.TabStop = false;
            this.pictureVehicle.Click += new System.EventHandler(this.Card_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.labelMainHeader);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel2.Controls.Add(this.labelDailyRate);
            this.guna2Panel2.Controls.Add(this.labelSubHader);
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.CustomizableEdges.TopRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 232);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(381, 276);
            this.guna2Panel2.TabIndex = 2;
            this.guna2Panel2.Click += new System.EventHandler(this.Card_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.pictureBoxTransmission);
            this.guna2GradientPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.labelCurrentOdometer);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(22, 118);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(339, 140);
            this.guna2GradientPanel1.TabIndex = 3;
            this.guna2GradientPanel1.Click += new System.EventHandler(this.Card_Click);
            // 
            // pictureBoxTransmission
            // 
            this.pictureBoxTransmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTransmission.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxTransmission.Image = global::VehicleManagementSystem.Properties.Resources.auto_transmission_icon;
            this.pictureBoxTransmission.ImageRotate = 0F;
            this.pictureBoxTransmission.Location = new System.Drawing.Point(207, 15);
            this.pictureBoxTransmission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTransmission.Name = "pictureBoxTransmission";
            this.pictureBoxTransmission.Size = new System.Drawing.Size(50, 55);
            this.pictureBoxTransmission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTransmission.TabIndex = 6;
            this.pictureBoxTransmission.TabStop = false;
            this.pictureBoxTransmission.Click += new System.EventHandler(this.Card_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::VehicleManagementSystem.Properties.Resources.engine_icon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(263, 15);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(55, 55);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.Card_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Odometer";
            this.label5.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelCurrentOdometer
            // 
            this.labelCurrentOdometer.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOdometer.ForeColor = System.Drawing.Color.White;
            this.labelCurrentOdometer.Location = new System.Drawing.Point(10, 68);
            this.labelCurrentOdometer.Name = "labelCurrentOdometer";
            this.labelCurrentOdometer.Size = new System.Drawing.Size(326, 40);
            this.labelCurrentOdometer.TabIndex = 4;
            this.labelCurrentOdometer.Text = "200.10 Km";
            this.labelCurrentOdometer.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelDailyRate
            // 
            this.labelDailyRate.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyRate.ForeColor = System.Drawing.Color.Gray;
            this.labelDailyRate.Location = new System.Drawing.Point(19, 79);
            this.labelDailyRate.Name = "labelDailyRate";
            this.labelDailyRate.Size = new System.Drawing.Size(342, 24);
            this.labelDailyRate.TabIndex = 2;
            this.labelDailyRate.Text = "₱500/day";
            this.labelDailyRate.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelSubHader
            // 
            this.labelSubHader.AutoEllipsis = true;
            this.labelSubHader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubHader.ForeColor = System.Drawing.Color.Gray;
            this.labelSubHader.Location = new System.Drawing.Point(19, 51);
            this.labelSubHader.Name = "labelSubHader";
            this.labelSubHader.Size = new System.Drawing.Size(342, 24);
            this.labelSubHader.TabIndex = 1;
            this.labelSubHader.Text = "Toyota - Vios 2020";
            this.labelSubHader.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMainHeader.Location = new System.Drawing.Point(16, 11);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(188, 40);
            this.labelMainHeader.TabIndex = 0;
            this.labelMainHeader.Text = "DDS-8080";
            this.labelMainHeader.Click += new System.EventHandler(this.Card_Click);
            // 
            // VehicleCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VehicleCardControl";
            this.Size = new System.Drawing.Size(381, 508);
            this.Click += new System.EventHandler(this.Card_Click);
            this.panelBg.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentOdometer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxTransmission;
        private System.Windows.Forms.Label labelStatus;
    }
}
