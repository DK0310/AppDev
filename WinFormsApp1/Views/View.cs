using System;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class View : Form
    {
        private PersonController controller;

        public View(PersonController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void View_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndexChanged -= comboBoxFilter_SelectedIndexChanged;
            comboBoxFilter.SelectedIndex = 0;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            LoadAllUsers();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            switch (comboBoxFilter.SelectedIndex)
            {
                case 0:
                    LoadAllUsers();
                    break;
                case 1:
                    LoadAdmins();
                    break;
                case 2:
                    LoadTeachers();
                    break;
                case 3:
                    LoadStudents();
                    break;
            }
        }

        private void LoadAllUsers()
        {
            var allPersons = controller.GetAllPersons();
            if (allPersons.Count == 0)
            {
                richTextBox1.Text = "No users found.";
                return;
            }

            foreach (var person in allPersons)
            {
                richTextBox1.AppendText(person.GetDetails() + "\n\n" + new string('-', 50) + "\n\n");
            }
        }

        private void LoadAdmins()
        {
            var admins = controller.GetAllAdmins();
            if (admins.Count == 0)
            {
                richTextBox1.Text = "No administrators found.";
                return;
            }

            foreach (var admin in admins)
            {
                richTextBox1.AppendText(admin.GetDetails() + "\n\n" + new string('-', 50) + "\n\n");
            }
        }

        private void LoadTeachers()
        {
            var teachers = controller.GetAllTeachers();
            if (teachers.Count == 0)
            {
                richTextBox1.Text = "No teachers found.";
                return;
            }

            foreach (var teacher in teachers)
            {
                richTextBox1.AppendText(teacher.GetDetails() + "\n\n" + new string('-', 50) + "\n\n");
            }
        }

        private void LoadStudents()
        {
            var students = controller.GetAllStudents();
            if (students.Count == 0)
            {
                richTextBox1.Text = "No students found.";
                return;
            }

            foreach (var student in students)
            {
                richTextBox1.AppendText(student.GetDetails() + "\n\n" + new string('-', 50) + "\n\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
