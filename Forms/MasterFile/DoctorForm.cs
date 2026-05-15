using System;
using System.Windows.Forms;
using MediTrack.Data;
using MediTrack.Models;

namespace MediTrack.Forms.MasterFile
{
    public partial class DoctorForm : Form
    {
        private Doctor _doctor = null!;

        public DoctorForm() : this(null) { }

        public DoctorForm(Doctor? doctor)
        {
            _doctor = doctor ?? new Doctor { IsActive = true };

            // Replaces BuildUI()
            InitializeComponent();

            LoadValues();
        }

        private void LoadValues()
        {
            txtFirstName.Text = _doctor.FirstName ?? string.Empty;
            txtLastName.Text = _doctor.LastName ?? string.Empty;
            txtSpecialization.Text = _doctor.Specialization ?? string.Empty;
            txtPhone.Text = _doctor.ContactNumber ?? string.Empty;
            txtEmail.Text = _doctor.Email ?? string.Empty;
            chkIsActive.Checked = _doctor.IsActive;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First name and last name are required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Specialization is required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _doctor.FirstName = txtFirstName.Text.Trim();
            _doctor.LastName = txtLastName.Text.Trim();
            _doctor.Specialization = txtSpecialization.Text.Trim();
            _doctor.ContactNumber = txtPhone.Text.Trim();
            _doctor.Email = txtEmail.Text.Trim();
            _doctor.IsActive = chkIsActive.Checked;

            using (var db = new AppDbContext())
            {
                if (_doctor.DoctorId == 0)
                    db.Doctors.Add(_doctor);
                else
                    db.Doctors.Update(_doctor);

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}