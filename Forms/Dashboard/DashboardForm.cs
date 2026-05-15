using MediTrack.Data;
using MediTrack.Forms.MasterFile;
using MediTrack.Forms.Reports;
using MediTrack.Services;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace MediTrack.Forms.Dashboard
{
    public partial class DashboardForm : Form
    {
        private readonly AuthService? _authService;

        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(AuthService authService) : this()
        {
            _authService = authService;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            btnLogout.Location = new System.Drawing.Point(pnlTopBar.Width - btnLogout.Width - 15, 15);
            LoadDashboardStats();
            ApplyRolePermissions();
            ShowTodayNotifications();
        }

        private void LoadForm(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }

        private void LoadDashboardStats()
        {
            var db = new AppDbContext();
            var today = DateTime.Today;
            lblTotalPatients.Text = db.Patients.Count().ToString();
            lblTodayAppointments.Text = db.Appointments
                .Count(a => a.AppointmentDate.Date == today).ToString();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new PatientListForm());
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new DoctorListForm());
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new MediTrack.Forms.Transactions.AppointmentListForm());
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ReportForm());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _authService?.Logout();
            this.Close();
            new MediTrack.Forms.Auth.LoginForm().Show();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new UserListForm()); 
        }

        private void ApplyRolePermissions()
        {
            if (_authService == null) return;

            var role = _authService.CurrentUser?.Role;

            switch (role)
            {
                case "Admin":
                    // sees everything, no restrictions
                    break;

                case "Receptionist":
                    settingsToolStripMenuItem.Visible = false;
                    break;

                case "Doctor":
                    masterFilesToolStripMenuItem.Visible = false;
                    settingsToolStripMenuItem.Visible = false;
                    break;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authService?.Logout();
            this.Close();
            new MediTrack.Forms.Auth.LoginForm().Show();
        }
        private void ShowTodayNotifications()
        {
            var db = new AppDbContext();
            var todayAppts = db.Appointments
                .Include(a => a.Patient)
                .Where(a => a.AppointmentDate.Date == DateTime.Today && a.Status == "Scheduled")
                .ToList();

            if (todayAppts.Any())
            {
                var message = $"You have {todayAppts.Count} appointment(s) today:\n\n";
                foreach (var appt in todayAppts)
                    message += $"• {appt.Patient?.FirstName} {appt.Patient?.LastName} at {appt.TimeSlot}\n";

                MessageBox.Show(message, "Today's Schedule",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}