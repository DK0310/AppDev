using System;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class Add : Form
    {
        private PersonController controller;

        public Add(PersonController controller)
        {
            InitializeComponent();
            this.controller = controller;
            comboBoxUserType.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelTeacher.Visible = false;
            panelStudent.Visible = false;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0: // Administration
                    panelAdmin.Visible = true;
                    panelAdmin.BringToFront();
                    break;
                case 1: // Teaching Staff
                    panelTeacher.Visible = true;
                    panelTeacher.BringToFront();
                    break;
                case 2: // Student
                    panelStudent.Visible = true;
                    panelStudent.BringToFront();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string telephone = textBox2.Text;
                string email = textBox3.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please fill in all basic information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                switch (comboBoxUserType.SelectedIndex)
                {
                    case 0: // Administration
                        AddAdmin(name, telephone, email);
                        break;
                    case 1: // Teaching Staff
                        AddTeacher(name, telephone, email);
                        break;
                    case 2: // Student
                        AddStudent(name, telephone, email);
                        break;
                    default:
                        MessageBox.Show("Please select user type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAdmin(string name, string telephone, string email)
        {
            decimal salary = decimal.Parse(textBox4.Text);
            int workingHours = int.Parse(textBox5.Text);
            bool isFullTime = radioButton1.Checked;

            Admin newAdmin = new Admin(name, telephone, email, "Administration", salary, workingHours, isFullTime);
            controller.AddAdmin(newAdmin);

            MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = $"Latest: {newAdmin.Name} - {newAdmin.Role}";
            ClearFields();
        }

        private void AddTeacher(string name, string telephone, string email)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherSub1.Text) || string.IsNullOrWhiteSpace(txtTeacherSub2.Text))
            {
                MessageBox.Show("Please fill in salary and subjects!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salary = decimal.Parse(txtTeacherSalary.Text);
            string sub1 = txtTeacherSub1.Text;
            string sub2 = txtTeacherSub2.Text;

            Teacher newTeacher = new Teacher(name, telephone, email, "Teaching Staff", salary, sub1, sub2);
            controller.AddTeacher(newTeacher);

            MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = $"Latest: {newTeacher.Name} - {newTeacher.Role}";
            ClearFields();
        }

        private void AddStudent(string name, string telephone, string email)
        {
            if (string.IsNullOrWhiteSpace(txtStudentSub1.Text) || string.IsNullOrWhiteSpace(txtStudentSub2.Text) || string.IsNullOrWhiteSpace(txtStudentSub3.Text))
            {
                MessageBox.Show("Please fill in all subjects!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sub1 = txtStudentSub1.Text;
            string sub2 = txtStudentSub2.Text;
            string sub3 = txtStudentSub3.Text;

            Student newStudent = new Student(name, telephone, email, "Student", sub1, sub2, sub3);
            controller.AddStudent(newStudent);

            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = $"Latest: {newStudent.Name} - {newStudent.Role}";
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            txtTeacherSalary.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtTeacherSub1.Clear();
            txtTeacherSub2.Clear();
            txtStudentSub1.Clear();
            txtStudentSub2.Clear();
            txtStudentSub3.Clear();
        }
    }
}

