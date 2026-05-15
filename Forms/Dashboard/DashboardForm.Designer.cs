namespace MediTrack.Forms.Dashboard
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblTodayAppointments;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblOtherMetric;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnLogout;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblTodayAppointments = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblOtherMetric = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.masterFilesToolStripMenuItem,
                this.transactionsToolStripMenuItem,
                this.reportsToolStripMenuItem,
                this.settingsToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 30);
            this.menuStrip1.TabIndex = 0;

            // masterFilesToolStripMenuItem
            this.masterFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.patientsToolStripMenuItem, this.doctorsToolStripMenuItem });
            this.masterFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterFilesToolStripMenuItem.Name = "masterFilesToolStripMenuItem";
            this.masterFilesToolStripMenuItem.Text = "Master Files";

            // patientsToolStripMenuItem
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);

            // doctorsToolStripMenuItem
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);

            // transactionsToolStripMenuItem
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.appointmentsToolStripMenuItem });
            this.transactionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Text = "Transactions";

            // appointmentsToolStripMenuItem
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);

            // reportsToolStripMenuItem
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.summaryToolStripMenuItem, this.detailedToolStripMenuItem });
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);

            // summaryToolStripMenuItem
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);

            // detailedToolStripMenuItem
            this.detailedToolStripMenuItem.Name = "detailedToolStripMenuItem";
            this.detailedToolStripMenuItem.Text = "Detailed";
            this.detailedToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);

            // settingsToolStripMenuItem
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.userToolStripMenuItem, this.logoutToolStripMenuItem });
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Text = "Settings";

            // userToolStripMenuItem
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);

            // logoutToolStripMenuItem
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);

            // pnlTopBar
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 60;
            this.pnlTopBar.Controls.Add(this.lblAppTitle);
            this.pnlTopBar.Controls.Add(this.btnLogout);

            // lblAppTitle
            this.lblAppTitle.Text = "🏥 MediTrack";
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Location = new System.Drawing.Point(15, 12);

            // btnLogout
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Text = "⏻ Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.Location = new System.Drawing.Point(1000, 15);
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlStats
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Height = 100;
            this.pnlStats.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlStats.Controls.Add(this.pnlCard3);
            this.pnlStats.Controls.Add(this.pnlCard2);
            this.pnlStats.Controls.Add(this.pnlCard1);

            // pnlCard1
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Size = new System.Drawing.Size(200, 70);
            this.pnlCard1.Location = new System.Drawing.Point(15, 15);
            this.pnlCard1.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblTotalPatients);

            // lblCard1Title
            this.lblCard1Title.Text = "TOTAL PATIENTS";
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Location = new System.Drawing.Point(10, 8);

            // lblTotalPatients
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Text = "0";
            this.lblTotalPatients.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            this.lblTotalPatients.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.Location = new System.Drawing.Point(10, 28);

            // pnlCard2
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Size = new System.Drawing.Size(200, 70);
            this.pnlCard2.Location = new System.Drawing.Point(230, 15);
            this.pnlCard2.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblTodayAppointments);

            // lblCard2Title
            this.lblCard2Title.Text = "TODAY'S APPOINTMENTS";
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Location = new System.Drawing.Point(10, 8);

            // lblTodayAppointments
            this.lblTodayAppointments.Name = "lblTodayAppointments";
            this.lblTodayAppointments.Text = "0";
            this.lblTodayAppointments.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            this.lblTodayAppointments.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblTodayAppointments.AutoSize = true;
            this.lblTodayAppointments.Location = new System.Drawing.Point(10, 28);

            // pnlCard3
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Size = new System.Drawing.Size(200, 70);
            this.pnlCard3.Location = new System.Drawing.Point(445, 15);
            this.pnlCard3.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblOtherMetric);

            // lblCard3Title
            this.lblCard3Title.Text = "PENDING APPOINTMENTS";
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Location = new System.Drawing.Point(10, 8);

            // lblOtherMetric
            this.lblOtherMetric.Name = "lblOtherMetric";
            this.lblOtherMetric.Text = "0";
            this.lblOtherMetric.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            this.lblOtherMetric.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblOtherMetric.AutoSize = true;
            this.lblOtherMetric.Location = new System.Drawing.Point(10, 28);

            // pnlContent
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTopBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "MediTrack — Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}