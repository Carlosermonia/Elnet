using System;
using System.Windows.Forms;

namespace MediTrack.Forms.MasterFile
{
    partial class PatientForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMedHistory;
        private System.Windows.Forms.TextBox txtMedicalHistory;
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
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMedHistory = new System.Windows.Forms.Label();
            this.txtMedicalHistory = new System.Windows.Forms.TextBox();
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
            this.lblFormTitle.Text = "👤 Patient Information";
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

            // lblDOB
            this.lblDOB.Text = "Date of Birth:";
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblDOB.Location = new System.Drawing.Point(20, 135);
            this.lblDOB.AutoSize = true;

            // dtpDOB
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dtpDOB.Location = new System.Drawing.Point(170, 132);
            this.dtpDOB.Size = new System.Drawing.Size(180, 25);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblGender
            this.lblGender.Text = "Gender:";
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblGender.Location = new System.Drawing.Point(20, 170);
            this.lblGender.AutoSize = true;

            // txtGender
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtGender.Location = new System.Drawing.Point(170, 167);
            this.txtGender.Size = new System.Drawing.Size(100, 25);
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPhone
            this.lblPhone.Text = "Contact Number:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblPhone.Location = new System.Drawing.Point(20, 205);
            this.lblPhone.AutoSize = true;

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtPhone.Location = new System.Drawing.Point(170, 202);
            this.txtPhone.Size = new System.Drawing.Size(180, 25);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblEmail.Location = new System.Drawing.Point(20, 240);
            this.lblEmail.AutoSize = true;

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtEmail.Location = new System.Drawing.Point(170, 237);
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblAddress
            this.lblAddress.Text = "Address:";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblAddress.Location = new System.Drawing.Point(20, 275);
            this.lblAddress.AutoSize = true;

            // txtAddress
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtAddress.Location = new System.Drawing.Point(170, 272);
            this.txtAddress.Size = new System.Drawing.Size(300, 25);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblMedHistory
            this.lblMedHistory.Text = "Medical History:";
            this.lblMedHistory.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblMedHistory.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblMedHistory.Location = new System.Drawing.Point(20, 310);
            this.lblMedHistory.AutoSize = true;

            // txtMedicalHistory
            this.txtMedicalHistory.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtMedicalHistory.Location = new System.Drawing.Point(170, 307);
            this.txtMedicalHistory.Size = new System.Drawing.Size(300, 65);
            this.txtMedicalHistory.Multiline = true;
            this.txtMedicalHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMedicalHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnSave
            this.btnSave.Text = "💾 Save";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(170, 390);
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
            this.btnCancel.Location = new System.Drawing.Point(290, 390);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            // PatientForm
            this.ClientSize = new System.Drawing.Size(510, 445);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMedicalHistory);
            this.Controls.Add(this.lblMedHistory);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
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
            this.Text = "Patient Information";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}