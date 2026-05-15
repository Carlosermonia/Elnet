using System;
using System.Windows.Forms;
using MediTrack.Data;
using MediTrack.Services;
using MediTrack.Models;

namespace MediTrack.Forms.MasterFile
{
    public partial class PatientListForm : Form
    {
        private PatientService _service = new PatientService(new Data.AppDbContext());

        public PatientListForm()
        {
            InitializeComponent();
            Load += PatientListForm_Load;
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    LoadPatients();
            };
        }

        private void PatientListForm_Load(object sender, EventArgs e) => LoadPatients();

        private void LoadPatients()
        {
            dgvPatients.DataSource = _service.Search(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadPatients();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new PatientForm(); // Add/Edit form
            if (form.ShowDialog() == DialogResult.OK) LoadPatients();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;
            var patient = (MediTrack.Models.Patient)dgvPatients.SelectedRows[0].DataBoundItem;
            var form = new PatientForm(patient);
            if (form.ShowDialog() == DialogResult.OK) LoadPatients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;
            var patient = (Patient)dgvPatients.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Delete this patient?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Delete(patient.PatientId);
                LoadPatients();
            }
        }
    }
}