namespace WinFormsApp1.Views
{
    partial class Delete
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
            comboBoxSelectUser = new ComboBox();
            label14 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Items.AddRange(new object[] { "Administration", "Teaching Staff", "Student" });
            comboBoxUserType.Location = new Point(118, 28);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(200, 28);
            comboBoxUserType.TabIndex = 48;
            comboBoxUserType.SelectedIndexChanged += comboBoxUserType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(22, 29);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 49;
            label6.Text = "User Type";
            // 
            // comboBoxSelectUser
            // 
            comboBoxSelectUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectUser.FormattingEnabled = true;
            comboBoxSelectUser.Location = new Point(118, 76);
            comboBoxSelectUser.Name = "comboBoxSelectUser";
            comboBoxSelectUser.Size = new Size(400, 28);
            comboBoxSelectUser.TabIndex = 50;
            comboBoxSelectUser.SelectedIndexChanged += comboBoxSelectUser_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(22, 77);
            label14.Name = "label14";
            label14.Size = new Size(93, 23);
            label14.TabIndex = 51;
            label14.Text = "Select User";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.Font = new Font("Consolas", 9F);
            richTextBox1.Location = new Point(22, 145);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(550, 300);
            richTextBox1.TabIndex = 52;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(22, 119);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 53;
            label1.Text = "User Details:";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(452, 461);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 54;
            button1.Text = "Delete User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Green;
            label2.Location = new Point(22, 510);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 55;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(label14);
            Controls.Add(comboBoxSelectUser);
            Controls.Add(label6);
            Controls.Add(comboBoxUserType);
            Name = "Delete";
            Text = "Delete User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserType;
        private Label label6;
        private ComboBox comboBoxSelectUser;
        private Label label14;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}
