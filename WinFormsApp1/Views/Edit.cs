using System;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Edit : Form
    {
        private PersonController controller;
        private int currentUserIndex = -1;

        public Edit(PersonController controller)
        {
            InitializeComponent();
            this.controller = controller;
            comboBoxUserType.SelectedIndex = 0;
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelTeacher.Visible = false;
            panelStudent.Visible = false;
            comboBoxSelectUser.Items.Clear();
            comboBoxSelectUser.Text = "";
            ClearFields();

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    LoadAdminsList();
                    panelAdmin.Visible = true;
                    break;
                case 1:
                    LoadTeachersList();
                    panelTeacher.Visible = true;
                    break;
                case 2:
                    LoadStudentsList();
                    panelStudent.Visible = true;
                    break;
            }
        }

        private void LoadAdminsList()
        {
            var admins = controller.GetAllAdmins();
            for (int i = 0; i < admins.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{admins[i].Name} - {admins[i].Email}");
            }
        }

        private void LoadTeachersList()
        {
            var teachers = controller.GetAllTeachers();
            for (int i = 0; i < teachers.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{teachers[i].Name} - {teachers[i].Email}");
            }
        }

        private void LoadStudentsList()
        {
            var students = controller.GetAllStudents();
            for (int i = 0; i < students.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{students[i].Name} - {students[i].Email}");
            }
        }

        private void comboBoxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUserIndex = comboBoxSelectUser.SelectedIndex;

            if (currentUserIndex < 0)
                return;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    LoadAdminData(currentUserIndex);
                    break;
                case 1:
                    LoadTeacherData(currentUserIndex);
                    break;
                case 2:
                    LoadStudentData(currentUserIndex);
                    break;
            }
        }

        private void LoadAdminData(int index)
        {
            var admin = controller.GetAdmin(index);
            if (admin != null)
            {
                textBox1.Text = admin.Name;
                textBox2.Text = admin.Telephone;
                textBox3.Text = admin.Email;
                textBox4.Text = admin.Salary.ToString();
                textBox5.Text = admin.WorkingHours.ToString();
                radioButton1.Checked = admin.IsFullTime;
                radioButton2.Checked = !admin.IsFullTime;
            }
        }

        private void LoadTeacherData(int index)
        {
            var teacher = controller.GetTeacher(index);
            if (teacher != null)
            {
                textBox1.Text = teacher.Name;
                textBox2.Text = teacher.Telephone;
                textBox3.Text = teacher.Email;
                txtTeacherSalary.Text = teacher.Salary.ToString();
                txtTeacherSub1.Text = teacher.Sub1;
                txtTeacherSub2.Text = teacher.Sub2;
            }
        }

        private void LoadStudentData(int index)
        {
            var student = controller.GetStudent(index);
            if (student != null)
            {
                textBox1.Text = student.Name;
                textBox2.Text = student.Telephone;
                textBox3.Text = student.Email;
                txtStudentSub1.Text = student.Sub1;
                txtStudentSub2.Text = student.Sub2;
                txtStudentSub3.Text = student.Sub3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentUserIndex < 0)
            {
                MessageBox.Show("Please select a user to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                bool success = false;

                switch (comboBoxUserType.SelectedIndex)
                {
                    case 0:
                        success = UpdateAdmin(name, telephone, email);
                        break;
                    case 1:
                        success = UpdateTeacher(name, telephone, email);
                        break;
                    case 2:
                        success = UpdateStudent(name, telephone, email);
                        break;
                }

                if (success)
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "User updated successfully!";
                    comboBoxUserType_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateAdmin(string name, string telephone, string email)
        {
            decimal salary = decimal.Parse(textBox4.Text);
            int workingHours = int.Parse(textBox5.Text);
            bool isFullTime = radioButton1.Checked;

            Admin updatedAdmin = new Admin(name, telephone, email, "Administration", salary, workingHours, isFullTime);
            return controller.UpdateAdmin(currentUserIndex, updatedAdmin);
        }

        private bool UpdateTeacher(string name, string telephone, string email)
        {
            decimal salary = decimal.Parse(txtTeacherSalary.Text);
            string sub1 = txtTeacherSub1.Text;
            string sub2 = txtTeacherSub2.Text;

            Teacher updatedTeacher = new Teacher(name, telephone, email, "Teaching Staff", salary, sub1, sub2);
            return controller.UpdateTeacher(currentUserIndex, updatedTeacher);
        }

        private bool UpdateStudent(string name, string telephone, string email)
        {
            string sub1 = txtStudentSub1.Text;
            string sub2 = txtStudentSub2.Text;
            string sub3 = txtStudentSub3.Text;

            Student updatedStudent = new Student(name, telephone, email, "Student", sub1, sub2, sub3);
            return controller.UpdateStudent(currentUserIndex, updatedStudent);
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
            label1.Text = "";
        }
    }
}
