using System;
using System.Windows.Forms;

namespace MediTrack.Forms.MasterFile
{
    partial class DoctorForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkIsActive;
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
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
            this.lblFormTitle.Text = "🩺 Doctor Information";
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 12);

            // lblFirstName
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblFirstName.Location = new System.Drawing.Point(20, 65);
            this.lblFirstName.AutoSize = true;

            // txtFirstName
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtFirstName.Location = new System.Drawing.Point(170, 62);
            this.txtFirstName.Size = new System.Drawing.Size(250, 25);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblLastName
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblLastName.Location = new System.Drawing.Point(20, 100);
            this.lblLastName.AutoSize = true;

            // txtLastName
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtLastName.Location = new System.Drawing.Point(170, 97);
            this.txtLastName.Size = new System.Drawing.Size(250, 25);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblSpec
            this.lblSpec.Text = "Specialization:";
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblSpec.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblSpec.Location = new System.Drawing.Point(20, 135);
            this.lblSpec.AutoSize = true;

            // txtSpecialization
            this.txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtSpecialization.Location = new System.Drawing.Point(170, 132);
            this.txtSpecialization.Size = new System.Drawing.Size(250, 25);
            this.txtSpecialization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPhone
            this.lblPhone.Text = "Contact Number:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblPhone.Location = new System.Drawing.Point(20, 170);
            this.lblPhone.AutoSize = true;

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtPhone.Location = new System.Drawing.Point(170, 167);
            this.txtPhone.Size = new System.Drawing.Size(180, 25);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblEmail.Location = new System.Drawing.Point(20, 205);
            this.lblEmail.AutoSize = true;

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtEmail.Location = new System.Drawing.Point(170, 202);
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblStatus
            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblStatus.Location = new System.Drawing.Point(20, 240);
            this.lblStatus.AutoSize = true;

            // chkIsActive
            this.chkIsActive.Text = "Active";
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10);
            this.chkIsActive.Location = new System.Drawing.Point(170, 238);
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;

            // btnSave
            this.btnSave.Text = "💾 Save";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(170, 285);
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnCancel.Location = new System.Drawing.Point(290, 285);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            // DoctorForm
            this.ClientSize = new System.Drawing.Size(480, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.pnlTop);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctor Information";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}