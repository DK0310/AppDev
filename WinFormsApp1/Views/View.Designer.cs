namespace WinFormsApp1.Views
{
    partial class View
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
            richTextBox1 = new RichTextBox();
            comboBoxFilter = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "All Users", "Administration", "Teaching Staff", "Students" });
            comboBoxFilter.Location = new Point(150, 15);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(200, 28);
            comboBoxFilter.TabIndex = 1;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 2;
            label1.Text = "Filter by Role";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(855, 416);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 476);
            Controls.Add(label1);
            Controls.Add(comboBoxFilter);
            Controls.Add(richTextBox1);
            Name = "View";
            Text = "View";
            Load += View_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox comboBoxFilter;
        private Label label1;
    }
}
