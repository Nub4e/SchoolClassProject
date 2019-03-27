namespace WindowsFormsApplication2
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.addMarkButton = new System.Windows.Forms.Button();
            this.addMarkTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.selectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dragControl1 = new WindowsFormsApplication2.DragControl();
            this.dragControl2 = new WindowsFormsApplication2.DragControl();
            this.markDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 400);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
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
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 41);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(138, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 359);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.markDateTimePicker);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.addMarkButton);
            this.panel6.Controls.Add(this.addMarkTextBox);
            this.panel6.Location = new System.Drawing.Point(521, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 190);
            this.panel6.TabIndex = 11;
            this.panel6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(56, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add mark";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMarkButton
            // 
            this.addMarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(8)))), ((int)(((byte)(155)))));
            this.addMarkButton.FlatAppearance.BorderSize = 0;
            this.addMarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMarkButton.Location = new System.Drawing.Point(59, 146);
            this.addMarkButton.Name = "addMarkButton";
            this.addMarkButton.Size = new System.Drawing.Size(100, 41);
            this.addMarkButton.TabIndex = 8;
            this.addMarkButton.Text = "Add mark";
            this.addMarkButton.UseVisualStyleBackColor = false;
            this.addMarkButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addMarkTextBox
            // 
            this.addMarkTextBox.Location = new System.Drawing.Point(44, 34);
            this.addMarkTextBox.Name = "addMarkTextBox";
            this.addMarkTextBox.Size = new System.Drawing.Size(100, 20);
            this.addMarkTextBox.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.selectClassComboBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(37, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 270);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.selectStudentComboBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(13, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 7;
            this.panel5.Visible = false;
            // 
            // selectStudentComboBox
            // 
            this.selectStudentComboBox.FormattingEnabled = true;
            this.selectStudentComboBox.Location = new System.Drawing.Point(40, 48);
            this.selectStudentComboBox.Name = "selectStudentComboBox";
            this.selectStudentComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectStudentComboBox.TabIndex = 7;
            this.selectStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.selectStudentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select student:";
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Location = new System.Drawing.Point(53, 35);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectClassComboBox.TabIndex = 4;
            this.selectClassComboBox.SelectedValueChanged += new System.EventHandler(this.selectClassComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select class:";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel2;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panel1;
            // 
            // markDateTimePicker
            // 
            this.markDateTimePicker.Location = new System.Drawing.Point(3, 60);
            this.markDateTimePicker.Name = "markDateTimePicker";
            this.markDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.markDateTimePicker.TabIndex = 11;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addMarkTextBox;
        private System.Windows.Forms.Button addMarkButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox selectStudentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker markDateTimePicker;
    }
}