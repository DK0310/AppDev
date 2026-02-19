using System;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Delete : Form
    {
        private PersonController controller;
        private int currentUserIndex = -1;

        public Delete(PersonController controller)
        {
            InitializeComponent();
            this.controller = controller;
            comboBoxUserType.SelectedIndex = 0;
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectUser.Items.Clear();
            comboBoxSelectUser.Text = "";
            richTextBox1.Clear();
            label2.Text = "";
            currentUserIndex = -1;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    LoadAdminsList();
                    break;
                case 1:
                    LoadTeachersList();
                    break;
                case 2:
                    LoadStudentsList();
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

            richTextBox1.Clear();

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    var admin = controller.GetAdmin(currentUserIndex);
                    if (admin != null)
                        richTextBox1.Text = admin.GetDetails();
                    break;
                case 1:
                    var teacher = controller.GetTeacher(currentUserIndex);
                    if (teacher != null)
                        richTextBox1.Text = teacher.GetDetails();
                    break;
                case 2:
                    var student = controller.GetStudent(currentUserIndex);
                    if (student != null)
                        richTextBox1.Text = student.GetDetails();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentUserIndex < 0)
            {
                MessageBox.Show("Please select a user to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                bool success = false;

                switch (comboBoxUserType.SelectedIndex)
                {
                    case 0:
                        success = controller.DeleteAdmin(currentUserIndex);
                        break;
                    case 1:
                        success = controller.DeleteTeacher(currentUserIndex);
                        break;
                    case 2:
                        success = controller.DeleteStudent(currentUserIndex);
                        break;
                }

                if (success)
                {
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label2.Text = "User deleted successfully!";
                    richTextBox1.Clear();
                    comboBoxUserType_SelectedIndexChanged(sender, e);
                    currentUserIndex = -1;
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
