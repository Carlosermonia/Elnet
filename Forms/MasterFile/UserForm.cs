using MediTrack.Data;
using MediTrack.Models;

namespace MediTrack.Forms.MasterFile
{
    public partial class UserForm : Form
    {
        private readonly AppDbContext _db = new AppDbContext();
        private User? _existingUser;

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(User user) : this()
        {
            _existingUser = user;
            txtUsername.Text = user.Username;
            cboRole.SelectedItem = user.Role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation");
                return;
            }

            if (_existingUser == null)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is required for new users.", "Validation");
                    return;
                }

                var newUser = new User
                {
                    Username = txtUsername.Text,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text),
                    Role = cboRole.SelectedItem.ToString()!,
                    IsActive = true
                };
                _db.Users.Add(newUser);
            }
            else
            {
                _existingUser.Username = txtUsername.Text;
                _existingUser.Role = cboRole.SelectedItem.ToString()!;
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    _existingUser.PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                _db.Users.Update(_existingUser);
            }

            _db.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}