using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminPanel : Form
    {
        private Form activeForm;
        
        // Shared data for all child forms
        public List<Admin> adminList = new List<Admin>();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, string title)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label2.Text = title;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminAdded(this), "Added Information");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminView(this), "View Information"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Edit Information";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete Information";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
