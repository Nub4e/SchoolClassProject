namespace ClassbookProject
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentSubjectsComboBox = new System.Windows.Forms.ComboBox();
            this.SelectSubjectLabel = new System.Windows.Forms.Label();
            this.selectedMarksListBox = new System.Windows.Forms.ListBox();
            this.AllMarksLabel = new System.Windows.Forms.Label();
            this.averageMark = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EventBar = new System.Windows.Forms.Panel();
            this.EventDescriptionLabel = new System.Windows.Forms.Label();
            this.closeEventBarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.EventBar.SuspendLayout();
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
            this.panel3.Controls.Add(this.studentNameLabel);
            this.panel3.Controls.Add(this.parentNameLabel);
            this.panel3.Controls.Add(this.welcomeLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 349);
            this.panel3.TabIndex = 3;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentNameLabel.ForeColor = System.Drawing.Color.LightPink;
            this.studentNameLabel.Location = new System.Drawing.Point(3, 100);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(101, 16);
            this.studentNameLabel.TabIndex = 13;
            this.studentNameLabel.Text = "StudentName";
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentNameLabel.ForeColor = System.Drawing.Color.LightPink;
            this.parentNameLabel.Location = new System.Drawing.Point(3, 49);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(94, 16);
            this.parentNameLabel.TabIndex = 12;
            this.parentNameLabel.Text = "ParentName";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.LightPink;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(87, 20);
            this.welcomeLabel.TabIndex = 11;
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
            this.studentSubjectsComboBox.Location = new System.Drawing.Point(179, 161);
            this.studentSubjectsComboBox.Name = "studentSubjectsComboBox";
            this.studentSubjectsComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentSubjectsComboBox.TabIndex = 2;
            this.studentSubjectsComboBox.SelectedValueChanged += new System.EventHandler(this.studentSubjectsComboBox_SelectedValueChanged);
            // 
            // SelectSubjectLabel
            // 
            this.SelectSubjectLabel.AutoSize = true;
            this.SelectSubjectLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SelectSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectSubjectLabel.ForeColor = System.Drawing.Color.White;
            this.SelectSubjectLabel.Location = new System.Drawing.Point(176, 136);
            this.SelectSubjectLabel.Name = "SelectSubjectLabel";
            this.SelectSubjectLabel.Size = new System.Drawing.Size(88, 13);
            this.SelectSubjectLabel.TabIndex = 3;
            this.SelectSubjectLabel.Text = "Select subject";
            // 
            // selectedMarksListBox
            // 
            this.selectedMarksListBox.FormattingEnabled = true;
            this.selectedMarksListBox.HorizontalScrollbar = true;
            this.selectedMarksListBox.Items.AddRange(new object[] {
            "No marks"});
            this.selectedMarksListBox.Location = new System.Drawing.Point(179, 225);
            this.selectedMarksListBox.Name = "selectedMarksListBox";
            this.selectedMarksListBox.Size = new System.Drawing.Size(312, 108);
            this.selectedMarksListBox.TabIndex = 4;
            // 
            // AllMarksLabel
            // 
            this.AllMarksLabel.AutoSize = true;
            this.AllMarksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AllMarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMarksLabel.ForeColor = System.Drawing.Color.White;
            this.AllMarksLabel.Location = new System.Drawing.Point(178, 197);
            this.AllMarksLabel.Name = "AllMarksLabel";
            this.AllMarksLabel.Size = new System.Drawing.Size(58, 13);
            this.AllMarksLabel.TabIndex = 5;
            this.AllMarksLabel.Text = "All marks";
            // 
            // averageMark
            // 
            this.averageMark.AutoSize = true;
            this.averageMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.averageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageMark.ForeColor = System.Drawing.Color.White;
            this.averageMark.Location = new System.Drawing.Point(176, 347);
            this.averageMark.Name = "averageMark";
            this.averageMark.Size = new System.Drawing.Size(90, 15);
            this.averageMark.TabIndex = 6;
            this.averageMark.Text = "averageMark";
            this.averageMark.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // EventBar
            // 
            this.EventBar.BackColor = System.Drawing.Color.Bisque;
            this.EventBar.Controls.Add(this.closeEventBarBtn);
            this.EventBar.Controls.Add(this.EventDescriptionLabel);
            this.EventBar.Location = new System.Drawing.Point(138, 51);
            this.EventBar.Name = "EventBar";
            this.EventBar.Size = new System.Drawing.Size(812, 65);
            this.EventBar.TabIndex = 10;
            this.EventBar.Visible = false;
            this.EventBar.Paint += new System.Windows.Forms.PaintEventHandler(this.EventBarForParent_Paint);
            // 
            // EventDescriptionLabel
            // 
            this.EventDescriptionLabel.AutoSize = true;
            this.EventDescriptionLabel.BackColor = System.Drawing.Color.Bisque;
            this.EventDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.EventDescriptionLabel.Location = new System.Drawing.Point(22, 20);
            this.EventDescriptionLabel.Name = "EventDescriptionLabel";
            this.EventDescriptionLabel.Size = new System.Drawing.Size(126, 16);
            this.EventDescriptionLabel.TabIndex = 21;
            this.EventDescriptionLabel.Text = "EventDescription";
            // 
            // closeEventBarBtn
            // 
            this.closeEventBarBtn.BackColor = System.Drawing.Color.Bisque;
            this.closeEventBarBtn.FlatAppearance.BorderSize = 0;
            this.closeEventBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeEventBarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeEventBarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.closeEventBarBtn.Location = new System.Drawing.Point(787, 39);
            this.closeEventBarBtn.Name = "closeEventBarBtn";
            this.closeEventBarBtn.Size = new System.Drawing.Size(22, 23);
            this.closeEventBarBtn.TabIndex = 22;
            this.closeEventBarBtn.Text = "X";
            this.closeEventBarBtn.UseVisualStyleBackColor = false;
            this.closeEventBarBtn.Click += new System.EventHandler(this.closeEventBarBtn_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(950, 400);
            this.Controls.Add(this.EventBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.averageMark);
            this.Controls.Add(this.AllMarksLabel);
            this.Controls.Add(this.selectedMarksListBox);
            this.Controls.Add(this.SelectSubjectLabel);
            this.Controls.Add(this.studentSubjectsComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.EventBar.ResumeLayout(false);
            this.EventBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox studentSubjectsComboBox;
        private System.Windows.Forms.Label SelectSubjectLabel;
        private System.Windows.Forms.ListBox selectedMarksListBox;
        private System.Windows.Forms.Label AllMarksLabel;
        private System.Windows.Forms.Label averageMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label parentNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Panel EventBar;
        private System.Windows.Forms.Label EventDescriptionLabel;
        private System.Windows.Forms.Button closeEventBarBtn;
    }
}