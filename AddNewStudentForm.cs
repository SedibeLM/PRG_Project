using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class AddStudentForm : Form
    {
        private Label txtName;
        private Label txtAge;
        private Label txtCourse;
        private Button btnSave;
        private Button btnClear;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label txtStudentID;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        // Event handler for saving a new student record
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            string studentID = txtStudentID.Text;
            string name = txtName.Text;
            int age;
            string course = txtCourse.Text;

            // Validate input
            if (int.TryParse(txtAge.Text, out age) && !string.IsNullOrEmpty(studentID) && !string.IsNullOrEmpty(name))
            {
                // Format record and save to file
                string record = $"{studentID},{name},{age},{course}";
                File.AppendAllText("students.txt", record + Environment.NewLine);
                MessageBox.Show("Student added successfully!");

                // Clear input fields after saving
                txtStudentID.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCourse.Clear();
            }
            else
            {
                // Display error message if validation fails
                MessageBox.Show("Please enter valid details.");
            }
        }

        private void InitializeComponent()
        {
            this.txtStudentID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.AutoSize = true;
            this.txtStudentID.Location = new System.Drawing.Point(91, 62);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(87, 20);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.Text = "Student ID";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(91, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(51, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(91, 229);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(38, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "Age";
            // 
            // txtCourse
            // 
            this.txtCourse.AutoSize = true;
            this.txtCourse.Location = new System.Drawing.Point(91, 315);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(60, 20);
            this.txtCourse.TabIndex = 3;
            this.txtCourse.Text = "Course";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(599, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 75);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Search";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(826, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 75);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(305, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(305, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 26);
            this.textBox4.TabIndex = 9;
            // 
            // AddStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(1046, 459);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Name = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
