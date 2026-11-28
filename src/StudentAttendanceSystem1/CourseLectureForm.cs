using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CourseLectureForm : Form
    {
        private Dictionary<string, List<string>> courseLectures = new Dictionary<string, List<string>>();

        public CourseLectureForm()
        {
            InitializeComponent();
        }

        private void CourseLectureForm_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            courseLectures.Clear();
            courseLectures.Add("Software Engineering (SOU30542)", new List<string>
            {
                "2026-11-28 - 09:00 AM (Part 4: Git & GitHub)",
                "2026-11-21 - 09:00 AM (Part 3: System Modeling)"
            });
            courseLectures.Add("Database Systems", new List<string>
            {
                "2026-11-27 - 11:00 AM (ER Diagram & SQLite)",
                "2026-11-20 - 11:00 AM (Normalization)"
            });

            cmbCourses.Items.Clear();
            foreach (var course in courseLectures.Keys)
            {
                cmbCourses.Items.Add(course);
            }

            if (cmbCourses.Items.Count > 0)
            {
                cmbCourses.SelectedIndex = 0;
            }
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLectures.Items.Clear();

            if (cmbCourses.SelectedItem != null)
            {
                string selectedCourse = cmbCourses.SelectedItem.ToString();
                if (courseLectures.ContainsKey(selectedCourse))
                {
                    foreach (var lecture in courseLectures[selectedCourse])
                    {
                        cmbLectures.Items.Add(lecture);
                    }

                    if (cmbLectures.Items.Count > 0)
                    {
                        cmbLectures.SelectedIndex = 0;
                    }
                }
            }
        }

        private void cmbLectures_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLectureTime.Text))
            {
                MessageBox.Show("Please enter the lecture time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCourse = cmbCourses.SelectedItem.ToString();
            string newLecture = $"{dtpLectureDate.Value:yyyy-MM-dd} - {txtLectureTime.Text.Trim()}";

            courseLectures[selectedCourse].Insert(0, newLecture);
            cmbLectures.Items.Insert(0, newLecture);
            cmbLectures.SelectedIndex = 0;

            txtLectureTime.Clear();
            MessageBox.Show("Lecture added to the list!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedItem == null || cmbLectures.SelectedItem == null)
            {
                MessageBox.Show("Please select both a course and a lecture.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Course: " + cmbCourses.SelectedItem + "\nLecture: " + cmbLectures.SelectedItem,
                "Selected Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}