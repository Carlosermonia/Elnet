using MediTrack.Data;
using MediTrack.Models;

namespace MediTrack.Services
{
    public class AuthService
    {
        private readonly AppDbContext _db;
        public User? CurrentUser { get; private set; }

        public AuthService(AppDbContext db) { _db = db; }

        public bool Login(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == username && u.IsActive);
            if (user == null) return false;
            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash)) return false;
            CurrentUser = user;
            return true;
        }

        public void Logout() { CurrentUser = null; }
    }
}