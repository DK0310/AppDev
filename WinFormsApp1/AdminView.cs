using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminView : Form
    {
        private AdminPanel parentPanel;

        public AdminView(AdminPanel parent)
        {
            InitializeComponent();
            this.parentPanel = parent;
            DisplayAdminList();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayAdminList()
        {
            richTextBox1.Text = string.Empty;
            
            if (parentPanel.adminList.Count == 0)
            {
                richTextBox1.Text = "No admin data available.";
                return;
            }

            for (int i = 0; i < parentPanel.adminList.Count; i++)
            {
                richTextBox1.Text += $"{i + 1}. {parentPanel.adminList[i].GetDetails()}\n\n";
            }
        }
    }
}
