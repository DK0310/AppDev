using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminAdded : Form
    {
        private AdminPanel parentPanel;

        public AdminAdded(AdminPanel parent)
        {
            InitializeComponent();
            this.parentPanel = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string telephone = textBox2.Text;
                string email = textBox3.Text;
                decimal salary = decimal.Parse(textBox4.Text);
                int workingHours = int.Parse(textBox5.Text);
                bool isFullTime = radioButton1.Checked;

                Admin newAdmin = new Admin(name, telephone, email, "Administration", salary, workingHours, isFullTime);
                parentPanel.adminList.Add(newAdmin);

                MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label1.Text = $"Admin: {newAdmin.Name}, Salary: {newAdmin.Salary:C}, Working Hours: {newAdmin.WorkingHours}, Full Time: {newAdmin.IsFullTime}";

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
