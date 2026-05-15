using System;
using System.Windows.Forms;
using MediTrack.Data;
using MediTrack.Models;

namespace MediTrack.Forms.MasterFile
{
    public partial class PatientForm : Form
    {
        private Patient _patient = null!;

        public PatientForm() : this(null) { }

        public PatientForm(Patient? patient)
        {
            _patient = patient ?? new Patient();

            // Replaces BuildUI()
            InitializeComponent();

            LoadValues();
        }

        private void LoadValues()
        {
            txtFirstName.Text = _patient.FirstName ?? string.Empty;
            txtLastName.Text = _patient.LastName ?? string.Empty;
            dtpDOB.Value = _patient.DateOfBirth == default ? DateTime.Today : _patient.DateOfBirth;
            txtGender.Text = _patient.Gender ?? string.Empty;
            txtPhone.Text = _patient.ContactNumber ?? string.Empty;
            txtEmail.Text = _patient.Email ?? string.Empty;
            txtAddress.Text = _patient.Address ?? string.Empty;
            txtMedicalHistory.Text = _patient.MedicalHistory ?? string.Empty;
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

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Contact number is required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _patient.FirstName = txtFirstName.Text.Trim();
            _patient.LastName = txtLastName.Text.Trim();
            _patient.DateOfBirth = dtpDOB.Value;
            _patient.Gender = txtGender.Text.Trim();
            _patient.ContactNumber = txtPhone.Text.Trim();
            _patient.Email = txtEmail.Text.Trim();
            _patient.Address = txtAddress.Text.Trim();
            _patient.MedicalHistory = txtMedicalHistory.Text.Trim();
            _patient.CreatedAt = _patient.PatientId == 0 ? DateTime.Now : _patient.CreatedAt;

            using (var db = new AppDbContext())
            {
                if (_patient.PatientId == 0)
                    db.Patients.Add(_patient);
                else
                    db.Patients.Update(_patient);

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}