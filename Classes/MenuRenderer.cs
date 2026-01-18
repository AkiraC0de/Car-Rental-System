using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.Classes {
    public class MenuRenderer {
        private IconButton currentBtn;
        private Guna2GradientPanel leftBorder;

        public MenuRenderer(Panel menuPanel) {
            leftBorder = new Guna2GradientPanel {
                Size = new Size(10, 85),
                BorderRadius = 10,
                FillColor = UIConfig.Theme.Primary,
                FillColor2 = UIConfig.Theme.Primary,
                BackColor = Color.Transparent
            };
            leftBorder.CustomizableEdges.TopLeft = false;
            leftBorder.CustomizableEdges.BottomLeft = false;
            menuPanel.Controls.Add(leftBorder);
            leftBorder.Visible = false;
        }

        public void ActivateButton(object senderBtn) {
            if (senderBtn != null) {
                DeactiveButton();
                currentBtn = senderBtn as IconButton;
                currentBtn.IconSize = 60;
                currentBtn.ForeColor = UIConfig.Theme.Primary;
                currentBtn.IconColor = UIConfig.Theme.Primary;

                leftBorder.Location = new Point(0, currentBtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
            }
        }

        private void DeactiveButton() {
            if (currentBtn != null) {
                //RemoveHeaderLabel();
                currentBtn.IconSize = 50;
                currentBtn.ForeColor = UIConfig.Theme.SecondaryText;
                currentBtn.IconColor = UIConfig.Theme.SecondaryText;
            }
        }
    }
}
