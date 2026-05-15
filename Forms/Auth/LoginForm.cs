using MediTrack.Data;
using MediTrack.Services;
using MediTrack.Forms.Dashboard; // Add this using directive if DashboardForm is in this namespace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTrack.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var authService = new AuthService(db);

            if (authService.Login(txtUsername.Text, txtPassword.Text))
            {
                var dashboard = new DashboardForm(authService);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}