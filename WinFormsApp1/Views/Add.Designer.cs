namespace WinFormsApp1.Views
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxUserType = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            txtTeacherSalary = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            label1 = new Label();
            panelAdmin = new Panel();
            panelTeacher = new Panel();
            txtTeacherSub2 = new TextBox();
            txtTeacherSub1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            labelTeacherSalary = new Label();
            panelStudent = new Panel();
            txtStudentSub3 = new TextBox();
            txtStudentSub2 = new TextBox();
            txtStudentSub1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panelAdmin.SuspendLayout();
            panelTeacher.SuspendLayout();
            panelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Items.AddRange(new object[] { "Administration", "Teaching Staff", "Student" });
            comboBoxUserType.Location = new Point(118, 175);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(200, 28);
            comboBoxUserType.TabIndex = 48;
            comboBoxUserType.SelectedIndexChanged += comboBoxUserType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(22, 176);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 49;
            label6.Text = "User Type";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 44;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 127);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 43;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 79);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 42;
            label4.Text = "Telephone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 31);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 41;
            label3.Text = "Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(127, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 15);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 39;
            // 
            // txtTeacherSalary
            // 
            txtTeacherSalary.Location = new Point(110, 15);
            txtTeacherSalary.Name = "txtTeacherSalary";
            txtTeacherSalary.Size = new Size(125, 27);
            txtTeacherSalary.TabIndex = 39;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(127, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 24);
            radioButton2.TabIndex = 38;
            radioButton2.TabStop = true;
            radioButton2.Text = "Part-time";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 58);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 24);
            radioButton1.TabIndex = 37;
            radioButton1.TabStop = true;
            radioButton1.Text = "Full-time";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 93);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 36;
            label8.Text = "Working hours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 18);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 35;
            label7.Text = "Salary";
            // 
            // button1
            // 
            button1.Location = new Point(252, 389);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 34;
            button1.Text = "Confirmed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 510);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 47;
            label1.Click += label1_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.LightGray;
            panelAdmin.Controls.Add(textBox5);
            panelAdmin.Controls.Add(textBox4);
            panelAdmin.Controls.Add(radioButton2);
            panelAdmin.Controls.Add(radioButton1);
            panelAdmin.Controls.Add(label8);
            panelAdmin.Controls.Add(label7);
            panelAdmin.Location = new Point(22, 220);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(350, 130);
            panelAdmin.TabIndex = 50;
            panelAdmin.Visible = false;
            // 
            // panelTeacher
            // 
            panelTeacher.BackColor = Color.LightBlue;
            panelTeacher.Controls.Add(txtTeacherSub2);
            panelTeacher.Controls.Add(txtTeacherSub1);
            panelTeacher.Controls.Add(txtTeacherSalary);
            panelTeacher.Controls.Add(label10);
            panelTeacher.Controls.Add(label9);
            panelTeacher.Controls.Add(labelTeacherSalary);
            panelTeacher.Location = new Point(22, 220);
            panelTeacher.Name = "panelTeacher";
            panelTeacher.Size = new Size(350, 130);
            panelTeacher.TabIndex = 51;
            panelTeacher.Visible = false;
            // 
            // txtTeacherSub2
            // 
            txtTeacherSub2.Location = new Point(110, 95);
            txtTeacherSub2.Name = "txtTeacherSub2";
            txtTeacherSub2.Size = new Size(200, 27);
            txtTeacherSub2.TabIndex = 1;
            // 
            // txtTeacherSub1
            // 
            txtTeacherSub1.Location = new Point(110, 55);
            txtTeacherSub1.Name = "txtTeacherSub1";
            txtTeacherSub1.Size = new Size(200, 27);
            txtTeacherSub1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 98);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 3;
            label10.Text = "Subject 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 58);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 2;
            label9.Text = "Subject 1";
            // 
            // labelTeacherSalary
            // 
            labelTeacherSalary.AutoSize = true;
            labelTeacherSalary.Location = new Point(10, 18);
            labelTeacherSalary.Name = "labelTeacherSalary";
            labelTeacherSalary.Size = new Size(49, 20);
            labelTeacherSalary.TabIndex = 35;
            labelTeacherSalary.Text = "Salary";
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.LightYellow;
            panelStudent.Controls.Add(txtStudentSub3);
            panelStudent.Controls.Add(txtStudentSub2);
            panelStudent.Controls.Add(txtStudentSub1);
            panelStudent.Controls.Add(label13);
            panelStudent.Controls.Add(label12);
            panelStudent.Controls.Add(label11);
            panelStudent.Location = new Point(22, 220);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(350, 130);
            panelStudent.TabIndex = 52;
            panelStudent.Visible = false;
            // 
            // txtStudentSub3
            // 
            txtStudentSub3.Location = new Point(110, 95);
            txtStudentSub3.Name = "txtStudentSub3";
            txtStudentSub3.Size = new Size(200, 27);
            txtStudentSub3.TabIndex = 2;
            // 
            // txtStudentSub2
            // 
            txtStudentSub2.Location = new Point(110, 55);
            txtStudentSub2.Name = "txtStudentSub2";
            txtStudentSub2.Size = new Size(200, 27);
            txtStudentSub2.TabIndex = 1;
            // 
            // txtStudentSub1
            // 
            txtStudentSub1.Location = new Point(110, 15);
            txtStudentSub1.Name = "txtStudentSub1";
            txtStudentSub1.Size = new Size(200, 27);
            txtStudentSub1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 98);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 5;
            label13.Text = "Subject 3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 58);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 4;
            label12.Text = "Subject 2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 18);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 3;
            label11.Text = "Subject 1";
            // 
            // AdminAdded
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(panelStudent);
            Controls.Add(panelTeacher);
            Controls.Add(panelAdmin);
            Controls.Add(label6);
            Controls.Add(comboBoxUserType);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "AdminAdded";
            Text = "Add User Information";
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelTeacher.ResumeLayout(false);
            panelTeacher.PerformLayout();
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserType;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txtTeacherSalary;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Label label7;
        private Button button1;
        private Label label1;
        private Panel panelAdmin;
        private Panel panelTeacher;
        private TextBox txtTeacherSub1;
        private TextBox txtTeacherSub2;
        private Label label9;
        private Label label10;
        private Label labelTeacherSalary;
        private Panel panelStudent;
        private TextBox txtStudentSub1;
        private TextBox txtStudentSub2;
        private TextBox txtStudentSub3;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}