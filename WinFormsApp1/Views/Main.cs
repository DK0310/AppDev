using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Main : Form
    {
        private Form activeForm;
        private PersonController controller;

        public Main()
        {
            InitializeComponent();
            controller = new PersonController();
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
            OpenChildForm(new Add(controller), "Add Information");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View(controller), "View All Information");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Edit(controller), "Edit Information");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Delete(controller), "Delete Information");
        }
    }
}
