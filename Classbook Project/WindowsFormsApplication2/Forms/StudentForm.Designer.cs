namespace ClassbookProject
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentSubjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedMarksListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.averageMark = new System.Windows.Forms.Label();
            this.classContactInfoListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.headTeacherTextBox = new System.Windows.Forms.TextBox();
            this.dragControl1 = new ClassbookProject.DragControl();
            this.dragControl2 = new ClassbookProject.DragControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 349);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(138, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 51);
            this.panel2.TabIndex = 1;
            // 
            // studentSubjectsComboBox
            // 
            this.studentSubjectsComboBox.FormattingEnabled = true;
            this.studentSubjectsComboBox.Location = new System.Drawing.Point(181, 125);
            this.studentSubjectsComboBox.Name = "studentSubjectsComboBox";
            this.studentSubjectsComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentSubjectsComboBox.TabIndex = 2;
            this.studentSubjectsComboBox.SelectedValueChanged += new System.EventHandler(this.studentSubjectsComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select subject";
            // 
            // selectedMarksListBox
            // 
            this.selectedMarksListBox.FormattingEnabled = true;
            this.selectedMarksListBox.HorizontalScrollbar = true;
            this.selectedMarksListBox.Items.AddRange(new object[] {
            "No marks"});
            this.selectedMarksListBox.Location = new System.Drawing.Point(181, 196);
            this.selectedMarksListBox.Name = "selectedMarksListBox";
            this.selectedMarksListBox.Size = new System.Drawing.Size(312, 108);
            this.selectedMarksListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "All marks";
            // 
            // averageMark
            // 
            this.averageMark.AutoSize = true;
            this.averageMark.Location = new System.Drawing.Point(178, 307);
            this.averageMark.Name = "averageMark";
            this.averageMark.Size = new System.Drawing.Size(70, 13);
            this.averageMark.TabIndex = 6;
            this.averageMark.Text = "averageMark";
            this.averageMark.Visible = false;
            // 
            // classContactInfoListBox
            // 
            this.classContactInfoListBox.FormattingEnabled = true;
            this.classContactInfoListBox.HorizontalScrollbar = true;
            this.classContactInfoListBox.Location = new System.Drawing.Point(549, 196);
            this.classContactInfoListBox.Name = "classContactInfoListBox";
            this.classContactInfoListBox.Size = new System.Drawing.Size(371, 108);
            this.classContactInfoListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // headTeacherTextBox
            // 
            this.headTeacherTextBox.Location = new System.Drawing.Point(549, 170);
            this.headTeacherTextBox.Name = "headTeacherTextBox";
            this.headTeacherTextBox.ReadOnly = true;
            this.headTeacherTextBox.Size = new System.Drawing.Size(371, 20);
            this.headTeacherTextBox.TabIndex = 10;
            this.headTeacherTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel3;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panel2;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(950, 400);
            this.Controls.Add(this.headTeacherTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classContactInfoListBox);
            this.Controls.Add(this.averageMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedMarksListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentSubjectsComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox studentSubjectsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox selectedMarksListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label averageMark;
        private System.Windows.Forms.ListBox classContactInfoListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox headTeacherTextBox;
        private System.Windows.Forms.Panel panel3;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}