using MediTrack.Data;
using MediTrack.Models;


namespace MediTrack.Forms.MasterFile
{
    public partial class UserListForm : Form
    {
        private readonly AppDbContext _db = new AppDbContext();

        public UserListForm()
        {
            InitializeComponent();
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    LoadUsers(txtSearch.Text);
            };
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers(string keyword = "")
        {
            var users = new AppDbContext().Users
                .Where(u => string.IsNullOrWhiteSpace(keyword) ||
                       u.Username.ToLower().Contains(keyword.ToLower()) ||
                       u.Role.ToLower().Contains(keyword.ToLower()))
                .Select(u => new {
                    u.UserId,
                    u.Username,
                    u.Role,
                    Status = u.IsActive ? "Active" : "Inactive"
                }).ToList();

            dgvUsers.DataSource = users;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User account created successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;
            int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
            var user = new AppDbContext().Users.Find(userId);
            if (user == null) return;
            var form = new UserForm(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User account updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;
            int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
            var db = new AppDbContext();
            var user = db.Users.Find(userId);
            if (user == null) return;
            if (MessageBox.Show($"Deactivate user '{user.Username}'?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                user.IsActive = false;
                db.SaveChanges();
                MessageBox.Show("User deactivated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString()!;

            if (username == "admin")
            {
                MessageBox.Show("The admin account cannot be deleted.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete user '{username}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var db = new AppDbContext();
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("User deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
            }
        }
    }
}