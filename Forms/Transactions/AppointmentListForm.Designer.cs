namespace MediTrack.Forms.Transactions
{
    partial class AppointmentListForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilter;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.chkFilterDate = new System.Windows.Forms.CheckBox();
            this.dtpFilter = new System.Windows.Forms.DateTimePicker();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)this.dgvAppointments).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 55;
            this.pnlTop.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "📅 Appointments";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 90;
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlToolbar.Controls.Add(this.chkFilterDate);
            this.pnlToolbar.Controls.Add(this.dtpFilter);
            this.pnlToolbar.Controls.Add(this.lblFilterStatus);
            this.pnlToolbar.Controls.Add(this.cboFilterStatus);
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.pnlButtons);

            // chkFilterDate
            this.chkFilterDate.Name = "chkFilterDate";
            this.chkFilterDate.Text = "Filter by date:";
            this.chkFilterDate.Font = new System.Drawing.Font("Segoe UI", 9);
            this.chkFilterDate.Location = new System.Drawing.Point(12, 12);
            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.chkFilterDate_CheckedChanged);

            // dtpFilter
            this.dtpFilter.Name = "dtpFilter";
            this.dtpFilter.Location = new System.Drawing.Point(120, 9);
            this.dtpFilter.Size = new System.Drawing.Size(130, 23);
            this.dtpFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilter.Enabled = false;
            this.dtpFilter.ValueChanged += new System.EventHandler(this.dtpFilter_ValueChanged);

            // lblFilterStatus
            this.lblFilterStatus.Text = "Status:";
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblFilterStatus.Location = new System.Drawing.Point(265, 12);
            this.lblFilterStatus.AutoSize = true;

            // cboFilterStatus
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Location = new System.Drawing.Point(310, 9);
            this.cboFilterStatus.Size = new System.Drawing.Size(120, 23);
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9);
            this.cboFilterStatus.Items.AddRange(new object[] {
                "All", "Scheduled", "Completed", "Cancelled", "No-Show" });
            this.cboFilterStatus.SelectedIndex = 0;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterStatus_SelectedIndexChanged);

            // btnSearch
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "🔄 Refresh";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnSearch.Location = new System.Drawing.Point(445, 8);
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // pnlButtons
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlButtons.Location = new System.Drawing.Point(10, 45);
            this.pnlButtons.Size = new System.Drawing.Size(400, 35);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);

            // btnAdd
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(0, 4);
            this.btnAdd.Size = new System.Drawing.Size(80, 27);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "✏ Edit";
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnEdit.Location = new System.Drawing.Point(88, 4);
            this.btnEdit.Size = new System.Drawing.Size(80, 27);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "🗑 Delete";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnDelete.Location = new System.Drawing.Point(176, 4);
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvAppointments
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvAppointments.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvAppointments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 227, 252);
            this.dgvAppointments.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAppointments.RowTemplate.Height = 35;
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(220, 230, 245);
            this.dgvAppointments.EnableHeadersVisualStyles = false;

            // pnlLegend
            this.pnlLegend.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegend.Height = 35;
            this.pnlLegend.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlLegend.Controls.Add(MakeLegendLabel("Scheduled", System.Drawing.Color.LightBlue, 10));
            this.pnlLegend.Controls.Add(MakeLegendLabel("Completed", System.Drawing.Color.LightGreen, 120));
            this.pnlLegend.Controls.Add(MakeLegendLabel("Cancelled", System.Drawing.Color.LightCoral, 230));
            this.pnlLegend.Controls.Add(MakeLegendLabel("No-Show", System.Drawing.Color.LightYellow, 340));

            // AppointmentListForm
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlTop);
            this.BackColor = System.Drawing.Color.White;
            this.Name = "AppointmentListForm";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)this.dgvAppointments).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label MakeLegendLabel(
            string text, System.Drawing.Color color, int left)
        {
            return new System.Windows.Forms.Label()
            {
                Text = $"  {text}  ",
                BackColor = color,
                Font = new System.Drawing.Font("Segoe UI", 8),
                AutoSize = true,
                Location = new System.Drawing.Point(left, 7),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            };
        }
    }
}