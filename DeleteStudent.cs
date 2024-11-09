using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        // Method to delete a student by ID
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            var lines = File.ReadAllLines("students.txt").Where(line => !line.StartsWith(studentID));

            File.WriteAllLines("students.txt", lines);
            MessageBox.Show("Student deleted successfully.");
        }

        
    }
}
