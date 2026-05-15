using MediTrack.Data;
using MediTrack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack.Services
{
    public class AppointmentService
    {
        private readonly Data.AppDbContext _db;
        public AppointmentService(Data.AppDbContext db) { _db = db; }

        public bool HasConflict(int doctorId, DateTime date, TimeSpan timeSlot, int? excludeId = null)
        {
            return _db.Appointments.Any(a =>
                a.DoctorId == doctorId &&
                a.AppointmentDate.Date == date.Date &&
                a.TimeSlot == timeSlot &&
                a.Status != "Cancelled" &&
                a.AppointmentId != excludeId);
        }

        public bool Book(Appointment appointment)
        {
            if (HasConflict(appointment.DoctorId, appointment.AppointmentDate, appointment.TimeSlot))
                return false;
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return true;
        }

        public List<Appointment> GetAll()
        {
            return _db.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .ToList();
        }
    }
}
