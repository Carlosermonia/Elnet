using MediTrack.Data;
using MediTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack.Services
{
    public class PatientService
    {
        private readonly Data.AppDbContext _db;
        public PatientService(Data.AppDbContext db) { _db = db; }

        public void Add(Patient p) { _db.Patients.Add(p); _db.SaveChanges(); }
        public void Update(Patient p) { _db.Patients.Update(p); _db.SaveChanges(); }
        public void Delete(int id)
        {
            var p = _db.Patients.Find(id);
            if (p != null) { _db.Patients.Remove(p); _db.SaveChanges(); }
        }
        public List<Patient> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _db.Patients.ToList();

            keyword = keyword.ToLower();
            return _db.Patients.Where(p =>
                (p.FirstName != null && p.FirstName.ToLower().Contains(keyword)) ||
                (p.LastName != null && p.LastName.ToLower().Contains(keyword)))
                .ToList();
        }
    }
}
