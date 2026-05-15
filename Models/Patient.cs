namespace MediTrack.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MedicalHistory { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}