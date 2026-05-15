using System;
using System.Linq;
using System.Windows.Forms;
using MediTrack.Data;
using MediTrack.Models;
using MediTrack.Services;
using Microsoft.EntityFrameworkCore;

namespace MediTrack.Forms.Transactions
{
    public partial class AppointmentListForm : Form
    {
        private AppointmentService _service = null!;

        public AppointmentListForm()
        {
            InitializeComponent();
            _service = new AppointmentService(new Data.AppDbContext());
            Load += AppointmentListForm_Load;
        }

        private void AppointmentListForm_Load(object sender, EventArgs e) => LoadAppointments();

        private void LoadAppointments()
        {
            var freshService = new AppointmentService(new AppDbContext());

            var raw = freshService.GetAll();

            var data = raw
                .Where(a => !chkFilterDate.Checked || a.AppointmentDate.Date == dtpFilter.Value.Date)
                .Where(a => cboFilterStatus.SelectedIndex == 0 || a.Status == cboFilterStatus.SelectedItem?.ToString())
                .Select(a => new
                {
                    a.AppointmentId,
                    PatientName = a.Patient?.LastName + ", " + a.Patient?.FirstName,
                    DoctorName = "Dr. " + a.Doctor?.LastName,
                    AppointmentDate = a.AppointmentDate.ToString("MM/dd/yyyy"),
                    TimeSlot = a.TimeSlot.ToString(@"hh\:mm"),
                    a.Status,
                    a.ConsultationFee
                }).ToList();

            dgvAppointments.DataSource = null;
            dgvAppointments.DataSource = data;
            FormatGrid();
            ColorCodeRows();
        }

        private void FormatGrid()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.Columns.Clear();

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "AppointmentId", HeaderText = "ID", DataPropertyName = "AppointmentId", Width = 45 });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PatientName",
                HeaderText = "Patient",
                Width = 140,
                DataPropertyName = "PatientName"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DoctorName",
                HeaderText = "Doctor",
                Width = 140,
                DataPropertyName = "DoctorName"
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "AppointmentDate", HeaderText = "Date", DataPropertyName = "AppointmentDate", Width = 90 });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "TimeSlot", HeaderText = "Time", DataPropertyName = "TimeSlot", Width = 70 });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", Width = 90 });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "ConsultationFee", HeaderText = "Fee (₱)", DataPropertyName = "ConsultationFee", Width = 80 });
        }

        private void ColorCodeRows()
        {
            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                var status = row.Cells["Status"].Value?.ToString();
                switch (status)
                {
                    case "Scheduled":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
                        break;
                    case "Completed":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen;
                        break;
                    case "Cancelled":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
                        break;
                    case "No-Show":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadAppointments();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AppointmentForm();
            if (form.ShowDialog() == DialogResult.OK) LoadAppointments();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value;

            using (var db = new AppDbContext())
            {
                var appt = db.Appointments
                    .Include(a => a.Patient)
                    .Include(a => a.Doctor)
                    .FirstOrDefault(a => a.AppointmentId == id);

                if (appt == null) return;

                var form = new AppointmentForm(appt);
                form.ShowDialog();
            }

            LoadAppointments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value;
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    var existing = db.Appointments.Find(id);
                    if (existing != null)
                    {
                        db.Appointments.Remove(existing);
                        db.SaveChanges();
                    }
                }
                LoadAppointments();
            }
        }

        private void chkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilter.Enabled = chkFilterDate.Checked;
            LoadAppointments();
        }

        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
            => LoadAppointments();

        private void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            if (chkFilterDate.Checked) LoadAppointments();
        }
    }
}