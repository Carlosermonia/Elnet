namespace MediTrack.Forms.MasterFile
{
    partial class DoctorListForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDoctors;

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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.dgvDoctors).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 55;
            this.pnlTop.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "🩺 Doctor Records";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 50;
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnDelete);

            // txtSearch
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtSearch.Location = new System.Drawing.Point(12, 13);
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.PlaceholderText = "🔍  Search doctors...";

            // btnSearch
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "Search";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnSearch.Location = new System.Drawing.Point(270, 12);
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnAdd
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(365, 12);
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
            this.btnEdit.Location = new System.Drawing.Point(453, 12);
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
            this.btnDelete.Location = new System.Drawing.Point(541, 12);
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvDoctors
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.dgvDoctors.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvDoctors.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvDoctors.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 227, 252);
            this.dgvDoctors.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDoctors.RowTemplate.Height = 35;
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.GridColor = System.Drawing.Color.FromArgb(220, 230, 245);
            this.dgvDoctors.EnableHeadersVisualStyles = false;
            this.dgvDoctors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDoctors_RowPrePaint);

            // DoctorListForm
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlTop);
            this.BackColor = System.Drawing.Color.White;
            this.Name = "DoctorListForm";
            this.Text = "Doctor Records";
            ((System.ComponentModel.ISupportInitialize)this.dgvDoctors).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}