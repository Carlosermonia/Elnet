using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediTrack.Data;
using MediTrack.Models;
using MediTrack.Services;

namespace MediTrack.Forms.Transactions
{
    public partial class AppointmentForm : Form
    {
        private Appointment _appointment = null!;
        private AppointmentService _service = null!;

        public AppointmentForm() : this(null) { }

        public AppointmentForm(Appointment? appointment)
        {
            InitializeComponent();
            _service = new AppointmentService(new Data.AppDbContext());
            _appointment = appointment ?? new Appointment();
            LoadDropdowns();
            LoadValues();
        }

        private void LoadDropdowns()
        {
            using (var db = new Data.AppDbContext())
            {
                // Load patients
                var patients = db.Patients
                    .OrderBy(p => p.LastName)
                    .ToList();
                cboPatient.DataSource = patients;
                cboPatient.DisplayMember = "LastName";
                cboPatient.ValueMember = "PatientId";

                // Load active doctors only
                var doctors = db.Doctors
                    .Where(d => d.IsActive)
                    .OrderBy(d => d.LastName)
                    .ToList();
                cboDoctor.DataSource = doctors;
                cboDoctor.DisplayMember = "LastName";
                cboDoctor.ValueMember = "DoctorId";
            }

            // Load time slots 8AM to 5PM every 30 mins
            cboTimeSlot.Items.Clear();
            for (int h = 8; h <= 17; h++)
            {
                cboTimeSlot.Items.Add(new TimeSlotItem(new TimeSpan(h, 0, 0)));
                if (h < 17)
                    cboTimeSlot.Items.Add(new TimeSlotItem(new TimeSpan(h, 30, 0)));
            }

            // Load status options
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[]
            {
                "Scheduled", "Completed", "Cancelled", "No-Show"
            });
            cboStatus.SelectedIndex = 0;
        }

        private void LoadValues()
        {
            if (_appointment.AppointmentId == 0)
            {
                // New appointment defaults
                dtpDate.Value = DateTime.Today;
                cboStatus.SelectedItem = "Scheduled";
                return;
            }

            // Edit existing appointment
            dtpDate.Value = _appointment.AppointmentDate;
            cboStatus.SelectedItem = _appointment.Status;
            nudFee.Value = _appointment.ConsultationFee;
            txtNotes.Text = _appointment.Notes ?? string.Empty;

            // Set patient
            foreach (Patient p in cboPatient.Items)
            {
                if (p.PatientId == _appointment.PatientId)
                {
                    cboPatient.SelectedItem = p;
                    break;
                }
            }

            // Set doctor
            foreach (Doctor d in cboDoctor.Items)
            {
                if (d.DoctorId == _appointment.DoctorId)
                {
                    cboDoctor.SelectedItem = d;
                    break;
                }
            }

            // Set time slot
            foreach (TimeSlotItem t in cboTimeSlot.Items)
            {
                if (t.Value == _appointment.TimeSlot)
                {
                    cboTimeSlot.SelectedItem = t;
                    break;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validation
            if (cboPatient.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDoctor.SelectedItem == null)
            {
                MessageBox.Show("Please select a doctor.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTimeSlot.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPatient = (Patient)cboPatient.SelectedItem;
            var selectedDoctor = (Doctor)cboDoctor.SelectedItem;
            var selectedTimeSlot = (TimeSlotItem)cboTimeSlot.SelectedItem;

            // Check for conflict
            if (_service.HasConflict(
                selectedDoctor.DoctorId,
                dtpDate.Value,
                selectedTimeSlot.Value,
                _appointment.AppointmentId == 0 ? null : _appointment.AppointmentId))
            {
                lblConflict.Visible = true;
                lblConflict.Text = "This doctor already has an appointment at that time!";
                return;
            }

            lblConflict.Visible = false;

            // Map values
            _appointment.PatientId = selectedPatient.PatientId;
            _appointment.DoctorId = selectedDoctor.DoctorId;
            _appointment.AppointmentDate = dtpDate.Value.Date;
            _appointment.TimeSlot = selectedTimeSlot.Value;
            _appointment.Status = cboStatus.SelectedItem?.ToString() ?? "Scheduled";
            _appointment.ConsultationFee = nudFee.Value;
            _appointment.Notes = txtNotes.Text.Trim();

            // Save to database
            using (var db = new Data.AppDbContext())
            {
                if (_appointment.AppointmentId == 0)
                {
                    db.Appointments.Add(_appointment);
                }
                else
                {
                    var existing = db.Appointments.Find(_appointment.AppointmentId);
                    if (existing != null)
                    {
                        existing.PatientId = _appointment.PatientId;
                        existing.DoctorId = _appointment.DoctorId;
                        existing.AppointmentDate = _appointment.AppointmentDate;
                        existing.TimeSlot = _appointment.TimeSlot;
                        existing.Status = _appointment.Status;
                        existing.ConsultationFee = _appointment.ConsultationFee;
                        existing.Notes = _appointment.Notes;
                        db.Appointments.Update(existing);
                    }
                }
                db.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    // Helper class for time slot display
    public class TimeSlotItem
    {
        public TimeSpan Value { get; }
        public TimeSlotItem(TimeSpan value) { Value = value; }
        public override string ToString()
        {
            var dt = DateTime.Today.Add(Value);
            return dt.ToString("hh:mm tt"); // e.g. 08:00 AM
        }
    }
}