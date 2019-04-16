namespace ClassbookProject
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registerButton = new System.Windows.Forms.Button();
            this.RegisterNameLabel = new System.Windows.Forms.Label();
            this.RegisterDateLabel = new System.Windows.Forms.Label();
            this.RegisterEmailLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterEgnLabel = new System.Windows.Forms.Label();
            this.studentOrTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectCombBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.egnBox = new System.Windows.Forms.TextBox();
            this.SelectPerson = new System.Windows.Forms.Label();
            this.PersonalInformationLabel = new System.Windows.Forms.Label();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.EGNStudetnTXB = new System.Windows.Forms.TextBox();
            this.egnStudentTBX = new System.Windows.Forms.Label();
            this.NameStudentTBX = new System.Windows.Forms.TextBox();
            this.studentLabelName = new System.Windows.Forms.Label();
            this.contactInfoPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.parentPanel.SuspendLayout();
            this.contactInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(346, 291);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 45);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterNameLabel
            // 
            this.RegisterNameLabel.AutoSize = true;
            this.RegisterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterNameLabel.ForeColor = System.Drawing.Color.White;
            this.RegisterNameLabel.Location = new System.Drawing.Point(153, 132);
            this.RegisterNameLabel.Name = "RegisterNameLabel";
            this.RegisterNameLabel.Size = new System.Drawing.Size(39, 13);
            this.RegisterNameLabel.TabIndex = 1;
            this.RegisterNameLabel.Text = "Name";
            // 
            // RegisterDateLabel
            // 
            this.RegisterDateLabel.AutoSize = true;
            this.RegisterDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterDateLabel.ForeColor = System.Drawing.Color.White;
            this.RegisterDateLabel.Location = new System.Drawing.Point(44, 60);
            this.RegisterDateLabel.Name = "RegisterDateLabel";
            this.RegisterDateLabel.Size = new System.Drawing.Size(58, 13);
            this.RegisterDateLabel.TabIndex = 2;
            this.RegisterDateLabel.Text = "Birthdate";
            // 
            // RegisterEmailLabel
            // 
            this.RegisterEmailLabel.AutoSize = true;
            this.RegisterEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterEmailLabel.ForeColor = System.Drawing.Color.White;
            this.RegisterEmailLabel.Location = new System.Drawing.Point(62, 4);
            this.RegisterEmailLabel.Name = "RegisterEmailLabel";
            this.RegisterEmailLabel.Size = new System.Drawing.Size(37, 13);
            this.RegisterEmailLabel.TabIndex = 3;
            this.RegisterEmailLabel.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number";
            // 
            // RegisterEgnLabel
            // 
            this.RegisterEgnLabel.AutoSize = true;
            this.RegisterEgnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterEgnLabel.ForeColor = System.Drawing.Color.White;
            this.RegisterEgnLabel.Location = new System.Drawing.Point(162, 159);
            this.RegisterEgnLabel.Name = "RegisterEgnLabel";
            this.RegisterEgnLabel.Size = new System.Drawing.Size(33, 13);
            this.RegisterEgnLabel.TabIndex = 5;
            this.RegisterEgnLabel.Text = "EGN";
            // 
            // studentOrTeacherComboBox
            // 
            this.studentOrTeacherComboBox.FormattingEnabled = true;
            this.studentOrTeacherComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Parent"});
            this.studentOrTeacherComboBox.Location = new System.Drawing.Point(203, 102);
            this.studentOrTeacherComboBox.Name = "studentOrTeacherComboBox";
            this.studentOrTeacherComboBox.Size = new System.Drawing.Size(100, 21);
            this.studentOrTeacherComboBox.TabIndex = 6;
            this.studentOrTeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Class";
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(97, 5);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(100, 20);
            this.classBox.TabIndex = 8;
            this.classBox.Text = "12A";
            this.classBox.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.classBox);
            this.panel1.Location = new System.Drawing.Point(106, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 44);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subjectCombBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(105, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 44);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // subjectCombBox
            // 
            this.subjectCombBox.FormattingEnabled = true;
            this.subjectCombBox.Location = new System.Drawing.Point(98, 5);
            this.subjectCombBox.Name = "subjectCombBox";
            this.subjectCombBox.Size = new System.Drawing.Size(100, 21);
            this.subjectCombBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subject";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(108, 28);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(108, 0);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(203, 129);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 13;
            // 
            // egnBox
            // 
            this.egnBox.Location = new System.Drawing.Point(203, 156);
            this.egnBox.Name = "egnBox";
            this.egnBox.Size = new System.Drawing.Size(100, 20);
            this.egnBox.TabIndex = 14;
            // 
            // SelectPerson
            // 
            this.SelectPerson.AutoSize = true;
            this.SelectPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectPerson.ForeColor = System.Drawing.Color.White;
            this.SelectPerson.Location = new System.Drawing.Point(149, 105);
            this.SelectPerson.Name = "SelectPerson";
            this.SelectPerson.Size = new System.Drawing.Size(43, 13);
            this.SelectPerson.TabIndex = 15;
            this.SelectPerson.Text = "Select";
            // 
            // PersonalInformationLabel
            // 
            this.PersonalInformationLabel.AutoSize = true;
            this.PersonalInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalInformationLabel.ForeColor = System.Drawing.Color.White;
            this.PersonalInformationLabel.Location = new System.Drawing.Point(180, 58);
            this.PersonalInformationLabel.Name = "PersonalInformationLabel";
            this.PersonalInformationLabel.Size = new System.Drawing.Size(150, 16);
            this.PersonalInformationLabel.TabIndex = 16;
            this.PersonalInformationLabel.Text = "Personal Information";
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Location = new System.Drawing.Point(108, 54);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(100, 20);
            this.dateTimeBox.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.ReturnButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 40);
            this.panel3.TabIndex = 19;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReturnButton.Image = ((System.Drawing.Image)(resources.GetObject("ReturnButton.Image")));
            this.ReturnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnButton.Location = new System.Drawing.Point(0, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(90, 40);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 315);
            this.panel4.TabIndex = 20;
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.EGNStudetnTXB);
            this.parentPanel.Controls.Add(this.egnStudentTBX);
            this.parentPanel.Controls.Add(this.NameStudentTBX);
            this.parentPanel.Controls.Add(this.studentLabelName);
            this.parentPanel.Location = new System.Drawing.Point(113, 175);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(198, 70);
            this.parentPanel.TabIndex = 3;
            this.parentPanel.Visible = false;
            // 
            // EGNStudetnTXB
            // 
            this.EGNStudetnTXB.Location = new System.Drawing.Point(90, 9);
            this.EGNStudetnTXB.Name = "EGNStudetnTXB";
            this.EGNStudetnTXB.Size = new System.Drawing.Size(100, 20);
            this.EGNStudetnTXB.TabIndex = 4;
            // 
            // egnStudentTBX
            // 
            this.egnStudentTBX.AutoSize = true;
            this.egnStudentTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egnStudentTBX.ForeColor = System.Drawing.Color.White;
            this.egnStudentTBX.Location = new System.Drawing.Point(3, 11);
            this.egnStudentTBX.Name = "egnStudentTBX";
            this.egnStudentTBX.Size = new System.Drawing.Size(81, 13);
            this.egnStudentTBX.TabIndex = 3;
            this.egnStudentTBX.Text = "Student EGN";
            this.egnStudentTBX.Click += new System.EventHandler(this.egnStudentTBX_Click);
            // 
            // NameStudentTBX
            // 
            this.NameStudentTBX.Location = new System.Drawing.Point(90, 35);
            this.NameStudentTBX.Name = "NameStudentTBX";
            this.NameStudentTBX.Size = new System.Drawing.Size(100, 20);
            this.NameStudentTBX.TabIndex = 2;
            // 
            // studentLabelName
            // 
            this.studentLabelName.AutoSize = true;
            this.studentLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentLabelName.ForeColor = System.Drawing.SystemColors.Window;
            this.studentLabelName.Location = new System.Drawing.Point(-3, 38);
            this.studentLabelName.Name = "studentLabelName";
            this.studentLabelName.Size = new System.Drawing.Size(87, 13);
            this.studentLabelName.TabIndex = 0;
            this.studentLabelName.Text = "Student Name";
            // 
            // contactInfoPanel
            // 
            this.contactInfoPanel.Controls.Add(this.RegisterEmailLabel);
            this.contactInfoPanel.Controls.Add(this.emailBox);
            this.contactInfoPanel.Controls.Add(this.label4);
            this.contactInfoPanel.Controls.Add(this.phoneNumberBox);
            this.contactInfoPanel.Controls.Add(this.RegisterDateLabel);
            this.contactInfoPanel.Controls.Add(this.dateTimeBox);
            this.contactInfoPanel.Location = new System.Drawing.Point(95, 182);
            this.contactInfoPanel.Name = "contactInfoPanel";
            this.contactInfoPanel.Size = new System.Drawing.Size(212, 76);
            this.contactInfoPanel.TabIndex = 4;
            this.contactInfoPanel.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(449, 355);
            this.Controls.Add(this.contactInfoPanel);
            this.Controls.Add(this.parentPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PersonalInformationLabel);
            this.Controls.Add(this.SelectPerson);
            this.Controls.Add(this.egnBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentOrTeacherComboBox);
            this.Controls.Add(this.RegisterEgnLabel);
            this.Controls.Add(this.RegisterNameLabel);
            this.Controls.Add(this.registerButton);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.parentPanel.ResumeLayout(false);
            this.parentPanel.PerformLayout();
            this.contactInfoPanel.ResumeLayout(false);
            this.contactInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label RegisterNameLabel;
        private System.Windows.Forms.Label RegisterDateLabel;
        private System.Windows.Forms.Label RegisterEmailLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RegisterEgnLabel;
        private System.Windows.Forms.ComboBox studentOrTeacherComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox egnBox;
        private System.Windows.Forms.Label SelectPerson;
        private System.Windows.Forms.ComboBox subjectCombBox;
        private System.Windows.Forms.Label PersonalInformationLabel;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.Label egnStudentTBX;
        private System.Windows.Forms.TextBox NameStudentTBX;
        private System.Windows.Forms.Label studentLabelName;
        private System.Windows.Forms.Panel contactInfoPanel;
        private System.Windows.Forms.TextBox EGNStudetnTXB;
    }
}