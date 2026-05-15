using MediTrack.Data;
using MediTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack.Services
{
    public class DoctorService
    {
        private readonly Data.AppDbContext _db;
        public DoctorService(Data.AppDbContext db) { _db = db; }

        public void Add(Doctor d) { _db.Doctors.Add(d); _db.SaveChanges(); }

        public void Update(Doctor d) { _db.Doctors.Update(d); _db.SaveChanges(); }

        public void Delete(int id)
        {
            var d = _db.Doctors.Find(id);
            if (d != null) { _db.Doctors.Remove(d); _db.SaveChanges(); }
        }

        public List<Doctor> Search(string keyword)
        {
            return _db.Doctors.Where(d =>
                d.FirstName.Contains(keyword) || d.LastName.Contains(keyword))
                .ToList();
        }
    }
}