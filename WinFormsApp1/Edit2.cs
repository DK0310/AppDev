using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Edit : Form
    {
        private Main parentForm;
        private int selectedIndex = -1;

        public Edit(Main parent)
        {
            InitializeComponent();
            this.parentForm = parent;
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
                case 0: // Administration
                    LoadAdminUsers();
                    panelAdmin.Visible = true;
                    panelAdmin.BringToFront();
                    break;
                case 1: // Teaching Staff
                    LoadTeacherUsers();
                    panelTeacher.Visible = true;
                    panelTeacher.BringToFront();
                    break;
                case 2: // Student
                    LoadStudentUsers();
                    panelStudent.Visible = true;
                    panelStudent.BringToFront();
                    break;
            }
        }

        private void LoadAdminUsers()
        {
            for (int i = 0; i < parentForm.adminList.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{i + 1}. {parentForm.adminList[i].Name} - {parentForm.adminList[i].Email}");
            }
        }

        private void LoadTeacherUsers()
        {
            for (int i = 0; i < parentForm.teacherList.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{i + 1}. {parentForm.teacherList[i].Name} - {parentForm.teacherList[i].Email}");
            }
        }

        private void LoadStudentUsers()
        {
            for (int i = 0; i < parentForm.studentList.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{i + 1}. {parentForm.studentList[i].Name} - {parentForm.studentList[i].Email}");
            }
        }

        private void comboBoxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxSelectUser.SelectedIndex;
            if (selectedIndex < 0) return;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0: // Administration
                    LoadAdminData(selectedIndex);
                    break;
                case 1: // Teaching Staff
                    LoadTeacherData(selectedIndex);
                    break;
                case 2: // Student
                    LoadStudentData(selectedIndex);
                    break;
            }
        }

        private void LoadAdminData(int index)
        {
            Admin admin = parentForm.adminList[index];
            textBox1.Text = admin.Name;
            textBox2.Text = admin.Telephone;
            textBox3.Text = admin.Email;
            textBox4.Text = admin.Salary.ToString();
            textBox5.Text = admin.WorkingHours.ToString();
            radioButton1.Checked = admin.IsFullTime;
            radioButton2.Checked = !admin.IsFullTime;
        }

        private void LoadTeacherData(int index)
        {
            Teacher teacher = parentForm.teacherList[index];
            textBox1.Text = teacher.Name;
            textBox2.Text = teacher.Telephone;
            textBox3.Text = teacher.Email;
            txtTeacherSalary.Text = teacher.Salary.ToString();
            txtTeacherSub1.Text = teacher.Sub1;
            txtTeacherSub2.Text = teacher.Sub2;
        }

        private void LoadStudentData(int index)
        {
            Student student = parentForm.studentList[index];
            textBox1.Text = student.Name;
            textBox2.Text = student.Telephone;
            textBox3.Text = student.Email;
            txtStudentSub1.Text = student.Sub1;
            txtStudentSub2.Text = student.Sub2;
            txtStudentSub3.Text = student.Sub3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
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

                switch (comboBoxUserType.SelectedIndex)
                {
                    case 0: // Administration
                        UpdateAdmin(selectedIndex, name, telephone, email);
                        break;
                    case 1: // Teaching Staff
                        UpdateTeacher(selectedIndex, name, telephone, email);
                        break;
                    case 2: // Student
                        UpdateStudent(selectedIndex, name, telephone, email);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAdmin(int index, string name, string telephone, string email)
        {
            decimal salary = decimal.Parse(textBox4.Text);
            int workingHours = int.Parse(textBox5.Text);
            bool isFullTime = radioButton1.Checked;

            Admin updatedAdmin = new Admin(name, telephone, email, "Administration", salary, workingHours, isFullTime);
            parentForm.adminList[index] = updatedAdmin;

            MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = $"Updated: {updatedAdmin.Name} - {updatedAdmin.Role}";
            
            comboBoxSelectUser.Items.Clear();
            LoadAdminUsers();
            comboBoxSelectUser.SelectedIndex = index;
        }

        private void UpdateTeacher(int index, string name, string telephone, string email)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherSalary.Text) || string.IsNullOrWhiteSpace(txtTeacherSub1.Text) || string.IsNullOrWhiteSpace(txtTeacherSub2.Text))
            {
                MessageBox.Show("Please fill in salary and subjects!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salary = decimal.Parse(txtTeacherSalary.Text);
            string sub1 = txtTeacherSub1.Text;
            string sub2 = txtTeacherSub2.Text;

            Teacher updatedTeacher = new Teacher(name, telephone, email, "Teaching Staff", salary, sub1, sub2);
            parentForm.teacherList[index] = updatedTeacher;

            MessageBox.Show("Teacher updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = $"Updated: {updatedTeacher.Name} - {updatedTeacher.Role}";
            
            comboBoxSelectUser.Items.Clear();
            LoadTeacherUsers();
            comboBoxSelectUser.SelectedIndex = index;
        }

        private void UpdateStudent(int index, string name, string telephone, string email)
        {
            if (string.IsNullOrWhiteSpace(txtStudentSub1.Text) || string.IsNullOrWhiteSpace(txtStudentSub2.Text) || string.IsNullOrWhiteSpace(txtStudentSub3.Text))
            {
                MessageBox.Show("Please fill in all subjects!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sub1 = txtStudentSub1.Text;
            string sub2 = txtStudentSub2.Text;
            string sub3 = txtStudentSub3.Text;

            Student updatedStudent = new Student(name, telephone, email, "Student", sub1, sub2, sub3);
            parentForm.studentList[index] = updatedStudent;

            MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = $"Updated: {updatedStudent.Name} - {updatedStudent.Role}";
            
            comboBoxSelectUser.Items.Clear();
            LoadStudentUsers();
            comboBoxSelectUser.SelectedIndex = index;
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
            selectedIndex = -1;
        }
    }
}
