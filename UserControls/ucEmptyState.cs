using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.UserControls
{
    public partial class ucEmptyState : UserControl
    {
        public event EventHandler ResetClicked;
        public ucEmptyState()
        {
            InitializeComponent();
            SetupUI();
            StartFadeIn();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox iconBox;
        private Guna.UI2.WinForms.Guna2Button btnReset;

        private Timer fadeTimer;
        private int opacity = 0;

        private void SetupUI()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            iconBox = new PictureBox
            {
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.avatar_default
            };

            lblTitle = new Label
            {
                Text = "No data found",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            lblSubtitle = new Label
            {
                Text = "Try adjusting your search or filter.",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnReset = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "Reset Filter",
                AutoSize = true,
                FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191))))),
                ForeColor = Color.White,
                Padding = new Padding(10, 5, 10, 5),
                Cursor = Cursors.Hand,
                BorderRadius = 5
            };

            btnReset.Click += (s, e) => ResetClicked?.Invoke(this, EventArgs.Empty);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 1
            };

            var innerLayout = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true,
                Anchor = AnchorStyles.None
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            layout.Controls.Add(iconBox, 0, 0);
            layout.Controls.Add(lblTitle, 0, 1);
            layout.Controls.Add(lblSubtitle, 0, 2);
            layout.Controls.Add(btnReset, 0, 3);

            innerLayout.Controls.Add(iconBox);
            innerLayout.Controls.Add(lblTitle);
            innerLayout.Controls.Add(lblSubtitle);
            innerLayout.Controls.Add(btnReset);

            layout.Controls.Add(innerLayout, 0, 0);

            layout.SetCellPosition(iconBox, new TableLayoutPanelCellPosition(0, 0));
            iconBox.Anchor = AnchorStyles.None;
            iconBox.Margin = new Padding(0, 0, 0, 10);
            lblTitle.Margin = new Padding(0, 0, 0, 5);
            lblSubtitle.Margin = new Padding(0, 0, 0, 10);
            btnReset.Margin = new Padding(0);
            lblTitle.Anchor = AnchorStyles.None;
            lblSubtitle.Anchor = AnchorStyles.None;
            btnReset.Anchor = AnchorStyles.None;

            this.Controls.Add(layout);
        }

        private void StartFadeIn()
        {
            this.BackColor = Color.White;
            fadeTimer = new Timer { Interval = 15 };

            fadeTimer.Tick += (s, e) =>
            {
                opacity += 10;
                if (opacity >= 255)
                {
                    opacity = 255;
                    fadeTimer.Stop();
                }

                this.ForeColor = Color.FromArgb(opacity, 0, 0, 0);
                this.Invalidate();
            };

            fadeTimer.Start();
        }

        public void SetMessage(string title, string subtitle)
        {
            lblTitle.Text = title;
            lblSubtitle.Text = subtitle;
        }

        public void SetButtonText(string text)
        {
            btnReset.Text = text;
        }

        public void ShowButton(bool show)
        {
            btnReset.Visible = show;
        }

        public void SetIcon(Image image)
        {
            iconBox.Image = image;
        }
    
    }
}
