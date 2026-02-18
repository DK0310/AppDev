using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class View : Form
    {
        private Main parentForm;

        public View(Main parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void View_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
            DisplayData();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            richTextBox1.Clear();

            switch (comboBoxFilter.SelectedIndex)
            {
                case 0: // All Users
                    DisplayAllData();
                    break;
                case 1: // Administration
                    DisplayAdmins();
                    break;
                case 2: // Teaching Staff
                    DisplayTeachers();
                    break;
                case 3: // Students
                    DisplayStudents();
                    break;
            }
        }

        private void DisplayAllData()
        {
            richTextBox1.AppendText("═══════════════════════════════════════════════\n");
            richTextBox1.AppendText("              ADMINISTRATION STAFF\n");
            richTextBox1.AppendText("═══════════════════════════════════════════════\n\n");

            if (parentForm.adminList.Count == 0)
            {
                richTextBox1.AppendText("No admin data available.\n\n");
            }
            else
            {
                for (int i = 0; i < parentForm.adminList.Count; i++)
                {
                    richTextBox1.AppendText($"[{i + 1}]\n{parentForm.adminList[i].GetDetails()}\n");
                    richTextBox1.AppendText("───────────────────────────────────────────────\n\n");
                }
            }

            richTextBox1.AppendText("\n═══════════════════════════════════════════════\n");
            richTextBox1.AppendText("              TEACHING STAFF\n");
            richTextBox1.AppendText("═══════════════════════════════════════════════\n\n");

            if (parentForm.teacherList.Count == 0)
            {
                richTextBox1.AppendText("No teacher data available.\n\n");
            }
            else
            {
                for (int i = 0; i < parentForm.teacherList.Count; i++)
                {
                    richTextBox1.AppendText($"[{i + 1}]\n{parentForm.teacherList[i].GetDetails()}\n");
                    richTextBox1.AppendText("───────────────────────────────────────────────\n\n");
                }
            }

            richTextBox1.AppendText("\n═══════════════════════════════════════════════\n");
            richTextBox1.AppendText("                   STUDENTS\n");
            richTextBox1.AppendText("═══════════════════════════════════════════════\n\n");

            if (parentForm.studentList.Count == 0)
            {
                richTextBox1.AppendText("No student data available.\n\n");
            }
            else
            {
                for (int i = 0; i < parentForm.studentList.Count; i++)
                {
                    richTextBox1.AppendText($"[{i + 1}]\n{parentForm.studentList[i].GetDetails()}\n");
                    richTextBox1.AppendText("───────────────────────────────────────────────\n\n");
                }
            }
        }

        private void DisplayAdmins()
        {
            richTextBox1.AppendText("═══════════════════════════════════════════════\n");
            richTextBox1.AppendText("              ADMINISTRATION STAFF\n");
            richTextBox1.AppendText("═══════════════════════════════════════════════\n\n");

            if (parentForm.adminList.Count == 0)
            {
                richTextBox1.AppendText("No admin data available.");
                return;
            }

            for (int i = 0; i < parentForm.adminList.Count; i++)
            {
                richTextBox1.AppendText($"[{i + 1}]\n{parentForm.adminList[i].GetDetails()}\n");
                richTextBox1.AppendText("───────────────────────────────────────────────\n\n");
            }
        }

        private void DisplayTeachers()
        {
            richTextBox1.AppendText("═══════════════════════════════════════════════\n");
            richTextBox1.AppendText("              TEACHING STAFF\n");
            richTextBox1.AppendText("═══════════════════════════════════════════════\n\n");

            if (parentForm.teacherList.Count == 0)
            {
                richTextBox1.AppendText("No teacher data available.");
                return;
            }

            for (int i = 0; i < parentForm.teacherList.Count; i++)
            {
                richTextBox1.AppendText($"[{i + 1}]\n{parentForm.teacherList[i].GetDetails()}\n");
                richTextBox1.AppendText("───────────────────────────────────────────────\n\n");
            }
        }

        private void DisplayStudents()
        {
            richTextBox1.AppendText("═══════════════════════════════════════════════\n");
            richTextBox1.AppendText("                   STUDENTS\n");
            richTextBox1.AppendText("═══════════════════════════════════════════════\n\n");

            if (parentForm.studentList.Count == 0)
            {
                richTextBox1.AppendText("No student data available.");
                return;
            }

            for (int i = 0; i < parentForm.studentList.Count; i++)
            {
                richTextBox1.AppendText($"[{i + 1}]\n{parentForm.studentList[i].GetDetails()}\n");
                richTextBox1.AppendText("───────────────────────────────────────────────\n\n");
            }
        }
    }
}
