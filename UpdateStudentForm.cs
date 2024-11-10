using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG_Project
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        // Method to search and display student details for editing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            var students = File.ReadAllLines("students.txt");

            foreach (var line in students)
            {
                var fields = line.Split(',');
                if (fields[0] == studentID)
                {
                    // Populate input fields with student data
                    txtName.Text = fields[1];
                    txtAge.Text = fields[2];
                    txtCourse.Text = fields[3];
                    return;
                }
            }

            MessageBox.Show("Student not found.");
        }

        // Method to save updated student information back to file
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string[] lines = File.ReadAllLines("students.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

                // Find and update student record
                if (fields[0] == studentID)
                {
                    fields[1] = txtName.Text;
                    fields[2] = txtAge.Text;
                    fields[3] = txtCourse.Text;
                    lines[i] = string.Join(",", fields);

                    // Write updated data to file
                    File.WriteAllLines("students.txt", lines);
                    MessageBox.Show("Student updated successfully.");
                    return;
                }
            }

            MessageBox.Show("Error updating student.");
        }

    }
}

