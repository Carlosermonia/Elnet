namespace MediTrack.Forms.Reports
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvReport;

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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.dgvReport).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 55;
            this.pnlTop.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "📊 Appointment Reports";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 55;
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlToolbar.Controls.Add(this.lblFrom);
            this.pnlToolbar.Controls.Add(this.dtpFrom);
            this.pnlToolbar.Controls.Add(this.lblTo);
            this.pnlToolbar.Controls.Add(this.dtpTo);
            this.pnlToolbar.Controls.Add(this.btnGenerate);
            this.pnlToolbar.Controls.Add(this.lblCount);

            // lblFrom
            this.lblFrom.Text = "From:";
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblFrom.Location = new System.Drawing.Point(12, 18);
            this.lblFrom.AutoSize = true;

            // dtpFrom
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dtpFrom.Location = new System.Drawing.Point(60, 14);
            this.dtpFrom.Size = new System.Drawing.Size(130, 25);

            // lblTo
            this.lblTo.Text = "To:";
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblTo.Location = new System.Drawing.Point(205, 18);
            this.lblTo.AutoSize = true;

            // dtpTo
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dtpTo.Location = new System.Drawing.Point(230, 14);
            this.dtpTo.Size = new System.Drawing.Size(130, 25);

            // btnGenerate
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "📊 Generate Report";
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(375, 12);
            this.btnGenerate.Size = new System.Drawing.Size(150, 30);
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // lblCount
            this.lblCount.Name = "lblCount";
            this.lblCount.Text = "Total Records: 0";
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblCount.Location = new System.Drawing.Point(540, 18);
            this.lblCount.AutoSize = true;

            // dgvReport
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvReport.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvReport.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 227, 252);
            this.dgvReport.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReport.RowTemplate.Height = 35;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(220, 230, 245);
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.RowHeadersVisible = false;

            // ReportForm
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlTop);
            this.BackColor = System.Drawing.Color.White;
            this.Name = "ReportForm";
            this.Text = "Appointment Report";
            ((System.ComponentModel.ISupportInitialize)this.dgvReport).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}