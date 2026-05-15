using System;
using System.Windows.Forms;
using MediTrack.Data;
using MediTrack.Models;
using MediTrack.Services;
using Microsoft.EntityFrameworkCore;

namespace MediTrack.Forms.MasterFile
{
    public partial class DoctorListForm : Form
    {
        private DoctorService _service = new DoctorService(new Data.AppDbContext());

        public DoctorListForm()
        {
            InitializeComponent();
            Load += DoctorListForm_Load;
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    btnSearch_Click(s, e);
                }
            };
        }

        private void DoctorListForm_Load(object sender, EventArgs e) => LoadDoctors();

        private void LoadDoctors()
        {
            dgvDoctors.DataSource = _service.Search(txtSearch.Text);
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvDoctors.Columns.Count == 0) return;

            dgvDoctors.AutoGenerateColumns = false;
            dgvDoctors.Columns.Clear();

            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "DoctorId", HeaderText = "ID", DataPropertyName = "DoctorId", Width = 50 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "FirstName", HeaderText = "First Name", DataPropertyName = "FirstName", Width = 120 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "LastName", HeaderText = "Last Name", DataPropertyName = "LastName", Width = 120 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "Specialization", HeaderText = "Specialization", DataPropertyName = "Specialization", Width = 150 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "ContactNumber", HeaderText = "Contact", DataPropertyName = "ContactNumber", Width = 120 });
            dgvDoctors.Columns.Add(new DataGridViewCheckBoxColumn()
            { Name = "IsActive", HeaderText = "Active", DataPropertyName = "IsActive", Width = 60 });
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadDoctors();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new DoctorForm();
            if (form.ShowDialog() == DialogResult.OK) LoadDoctors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var doctor = (Doctor)dgvDoctors.SelectedRows[0].DataBoundItem;
            var form = new DoctorForm(doctor);
            if (form.ShowDialog() == DialogResult.OK) LoadDoctors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var doctor = (Doctor)dgvDoctors.SelectedRows[0].DataBoundItem;
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete Dr. {doctor.FirstName} {doctor.LastName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _service.Delete(doctor.DoctorId);
                LoadDoctors();
            }
        }

        private void dgvDoctors_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvDoctors.Rows[e.RowIndex];
            var isActive = row.Cells["IsActive"].Value;
            if (isActive != null && !(bool)isActive)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
        }
    }
}