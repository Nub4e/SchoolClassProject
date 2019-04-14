namespace ClassbookProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoginEgnLabel = new System.Windows.Forms.Label();
            this.LoginNameLabel = new System.Windows.Forms.Label();
            this.insertNameTxtBox = new System.Windows.Forms.TextBox();
            this.insertEGNTxtBox = new System.Windows.Forms.TextBox();
            this.loginSelectComboBox = new System.Windows.Forms.ComboBox();
            this.loginAsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dragControl1 = new ClassbookProject.DragControl();
            this.dragControl2 = new ClassbookProject.DragControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(321, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginEgnLabel
            // 
            this.LoginEgnLabel.AutoSize = true;
            this.LoginEgnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginEgnLabel.ForeColor = System.Drawing.Color.White;
            this.LoginEgnLabel.Location = new System.Drawing.Point(140, 69);
            this.LoginEgnLabel.Name = "LoginEgnLabel";
            this.LoginEgnLabel.Size = new System.Drawing.Size(37, 13);
            this.LoginEgnLabel.TabIndex = 3;
            this.LoginEgnLabel.Text = "EGN:";
            // 
            // LoginNameLabel
            // 
            this.LoginNameLabel.AutoSize = true;
            this.LoginNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginNameLabel.ForeColor = System.Drawing.Color.White;
            this.LoginNameLabel.Location = new System.Drawing.Point(134, 107);
            this.LoginNameLabel.Name = "LoginNameLabel";
            this.LoginNameLabel.Size = new System.Drawing.Size(43, 13);
            this.LoginNameLabel.TabIndex = 4;
            this.LoginNameLabel.Text = "Name:";
            // 
            // insertNameTxtBox
            // 
            this.insertNameTxtBox.Location = new System.Drawing.Point(188, 107);
            this.insertNameTxtBox.Name = "insertNameTxtBox";
            this.insertNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.insertNameTxtBox.TabIndex = 5;
            // 
            // insertEGNTxtBox
            // 
            this.insertEGNTxtBox.Location = new System.Drawing.Point(188, 62);
            this.insertEGNTxtBox.Name = "insertEGNTxtBox";
            this.insertEGNTxtBox.Size = new System.Drawing.Size(100, 20);
            this.insertEGNTxtBox.TabIndex = 6;
            // 
            // loginSelectComboBox
            // 
            this.loginSelectComboBox.FormattingEnabled = true;
            this.loginSelectComboBox.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.loginSelectComboBox.Location = new System.Drawing.Point(188, 167);
            this.loginSelectComboBox.Name = "loginSelectComboBox";
            this.loginSelectComboBox.Size = new System.Drawing.Size(100, 21);
            this.loginSelectComboBox.TabIndex = 7;
            // 
            // loginAsLabel
            // 
            this.loginAsLabel.AutoSize = true;
            this.loginAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginAsLabel.ForeColor = System.Drawing.Color.White;
            this.loginAsLabel.Location = new System.Drawing.Point(185, 151);
            this.loginAsLabel.Name = "loginAsLabel";
            this.loginAsLabel.Size = new System.Drawing.Size(63, 13);
            this.loginAsLabel.TabIndex = 8;
            this.loginAsLabel.Text = "Log in as:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 274);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 32);
            this.panel1.TabIndex = 3;
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
            this.ReturnButton.Size = new System.Drawing.Size(88, 32);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(88, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 32);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 32);
            this.panel4.TabIndex = 11;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel2;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panel4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(408, 274);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginAsLabel);
            this.Controls.Add(this.loginSelectComboBox);
            this.Controls.Add(this.insertEGNTxtBox);
            this.Controls.Add(this.insertNameTxtBox);
            this.Controls.Add(this.LoginNameLabel);
            this.Controls.Add(this.LoginEgnLabel);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LoginEgnLabel;
        private System.Windows.Forms.Label LoginNameLabel;
        private System.Windows.Forms.TextBox insertNameTxtBox;
        private System.Windows.Forms.ComboBox loginSelectComboBox;
        private System.Windows.Forms.Label loginAsLabel;
        public System.Windows.Forms.TextBox insertEGNTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}