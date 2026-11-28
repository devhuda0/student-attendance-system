namespace WindowsFormsApp1
{
    partial class CourseLectureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseLectureForm));
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblLecture = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbLectures = new System.Windows.Forms.ComboBox();
            this.grpAddLecture = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpLectureDate = new System.Windows.Forms.DateTimePicker();
            this.txtLectureTime = new System.Windows.Forms.TextBox();
            this.btnAddLecture = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpAddLecture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.grpAddLecture);
            this.pnlCard.Controls.Add(this.cmbLectures);
            this.pnlCard.Controls.Add(this.cmbCourses);
            this.pnlCard.Controls.Add(this.lblCourse);
            this.pnlCard.Controls.Add(this.btnProceed);
            this.pnlCard.Controls.Add(this.lblLecture);
            this.pnlCard.Controls.Add(this.lblHeader);
            this.pnlCard.Controls.Add(this.lblSystemTitle);
            this.pnlCard.Location = new System.Drawing.Point(80, 70);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(624, 602);
            this.pnlCard.TabIndex = 1;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.Black;
            this.btnProceed.Location = new System.Drawing.Point(151, 526);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(290, 46);
            this.btnProceed.TabIndex = 9;
            this.btnProceed.Text = "Take Attendance";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblLecture
            // 
            this.lblLecture.AutoSize = true;
            this.lblLecture.BackColor = System.Drawing.Color.Linen;
            this.lblLecture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblLecture.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture.Location = new System.Drawing.Point(58, 306);
            this.lblLecture.Name = "lblLecture";
            this.lblLecture.Size = new System.Drawing.Size(119, 22);
            this.lblLecture.TabIndex = 6;
            this.lblLecture.Text = "Select Lecture: ";
            this.lblLecture.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(202, 108);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(229, 28);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Select Course - Lecture";
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.BackColor = System.Drawing.Color.Wheat;
            this.lblSystemTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemTitle.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSystemTitle.Location = new System.Drawing.Point(139, 69);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(360, 39);
            this.lblSystemTitle.TabIndex = 3;
            this.lblSystemTitle.Text = "STUDENT ATTENDANCE SYSTEM";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSystemTitle.UseCompatibleTextRendering = true;
            this.lblSystemTitle.UseWaitCursor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(331, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(134, 115);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Linen;
            this.lblCourse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCourse.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(58, 189);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(117, 22);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Select Course: ";
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(62, 231);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(490, 38);
            this.cmbCourses.TabIndex = 11;
            this.cmbCourses.SelectedIndexChanged += new System.EventHandler(this.cmbCourses_SelectedIndexChanged);
            // 
            // cmbLectures
            // 
            this.cmbLectures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLectures.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLectures.FormattingEnabled = true;
            this.cmbLectures.Location = new System.Drawing.Point(62, 356);
            this.cmbLectures.Name = "cmbLectures";
            this.cmbLectures.Size = new System.Drawing.Size(490, 38);
            this.cmbLectures.TabIndex = 12;
            this.cmbLectures.SelectedIndexChanged += new System.EventHandler(this.cmbLectures_SelectedIndexChanged);
            // 
            // grpAddLecture
            // 
            this.grpAddLecture.BackColor = System.Drawing.Color.Gainsboro;
            this.grpAddLecture.Controls.Add(this.btnAddLecture);
            this.grpAddLecture.Controls.Add(this.txtLectureTime);
            this.grpAddLecture.Controls.Add(this.dtpLectureDate);
            this.grpAddLecture.Controls.Add(this.lblTime);
            this.grpAddLecture.Controls.Add(this.lblDate);
            this.grpAddLecture.Location = new System.Drawing.Point(62, 418);
            this.grpAddLecture.Name = "grpAddLecture";
            this.grpAddLecture.Size = new System.Drawing.Size(490, 80);
            this.grpAddLecture.TabIndex = 13;
            this.grpAddLecture.TabStop = false;
            this.grpAddLecture.Text = "Add New Lecture";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(210, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 20);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time: ";
            // 
            // dtpLectureDate
            // 
            this.dtpLectureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLectureDate.Location = new System.Drawing.Point(61, 37);
            this.dtpLectureDate.Name = "dtpLectureDate";
            this.dtpLectureDate.Size = new System.Drawing.Size(143, 26);
            this.dtpLectureDate.TabIndex = 2;
            // 
            // txtLectureTime
            // 
            this.txtLectureTime.Location = new System.Drawing.Point(254, 37);
            this.txtLectureTime.Name = "txtLectureTime";
            this.txtLectureTime.Size = new System.Drawing.Size(100, 26);
            this.txtLectureTime.TabIndex = 3;
            // 
            // btnAddLecture
            // 
            this.btnAddLecture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddLecture.Location = new System.Drawing.Point(360, 30);
            this.btnAddLecture.Name = "btnAddLecture";
            this.btnAddLecture.Size = new System.Drawing.Size(124, 34);
            this.btnAddLecture.TabIndex = 4;
            this.btnAddLecture.Text = "Add Lecture";
            this.btnAddLecture.UseVisualStyleBackColor = false;
            // 
            // CourseLectureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 703);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CourseLectureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Course and Lecture";
            this.Load += new System.EventHandler(this.CourseLectureForm_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpAddLecture.ResumeLayout(false);
            this.grpAddLecture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblLecture;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbLectures;
        private System.Windows.Forms.GroupBox grpAddLecture;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpLectureDate;
        private System.Windows.Forms.TextBox txtLectureTime;
        private System.Windows.Forms.Button btnAddLecture;
    }
}