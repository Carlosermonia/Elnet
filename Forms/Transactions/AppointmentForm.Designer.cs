namespace MediTrack.Forms.Transactions
{
    partial class AppointmentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cboPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboTimeSlot;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblConflict;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cboPatient = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboTimeSlot = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblConflict = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.nudFee).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 50;
            this.pnlTop.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "📅 Appointment Details";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);

            // lblPatient
            this.lblPatient.Text = "Patient:";
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblPatient.Location = new System.Drawing.Point(20, 65);
            this.lblPatient.AutoSize = true;

            // cboPatient
            this.cboPatient.Font = new System.Drawing.Font("Segoe UI", 10);
            this.cboPatient.Location = new System.Drawing.Point(170, 62);
            this.cboPatient.Size = new System.Drawing.Size(280, 25);
            this.cboPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblDoctor
            this.lblDoctor.Text = "Doctor:";
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblDoctor.Location = new System.Drawing.Point(20, 100);
            this.lblDoctor.AutoSize = true;

            // cboDoctor
            this.cboDoctor.Font = new System.Drawing.Font("Segoe UI", 10);
            this.cboDoctor.Location = new System.Drawing.Point(170, 97);
            this.cboDoctor.Size = new System.Drawing.Size(280, 25);
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblDate
            this.lblDate.Text = "Date:";
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblDate.Location = new System.Drawing.Point(20, 135);
            this.lblDate.AutoSize = true;

            // dtpDate
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dtpDate.Location = new System.Drawing.Point(170, 132);
            this.dtpDate.Size = new System.Drawing.Size(180, 25);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblTime
            this.lblTime.Text = "Time Slot:";
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblTime.Location = new System.Drawing.Point(20, 170);
            this.lblTime.AutoSize = true;

            // cboTimeSlot
            this.cboTimeSlot.Font = new System.Drawing.Font("Segoe UI", 10);
            this.cboTimeSlot.Location = new System.Drawing.Point(170, 167);
            this.cboTimeSlot.Size = new System.Drawing.Size(130, 25);
            this.cboTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblStatus
            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblStatus.Location = new System.Drawing.Point(20, 205);
            this.lblStatus.AutoSize = true;

            // cboStatus
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10);
            this.cboStatus.Location = new System.Drawing.Point(170, 202);
            this.cboStatus.Size = new System.Drawing.Size(150, 25);
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblFee
            this.lblFee.Text = "Consultation Fee:";
            this.lblFee.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblFee.Location = new System.Drawing.Point(20, 240);
            this.lblFee.AutoSize = true;

            // nudFee
            this.nudFee.Font = new System.Drawing.Font("Segoe UI", 10);
            this.nudFee.Location = new System.Drawing.Point(170, 237);
            this.nudFee.Size = new System.Drawing.Size(130, 25);
            this.nudFee.Maximum = 99999;
            this.nudFee.DecimalPlaces = 2;

            // lblNotes
            this.lblNotes.Text = "Notes:";
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblNotes.Location = new System.Drawing.Point(20, 275);
            this.lblNotes.AutoSize = true;

            // txtNotes
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtNotes.Location = new System.Drawing.Point(170, 272);
            this.txtNotes.Size = new System.Drawing.Size(280, 65);
            this.txtNotes.Multiline = true;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblConflict
            this.lblConflict.Text = "";
            this.lblConflict.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblConflict.ForeColor = System.Drawing.Color.Red;
            this.lblConflict.Location = new System.Drawing.Point(20, 350);
            this.lblConflict.Size = new System.Drawing.Size(430, 20);
            this.lblConflict.Visible = false;

            // btnSave
            this.btnSave.Text = "💾 Save";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(170, 378);
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
            this.btnCancel.Location = new System.Drawing.Point(290, 378);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            // AppointmentForm
            this.ClientSize = new System.Drawing.Size(510, 430);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblConflict);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.nudFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboTimeSlot);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cboPatient);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.pnlTop);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)this.nudFee).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}