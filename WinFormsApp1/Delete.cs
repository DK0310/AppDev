using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Delete : Form
    {
        private Main parentForm;
        private int selectedIndex = -1;

        public Delete(Main parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            comboBoxUserType.SelectedIndex = 0;
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectUser.Items.Clear();
            comboBoxSelectUser.Text = "";
            richTextBox1.Clear();
            selectedIndex = -1;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0: // Administration
                    LoadAdminUsers();
                    break;
                case 1: // Teaching Staff
                    LoadTeacherUsers();
                    break;
                case 2: // Student
                    LoadStudentUsers();
                    break;
            }
        }

        private void LoadAdminUsers()
        {
            if (parentForm.adminList.Count == 0)
            {
                richTextBox1.Text = "No admin data available to delete.";
                return;
            }

            for (int i = 0; i < parentForm.adminList.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{i + 1}. {parentForm.adminList[i].Name} - {parentForm.adminList[i].Email}");
            }
        }

        private void LoadTeacherUsers()
        {
            if (parentForm.teacherList.Count == 0)
            {
                richTextBox1.Text = "No teacher data available to delete.";
                return;
            }

            for (int i = 0; i < parentForm.teacherList.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{i + 1}. {parentForm.teacherList[i].Name} - {parentForm.teacherList[i].Email}");
            }
        }

        private void LoadStudentUsers()
        {
            if (parentForm.studentList.Count == 0)
            {
                richTextBox1.Text = "No student data available to delete.";
                return;
            }

            for (int i = 0; i < parentForm.studentList.Count; i++)
            {
                comboBoxSelectUser.Items.Add($"{i + 1}. {parentForm.studentList[i].Name} - {parentForm.studentList[i].Email}");
            }
        }

        private void comboBoxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxSelectUser.SelectedIndex;
            if (selectedIndex < 0) return;

            richTextBox1.Clear();

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0: // Administration
                    DisplayAdminDetails(selectedIndex);
                    break;
                case 1: // Teaching Staff
                    DisplayTeacherDetails(selectedIndex);
                    break;
                case 2: // Student
                    DisplayStudentDetails(selectedIndex);
                    break;
            }
        }

        private void DisplayAdminDetails(int index)
        {
            Admin admin = parentForm.adminList[index];
            richTextBox1.AppendText("???????????????????????????????????????\n");
            richTextBox1.AppendText("        ADMINISTRATION DETAILS\n");
            richTextBox1.AppendText("???????????????????????????????????????\n\n");
            richTextBox1.AppendText(admin.GetDetails());
            richTextBox1.AppendText("\n???????????????????????????????????????\n");
        }

        private void DisplayTeacherDetails(int index)
        {
            Teacher teacher = parentForm.teacherList[index];
            richTextBox1.AppendText("???????????????????????????????????????\n");
            richTextBox1.AppendText("         TEACHER DETAILS\n");
            richTextBox1.AppendText("???????????????????????????????????????\n\n");
            richTextBox1.AppendText(teacher.GetDetails());
            richTextBox1.AppendText("\n???????????????????????????????????????\n");
        }

        private void DisplayStudentDetails(int index)
        {
            Student student = parentForm.studentList[index];
            richTextBox1.AppendText("???????????????????????????????????????\n");
            richTextBox1.AppendText("         STUDENT DETAILS\n");
            richTextBox1.AppendText("???????????????????????????????????????\n\n");
            richTextBox1.AppendText(student.GetDetails());
            richTextBox1.AppendText("\n???????????????????????????????????????\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a user to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userName = "";
            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    userName = parentForm.adminList[selectedIndex].Name;
                    break;
                case 1:
                    userName = parentForm.teacherList[selectedIndex].Name;
                    break;
                case 2:
                    userName = parentForm.studentList[selectedIndex].Name;
                    break;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete user:\n\n{userName}?\n\nThis action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DeleteUser();
            }
        }

        private void DeleteUser()
        {
            string userName = "";

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0: // Administration
                    userName = parentForm.adminList[selectedIndex].Name;
                    parentForm.adminList.RemoveAt(selectedIndex);
                    break;
                case 1: // Teaching Staff
                    userName = parentForm.teacherList[selectedIndex].Name;
                    parentForm.teacherList.RemoveAt(selectedIndex);
                    break;
                case 2: // Student
                    userName = parentForm.studentList[selectedIndex].Name;
                    parentForm.studentList.RemoveAt(selectedIndex);
                    break;
            }

            MessageBox.Show($"User '{userName}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label2.Text = $"Deleted: {userName}";

            comboBoxSelectUser.Items.Clear();
            richTextBox1.Clear();
            selectedIndex = -1;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    LoadAdminUsers();
                    break;
                case 1:
                    LoadTeacherUsers();
                    break;
                case 2:
                    LoadStudentUsers();
                    break;
            }
        }
    }
}
