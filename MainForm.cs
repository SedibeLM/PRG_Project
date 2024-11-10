using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PRG_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Method to open the Add Student form
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        // Method to open the View Students form
        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            ViewStudentsForm viewStudentsForm = new ViewStudentsForm();
            viewStudentsForm.Show();
        }

        // Method to open the Generate Report form
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportForm generateReportForm = new GenerateReportForm();
            generateReportForm.Show();
        }
    }
}