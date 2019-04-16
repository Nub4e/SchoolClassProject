namespace ClassbookProject
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
            this.teacherName = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeMarkPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.RemoveList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.addMarkPanel = new System.Windows.Forms.Panel();
            this.markDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.addMarkButton = new System.Windows.Forms.Button();
            this.addMarkTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.principalPanel = new System.Windows.Forms.Panel();
            this.PermissionComboBox = new System.Windows.Forms.ComboBox();
            this.addSubjectPanel = new System.Windows.Forms.Panel();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.subjectNameTxtBox = new System.Windows.Forms.TextBox();
            this.addPrincipalPannel = new System.Windows.Forms.Panel();
            this.nonPrincipalTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.addVicePrincipal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addClassPanel = new System.Windows.Forms.Panel();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nonHeadTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.permissionsComboBox = new System.Windows.Forms.ComboBox();
            this.permissionsCheckBox = new System.Windows.Forms.CheckBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.selectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dragControl1 = new ClassbookProject.DragControl();
            this.dragControl2 = new ClassbookProject.DragControl();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.removeMarkPanel.SuspendLayout();
            this.addMarkPanel.SuspendLayout();
            this.principalPanel.SuspendLayout();
            this.addSubjectPanel.SuspendLayout();
            this.addPrincipalPannel.SuspendLayout();
            this.addClassPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.teacherName);
            this.panel2.Controls.Add(this.welcomeLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 477);
            this.panel2.TabIndex = 1;
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherName.ForeColor = System.Drawing.Color.LightPink;
            this.teacherName.Location = new System.Drawing.Point(13, 88);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(107, 16);
            this.teacherName.TabIndex = 3;
            this.teacherName.Text = "TeacherName";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.LightPink;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 65);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(87, 20);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome,";
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
            this.panel1.Size = new System.Drawing.Size(589, 41);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.removeMarkPanel);
            this.panel3.Controls.Add(this.Update);
            this.panel3.Controls.Add(this.Remove);
            this.panel3.Controls.Add(this.addMarkPanel);
            this.panel3.Controls.Add(this.Add);
            this.panel3.Controls.Add(this.principalPanel);
            this.panel3.Controls.Add(this.permissionsCheckBox);
            this.panel3.Controls.Add(this.mainPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(138, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 436);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // removeMarkPanel
            // 
            this.removeMarkPanel.Controls.Add(this.button2);
            this.removeMarkPanel.Controls.Add(this.RemoveList);
            this.removeMarkPanel.Controls.Add(this.label9);
            this.removeMarkPanel.Location = new System.Drawing.Point(39, 269);
            this.removeMarkPanel.Name = "removeMarkPanel";
            this.removeMarkPanel.Size = new System.Drawing.Size(200, 149);
            this.removeMarkPanel.TabIndex = 12;
            this.removeMarkPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(50, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove Mark";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RemoveList
            // 
            this.RemoveList.FormattingEnabled = true;
            this.RemoveList.Location = new System.Drawing.Point(38, 42);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(121, 21);
            this.RemoveList.TabIndex = 1;
            this.RemoveList.SelectedIndexChanged += new System.EventHandler(this.RemoveList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Remove Mark";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(219, 66);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 17;
            this.Update.Text = "button4";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(107, 66);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(91, 23);
            this.Remove.TabIndex = 16;
            this.Remove.Text = "Remove Mark";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click_1);
            // 
            // addMarkPanel
            // 
            this.addMarkPanel.Controls.Add(this.markDateTimePicker);
            this.addMarkPanel.Controls.Add(this.label3);
            this.addMarkPanel.Controls.Add(this.addMarkButton);
            this.addMarkPanel.Controls.Add(this.addMarkTextBox);
            this.addMarkPanel.Location = new System.Drawing.Point(39, 269);
            this.addMarkPanel.Name = "addMarkPanel";
            this.addMarkPanel.Size = new System.Drawing.Size(200, 155);
            this.addMarkPanel.TabIndex = 11;
            this.addMarkPanel.Visible = false;
            // 
            // markDateTimePicker
            // 
            this.markDateTimePicker.Location = new System.Drawing.Point(3, 60);
            this.markDateTimePicker.Name = "markDateTimePicker";
            this.markDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.markDateTimePicker.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(64, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add mark";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMarkButton
            // 
            this.addMarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.addMarkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMarkButton.FlatAppearance.BorderSize = 0;
            this.addMarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMarkButton.ForeColor = System.Drawing.Color.White;
            this.addMarkButton.Location = new System.Drawing.Point(44, 98);
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
            this.addMarkTextBox.Size = new System.Drawing.Size(115, 20);
            this.addMarkTextBox.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(24, 66);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add Mark";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddMark_Click);
            // 
            // principalPanel
            // 
            this.principalPanel.Controls.Add(this.PermissionComboBox);
            this.principalPanel.Controls.Add(this.addSubjectPanel);
            this.principalPanel.Controls.Add(this.addPrincipalPannel);
            this.principalPanel.Controls.Add(this.addClassPanel);
            this.principalPanel.Controls.Add(this.permissionsComboBox);
            this.principalPanel.Location = new System.Drawing.Point(327, 95);
            this.principalPanel.Name = "principalPanel";
            this.principalPanel.Size = new System.Drawing.Size(244, 300);
            this.principalPanel.TabIndex = 13;
            this.principalPanel.Visible = false;
            // 
            // PermissionComboBox
            // 
            this.PermissionComboBox.FormattingEnabled = true;
            this.PermissionComboBox.Items.AddRange(new object[] {
            "Add a class",
            "Add a subject",
            "Add a vice-principal"});
            this.PermissionComboBox.Location = new System.Drawing.Point(64, 15);
            this.PermissionComboBox.Name = "PermissionComboBox";
            this.PermissionComboBox.Size = new System.Drawing.Size(121, 21);
            this.PermissionComboBox.TabIndex = 14;
            this.PermissionComboBox.SelectedIndexChanged += new System.EventHandler(this.adminComboBox_SelectedIndexChanged);
            this.PermissionComboBox.SelectedValueChanged += new System.EventHandler(this.permissionsComboBox_SelectedValueChanged);
            // 
            // addSubjectPanel
            // 
            this.addSubjectPanel.Controls.Add(this.addSubjectBtn);
            this.addSubjectPanel.Controls.Add(this.label7);
            this.addSubjectPanel.Controls.Add(this.subjectNameTxtBox);
            this.addSubjectPanel.Location = new System.Drawing.Point(29, 47);
            this.addSubjectPanel.Name = "addSubjectPanel";
            this.addSubjectPanel.Size = new System.Drawing.Size(200, 164);
            this.addSubjectPanel.TabIndex = 13;
            this.addSubjectPanel.Visible = false;
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.addSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSubjectBtn.FlatAppearance.BorderSize = 0;
            this.addSubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSubjectBtn.ForeColor = System.Drawing.Color.White;
            this.addSubjectBtn.Location = new System.Drawing.Point(43, 79);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(100, 41);
            this.addSubjectBtn.TabIndex = 13;
            this.addSubjectBtn.Text = "Add subject";
            this.addSubjectBtn.UseVisualStyleBackColor = false;
            this.addSubjectBtn.Click += new System.EventHandler(this.addSubjectBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(41, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Subject name:";
            // 
            // subjectNameTxtBox
            // 
            this.subjectNameTxtBox.Location = new System.Drawing.Point(34, 37);
            this.subjectNameTxtBox.Name = "subjectNameTxtBox";
            this.subjectNameTxtBox.Size = new System.Drawing.Size(123, 20);
            this.subjectNameTxtBox.TabIndex = 0;
            // 
            // addPrincipalPannel
            // 
            this.addPrincipalPannel.Controls.Add(this.nonPrincipalTeacherComboBox);
            this.addPrincipalPannel.Controls.Add(this.addVicePrincipal);
            this.addPrincipalPannel.Controls.Add(this.label8);
            this.addPrincipalPannel.Location = new System.Drawing.Point(29, 48);
            this.addPrincipalPannel.Name = "addPrincipalPannel";
            this.addPrincipalPannel.Size = new System.Drawing.Size(200, 129);
            this.addPrincipalPannel.TabIndex = 14;
            this.addPrincipalPannel.Visible = false;
            // 
            // nonPrincipalTeacherComboBox
            // 
            this.nonPrincipalTeacherComboBox.FormattingEnabled = true;
            this.nonPrincipalTeacherComboBox.Location = new System.Drawing.Point(35, 38);
            this.nonPrincipalTeacherComboBox.Name = "nonPrincipalTeacherComboBox";
            this.nonPrincipalTeacherComboBox.Size = new System.Drawing.Size(121, 21);
            this.nonPrincipalTeacherComboBox.TabIndex = 15;
            // 
            // addVicePrincipal
            // 
            this.addVicePrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.addVicePrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVicePrincipal.FlatAppearance.BorderSize = 0;
            this.addVicePrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVicePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVicePrincipal.ForeColor = System.Drawing.Color.White;
            this.addVicePrincipal.Location = new System.Drawing.Point(45, 78);
            this.addVicePrincipal.Name = "addVicePrincipal";
            this.addVicePrincipal.Size = new System.Drawing.Size(100, 41);
            this.addVicePrincipal.TabIndex = 14;
            this.addVicePrincipal.Text = "Add vice-principal";
            this.addVicePrincipal.UseVisualStyleBackColor = false;
            this.addVicePrincipal.Click += new System.EventHandler(this.addVicePrincipal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(37, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Select teacher:";
            // 
            // addClassPanel
            // 
            this.addClassPanel.Controls.Add(this.addClassBtn);
            this.addClassPanel.Controls.Add(this.label6);
            this.addClassPanel.Controls.Add(this.label4);
            this.addClassPanel.Controls.Add(this.label5);
            this.addClassPanel.Controls.Add(this.nonHeadTeacherComboBox);
            this.addClassPanel.Controls.Add(this.letterTextBox);
            this.addClassPanel.Controls.Add(this.gradeComboBox);
            this.addClassPanel.Location = new System.Drawing.Point(29, 47);
            this.addClassPanel.Name = "addClassPanel";
            this.addClassPanel.Size = new System.Drawing.Size(200, 206);
            this.addClassPanel.TabIndex = 1;
            this.addClassPanel.Visible = false;
            // 
            // addClassBtn
            // 
            this.addClassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.addClassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClassBtn.FlatAppearance.BorderSize = 0;
            this.addClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClassBtn.ForeColor = System.Drawing.Color.White;
            this.addClassBtn.Location = new System.Drawing.Point(44, 154);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(100, 41);
            this.addClassBtn.TabIndex = 12;
            this.addClassBtn.Text = "Add class";
            this.addClassBtn.UseVisualStyleBackColor = false;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(41, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Head Teacher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(69, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Letter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(69, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grade:";
            // 
            // nonHeadTeacherComboBox
            // 
            this.nonHeadTeacherComboBox.FormattingEnabled = true;
            this.nonHeadTeacherComboBox.Location = new System.Drawing.Point(36, 127);
            this.nonHeadTeacherComboBox.Name = "nonHeadTeacherComboBox";
            this.nonHeadTeacherComboBox.Size = new System.Drawing.Size(121, 21);
            this.nonHeadTeacherComboBox.TabIndex = 2;
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(36, 80);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(121, 20);
            this.letterTextBox.TabIndex = 1;
            this.letterTextBox.Text = "AA";
            this.letterTextBox.Click += new System.EventHandler(this.letterTextBox_Click);
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.gradeComboBox.Location = new System.Drawing.Point(36, 29);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradeComboBox.TabIndex = 0;
            // 
            // permissionsComboBox
            // 
            this.permissionsComboBox.FormattingEnabled = true;
            this.permissionsComboBox.Items.AddRange(new object[] {
            "Add a class",
            "Add a subject",
            "Add a vice-principal"});
            this.permissionsComboBox.Location = new System.Drawing.Point(-390, 579);
            this.permissionsComboBox.Name = "permissionsComboBox";
            this.permissionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.permissionsComboBox.TabIndex = 0;
            this.permissionsComboBox.SelectedValueChanged += new System.EventHandler(this.permissionsComboBox_SelectedValueChanged);
            // 
            // permissionsCheckBox
            // 
            this.permissionsCheckBox.AutoSize = true;
            this.permissionsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.permissionsCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.permissionsCheckBox.Location = new System.Drawing.Point(327, 21);
            this.permissionsCheckBox.Name = "permissionsCheckBox";
            this.permissionsCheckBox.Size = new System.Drawing.Size(129, 20);
            this.permissionsCheckBox.TabIndex = 12;
            this.permissionsCheckBox.Text = "Principal Menu";
            this.permissionsCheckBox.UseVisualStyleBackColor = true;
            this.permissionsCheckBox.CheckedChanged += new System.EventHandler(this.permissionsCheckBox_CheckedChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel5);
            this.mainPanel.Controls.Add(this.selectClassComboBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(24, 95);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(270, 338);
            this.mainPanel.TabIndex = 9;
            this.mainPanel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.selectStudentComboBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(15, 55);
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
            this.selectStudentComboBox.SelectedValueChanged += new System.EventHandler(this.selectStudentComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(47, 31);
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
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.removeMarkPanel.ResumeLayout(false);
            this.removeMarkPanel.PerformLayout();
            this.addMarkPanel.ResumeLayout(false);
            this.addMarkPanel.PerformLayout();
            this.principalPanel.ResumeLayout(false);
            this.addSubjectPanel.ResumeLayout(false);
            this.addSubjectPanel.PerformLayout();
            this.addPrincipalPannel.ResumeLayout(false);
            this.addPrincipalPannel.PerformLayout();
            this.addClassPanel.ResumeLayout(false);
            this.addClassPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addMarkTextBox;
        private System.Windows.Forms.Button addMarkButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox selectStudentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel addMarkPanel;
        private System.Windows.Forms.DateTimePicker markDateTimePicker;
        private System.Windows.Forms.CheckBox permissionsCheckBox;
        private System.Windows.Forms.Panel principalPanel;
        private System.Windows.Forms.ComboBox permissionsComboBox;
        private System.Windows.Forms.Panel addClassPanel;
        private System.Windows.Forms.Button addClassBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nonHeadTeacherComboBox;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.Panel addSubjectPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox subjectNameTxtBox;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.Panel addPrincipalPannel;
        private System.Windows.Forms.ComboBox nonPrincipalTeacherComboBox;
        private System.Windows.Forms.Button addVicePrincipal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel removeMarkPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox RemoveList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PermissionComboBox;
    }
}