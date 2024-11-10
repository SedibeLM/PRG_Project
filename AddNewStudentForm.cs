using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG_Project
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
        private Label lblFeedback;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
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
            this.lblFeedback = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(438, 359);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 20);
            this.lblFeedback.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(217, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 26);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(217, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 26);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(217, 170);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(171, 26);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(217, 230);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(171, 26);
            this.textBox8.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(1189, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
