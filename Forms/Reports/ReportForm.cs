using Microsoft.EntityFrameworkCore;
using MediTrack.Data;

namespace MediTrack.Forms.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date;

            var data = db.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .Where(a => a.AppointmentDate.Date >= fromDate && a.AppointmentDate.Date <= toDate)
                .ToList()
                .Select(a => new {
                    Date = a.AppointmentDate.ToString("MM/dd/yyyy"),
                    Time = a.TimeSlot.ToString(),
                    Patient = a.Patient.LastName + ", " + a.Patient.FirstName,
                    Doctor = "Dr. " + a.Doctor.LastName,
                    a.Status,
                    Fee = a.ConsultationFee.ToString("C"),
                    a.Notes
                }).ToList();

            dgvReport.DataSource = data;
            lblCount.Text = $"Total Records: {data.Count}";
        }
    }
}