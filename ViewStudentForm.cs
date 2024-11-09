using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        // Method to load students from the file and display them in DataGridView
        private void LoadStudents()
        {
            var students = File.ReadAllLines("students.txt").Select(line => line.Split(','));
            dgvStudents.Rows.Clear(); // Clear existing data in DataGridView

            foreach (var student in students)
            {
                // Add each student's details as a row in the DataGridView
                dgvStudents.Rows.Add(student[0], student[1], student[2], student[3]);
            }
        }

        // Refresh data in DataGridView
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

       
    }
}
