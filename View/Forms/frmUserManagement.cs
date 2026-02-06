using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Guna.UI2.WinForms;
using VehicleManagementSystem.Classes;
using MySqlConnector;
using VehicleManagementSystem.Data;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();

            dgvRolesPermission.CellPainting -= dgvRolesPermission_CellPainting;
            dgvRolesPermission.CellPainting += dgvRolesPermission_CellPainting;
            dgvRolesPermission.CellClick -= dgvRolesPermission_CellClick;
            dgvRolesPermission.CellClick += dgvRolesPermission_CellClick;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {

            DataGridViewStyle.ApplyStandard(dgvRolesPermission);

            LoadUsers();
            SetupActionsButtons();
            CenterGridHeaders();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadUsers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                conn.Open();

                string query = @"SELECT id AS ID, 
                                        userName AS Username, 
                                        fullName AS FullName,
                                        address AS Address,
                                        role As Role, 
                                        status AS Status
                                FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            dgvRolesPermission.DataSource = dt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvRolesPermission_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name != "Status")
                return;

            if (e.Value == null)
                return;

            string status = e.Value.ToString();

            switch (status)
            {
                case "Active":
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(dgvRolesPermission.Font, FontStyle.Bold);
                    break;

                case "Inactive":
                    e.CellStyle.ForeColor = Color.Red;
                    break;

                case "Suspended":
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    break;
            }
        }

        private void CenterGridHeaders()
        {
            dgvRolesPermission.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvRolesPermission.EnableHeadersVisualStyles = false;
        }

        private void SetupActionsButtons()
        {
            if (dgvRolesPermission.Columns["Actions"] == null)
            {
                DataGridViewTextBoxColumn actionsCol = new DataGridViewTextBoxColumn();
                actionsCol.Name = "Actions";
                actionsCol.HeaderText = "Actions";
                actionsCol.ReadOnly = true;
                actionsCol.Width = 150;
                actionsCol.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvRolesPermission.Columns.Add(actionsCol);
            }
        }

        private void dgvRolesPermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name == "Actions")
            {
                var cell = dgvRolesPermission.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int padding = 5;
                int buttonWidth = (cell.Width - 3 * padding) / 2;

                Point clickPoint = dgvRolesPermission.PointToClient(Cursor.Position);
                int relativeX = clickPoint.X - cell.Left;

                if (relativeX <= buttonWidth)
                {
                    MessageBox.Show($"Edit clicked for row {e.RowIndex}");
                }
                else
                {
                    MessageBox.Show($"Delete clicked for row {e.RowIndex}");
                }
            }
        }


        private void dgvRolesPermission_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name == "Actions")
            {
                e.PaintBackground(e.ClipBounds, true);

                int padding = 5;
                int buttonWidth = (e.CellBounds.Width - 3 * padding) / 2;
                int buttonHeight = e.CellBounds.Height - 2 * padding;

                Rectangle editButton = new Rectangle(e.CellBounds.Left + padding, e.CellBounds.Top + padding, buttonWidth, buttonHeight);
                Rectangle deleteButton = new Rectangle(e.CellBounds.Left + buttonWidth + 2 * padding, e.CellBounds.Top + padding, buttonWidth, buttonHeight);

                Color editColor = Color.FromArgb(94, 148, 255);
                Color deleteColor = Color.FromArgb(255, 77, 79);

                using (SolidBrush editBrush = new SolidBrush(editColor))
                    e.Graphics.FillRectangle(editBrush, editButton);

                using (SolidBrush deleteBrush = new SolidBrush(deleteColor))
                    e.Graphics.FillRectangle(deleteBrush, deleteButton);

               Image editIcon = VehicleManagementSystem.Properties.Resources.square_pen;
                int ex = editButton.Left + (editButton.Width - editIcon.Width) / 2;
                int ey = editButton.Top + (editButton.Height - editIcon.Height) / 2;
                e.Graphics.DrawImage(editIcon, new Rectangle(ex, ey, editIcon.Width, editIcon.Height));

                Image deleteIcon = VehicleManagementSystem.Properties.Resources.trash;
                int dx = deleteButton.Left + (deleteButton.Width - deleteIcon.Width) / 2;
                int dy = deleteButton.Top + (deleteButton.Height - deleteIcon.Height) / 2;
                e.Graphics.DrawImage(deleteIcon, new Rectangle(dx, dy, deleteIcon.Width, deleteIcon.Height));

                e.Handled = true;
            }
        }



        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void roleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void userManagementTab_Click(object sender, EventArgs e)
        {

        }

        private void totalUserData_Click(object sender, EventArgs e)
        {

        }

        private void totalUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void activeUserData_Click(object sender, EventArgs e)
        {

        }

        private void activeUserData_Click_1(object sender, EventArgs e)
        {

        }

        private void activeUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void dgvRolesPermission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRolesPermission_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();

            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnUserForm_Click_1(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();

            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }


        // Double buffer
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
