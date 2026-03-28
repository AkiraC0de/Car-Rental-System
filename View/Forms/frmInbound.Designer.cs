namespace VehicleManagementSystem.View.Forms {
    partial class frmInbound {
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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.searchBox);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.bookingListPanel);
            this.panelMain.Controls.Add(this.panelLoading);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.Location = new System.Drawing.Point(1, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1130, 546);
            this.panelMain.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Manage post-rental inspection and finalizing transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 35);
            this.label3.TabIndex = 39;
            this.label3.Text = "Inbound units";
            // 
            // bookingListPanel
            // 
            this.bookingListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookingListPanel.BackColor = System.Drawing.Color.Transparent;
            this.bookingListPanel.Location = new System.Drawing.Point(32, 100);
            this.bookingListPanel.Name = "bookingListPanel";
            this.bookingListPanel.Size = new System.Drawing.Size(1065, 446);
            this.bookingListPanel.TabIndex = 38;
            // 
            // panelLoading
            // 
            this.panelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoading.Location = new System.Drawing.Point(10, 104);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(1120, 388);
            this.panelLoading.TabIndex = 41;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BorderRadius = 10;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.DimGray;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.IconRight = global::VehicleManagementSystem.Properties.Resources.magnifying_glass;
            this.searchBox.IconRightOffset = new System.Drawing.Point(10, 0);
            this.searchBox.IconRightSize = new System.Drawing.Size(25, 25);
            this.searchBox.Location = new System.Drawing.Point(743, 24);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(354, 48);
            this.searchBox.TabIndex = 44;
            this.searchBox.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmInbound
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1132, 546);
            this.Controls.Add(this.panelMain);
            this.Name = "frmInbound";
            this.Text = "frmInbound";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel bookingListPanel;
        private Guna.UI2.WinForms.Guna2Panel panelLoading;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}