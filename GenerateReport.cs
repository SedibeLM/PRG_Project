using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.IO;
using System.Windows.Forms;

namespace PRG_Project
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

        // Generate Report Button Click Event
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // File path for students.txt
                string filePath = "students.txt";

                // Initialize counters
                int studentCount = 0;
                int ageSum = 0;

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read lines from the file
                    foreach (string line in File.ReadLines(filePath))
                    {
                        var details = line.Split(','); // Assuming CSV format: ID, Name, Age, Course

                        // Increment student count
                        studentCount++;

                        // Sum up the ages (parse age as an integer)
                        if (int.TryParse(details[2], out int age))
                        {
                            ageSum += age;
                        }
                    }

                    // Calculate average age
                    double averageAge = studentCount > 0 ? (double)ageSum / studentCount : 0;

                    // Display results in the labels
                    lblTotalStudents.Text = $"Total Students: {studentCount}";
                    lblAverageAge.Text = $"Average Age: {averageAge:F2}"; // Display with 2 decimal places
                }
                else
                {
                    MessageBox.Show("Error: students.txt file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}");
            }
        }

        // Save Report Button Click Event
        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                string reportFilePath = "summary.txt";
                string reportContent = $"{lblTotalStudents.Text}\n{lblAverageAge.Text}";

                // Write to summary.txt
                File.WriteAllText(reportFilePath, reportContent);

                MessageBox.Show("Report saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving report: {ex.Message}");
            }
        }

        // Home Button Click Event
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Show the home form
            MainForm homeForm = new MainForm();
            homeForm.Show();
        }
    }
}
