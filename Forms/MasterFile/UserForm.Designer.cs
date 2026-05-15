namespace MediTrack.Forms.MasterFile
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 50;
            this.pnlTop.Controls.Add(this.lblFormTitle);

            // lblFormTitle
            this.lblFormTitle.Text = "👤 User Details";
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 12);

            // lblUsername
            this.lblUsername.Text = "Username:";
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblUsername.Location = new System.Drawing.Point(20, 70);
            this.lblUsername.AutoSize = true;

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtUsername.Location = new System.Drawing.Point(130, 67);
            this.txtUsername.Size = new System.Drawing.Size(220, 25);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.Text = "Password:";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblPassword.Location = new System.Drawing.Point(20, 110);
            this.lblPassword.AutoSize = true;

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtPassword.Location = new System.Drawing.Point(130, 107);
            this.txtPassword.Size = new System.Drawing.Size(220, 25);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PlaceholderText = "Leave blank to keep current";

            // lblRole
            this.lblRole.Text = "Role:";
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblRole.Location = new System.Drawing.Point(20, 150);
            this.lblRole.AutoSize = true;

            // cboRole
            this.cboRole.Name = "cboRole";
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10);
            this.cboRole.Location = new System.Drawing.Point(130, 147);
            this.cboRole.Size = new System.Drawing.Size(220, 25);
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Items.AddRange(new object[] { "Admin", "Receptionist", "Doctor" });

            // btnSave
            this.btnSave.Text = "💾 Save";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(130, 195);
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnCancel.Location = new System.Drawing.Point(250, 195);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // UserForm
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlTop);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Details";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}