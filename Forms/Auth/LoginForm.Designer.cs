namespace MediTrack.Forms.Auth
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // pnlLeft - blue side
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 380;
            this.pnlLeft.Controls.Add(this.lblAppName);
            this.pnlLeft.Controls.Add(this.lblTagline);

            // lblAppName
            this.lblAppName.Text = "🏥 MediTrack";
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 28, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(50, 180);

            // lblTagline
            this.lblTagline.Text = "Integrated Clinic Appointment\n& Patient Health Record System";
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Regular);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255);
            this.lblTagline.AutoSize = true;
            this.lblTagline.Location = new System.Drawing.Point(50, 260);

            // pnlRight - white side
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.lblError);

            // lblWelcome
            this.lblWelcome.Text = "Welcome Back";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(60, 100);

            // lblSubtitle
            this.lblSubtitle.Text = "Sign in to your account";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(62, 145);

            // lblUsername
            this.lblUsername.Text = "Username";
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(60, 200);

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11);
            this.txtUsername.Location = new System.Drawing.Point(60, 222);
            this.txtUsername.Size = new System.Drawing.Size(280, 32);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.PlaceholderText = "Enter your username";

            // lblPassword
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 275);

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11);
            this.txtPassword.Location = new System.Drawing.Point(60, 297);
            this.txtPassword.Size = new System.Drawing.Size(280, 32);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.PlaceholderText = "Enter your password";

            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "Sign In";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(60, 355);
            this.btnLogin.Size = new System.Drawing.Size(280, 45);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblError
            this.lblError.Name = "lblError";
            this.lblError.Text = "Invalid username or password.";
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(60, 410);
            this.lblError.Visible = false;

            // LoginForm
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediTrack — Login";
            this.BackColor = System.Drawing.Color.White;
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}