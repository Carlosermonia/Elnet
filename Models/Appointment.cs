namespace MediTrack.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan TimeSlot { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public decimal ConsultationFee { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}