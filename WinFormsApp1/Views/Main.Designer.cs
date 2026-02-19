namespace WinFormsApp1.Views
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(520, 50);
            label1.TabIndex = 3;
            label1.Text = "Desktop Information System";
            label1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 654);
            panel1.TabIndex = 34;
            // 
            // button5
            // 
            button5.Location = new Point(0, 281);
            button5.Name = "button5";
            button5.Size = new Size(247, 61);
            button5.TabIndex = 38;
            button5.Text = "Delete Info";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 214);
            button4.Name = "button4";
            button4.Size = new Size(247, 61);
            button4.TabIndex = 37;
            button4.Text = "Edit Info";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 147);
            button3.Name = "button3";
            button3.Size = new Size(247, 61);
            button3.TabIndex = 36;
            button3.Text = "View Info";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 83);
            button2.Name = "button2";
            button2.Size = new Size(247, 61);
            button2.TabIndex = 35;
            button2.Text = "Add Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 86);
            panel2.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(20, 26);
            label9.Name = "label9";
            label9.Size = new Size(224, 31);
            label9.TabIndex = 26;
            label9.Text = "Management Menu";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(247, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 80);
            panel3.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(310, 26);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 27;
            label2.Text = "Welcome";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(247, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(756, 574);
            panel4.TabIndex = 36;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1003, 654);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desktop Information System";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label9;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
    }
}
