namespace WinFormsApp1
{
    public partial class Main : Form
    {
        private Form activeForm;
        
        // Shared data for all user groups
        public List<Admin> adminList = new List<Admin>();
        public List<Teacher> teacherList = new List<Teacher>();
        public List<Student> studentList = new List<Student>();

        public Main()
        {
            InitializeComponent();
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
            OpenChildForm(new Add(this), "Add Information");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View(this), "View All Information");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Edit(this), "Edit Information");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Delete(this), "Delete Information");
        }
    }
}
