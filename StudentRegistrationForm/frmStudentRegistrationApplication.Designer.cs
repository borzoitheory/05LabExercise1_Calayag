namespace StudentRegistrationForm
{
    partial class frmStudentRegistrationApplication
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            cbxDay = new ComboBox();
            cbxMonth = new ComboBox();
            cbxYear = new ComboBox();
            registerStudent = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFile = new Button();
            label7 = new Label();
            cbxProgram = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 57);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 2;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 3;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 177);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 4;
            label4.Text = "Middle Name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 240);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 5;
            label5.Text = "Gender *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 268);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 6;
            label6.Text = "Date of Birth *";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(22, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 29);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(22, 138);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 29);
            txtFirstName.TabIndex = 8;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(22, 198);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(300, 29);
            txtMiddleName.TabIndex = 9;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoFemale.Location = new Point(168, 240);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(70, 23);
            rdoFemale.TabIndex = 10;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMale.Location = new Point(107, 240);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(57, 23);
            rdoMale.TabIndex = 11;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // cbxDay
            // 
            cbxDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxDay.ForeColor = Color.DimGray;
            cbxDay.FormattingEnabled = true;
            cbxDay.Location = new Point(23, 289);
            cbxDay.Name = "cbxDay";
            cbxDay.Size = new Size(75, 29);
            cbxDay.TabIndex = 12;
            cbxDay.Text = "-Date-";
            // 
            // cbxMonth
            // 
            cbxMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMonth.ForeColor = Color.DimGray;
            cbxMonth.FormattingEnabled = true;
            cbxMonth.Location = new Point(104, 289);
            cbxMonth.Name = "cbxMonth";
            cbxMonth.Size = new Size(75, 29);
            cbxMonth.TabIndex = 13;
            cbxMonth.Text = "-Month-";
            // 
            // cbxYear
            // 
            cbxYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxYear.ForeColor = Color.DimGray;
            cbxYear.FormattingEnabled = true;
            cbxYear.Location = new Point(185, 289);
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(93, 29);
            cbxYear.TabIndex = 14;
            cbxYear.Text = "-Year-";
            // 
            // registerStudent
            // 
            registerStudent.BackColor = Color.Crimson;
            registerStudent.FlatStyle = FlatStyle.Flat;
            registerStudent.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerStudent.ForeColor = Color.White;
            registerStudent.Location = new Point(22, 383);
            registerStudent.Name = "registerStudent";
            registerStudent.Size = new Size(180, 45);
            registerStudent.TabIndex = 15;
            registerStudent.Text = "Register Student";
            registerStudent.UseVisualStyleBackColor = false;
            registerStudent.Click += registerStudent_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(346, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 218);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = SystemColors.ActiveBorder;
            btnOpenFile.FlatStyle = FlatStyle.Flat;
            btnOpenFile.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenFile.ForeColor = Color.DimGray;
            btnOpenFile.Location = new Point(395, 281);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(126, 27);
            btnOpenFile.TabIndex = 17;
            btnOpenFile.Text = "Browse";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 326);
            label7.Name = "label7";
            label7.Size = new Size(155, 19);
            label7.TabIndex = 18;
            label7.Text = "Program to apply *";
            // 
            // cbxProgram
            // 
            cbxProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxProgram.ForeColor = Color.DimGray;
            cbxProgram.FormattingEnabled = true;
            cbxProgram.Items.AddRange(new object[] { "Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Science in Business Administration (BSBA)", "Bachelor of Science in Accounting Information System (BSAIS)", "Bachelor of Science in Accountancy (BSA)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Multimedia Arts (BMMA)", "Bachelor of Science in Psychology", "Bachelor of Secondary Education Major in English", "Bachelor of Elementary Education", "Bachelor of Secondary Education Major in Mathematics (BSED)", "Bachelor of Science in Tourism Management (BSTM)", "Bachelor of Science in Criminology" });
            cbxProgram.Location = new Point(23, 348);
            cbxProgram.Name = "cbxProgram";
            cbxProgram.Size = new Size(395, 29);
            cbxProgram.TabIndex = 19;
            cbxProgram.Text = "-Select program-";
            // 
            // frmStudentRegistrationApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 439);
            Controls.Add(cbxProgram);
            Controls.Add(label7);
            Controls.Add(btnOpenFile);
            Controls.Add(pictureBox1);
            Controls.Add(registerStudent);
            Controls.Add(cbxYear);
            Controls.Add(cbxMonth);
            Controls.Add(cbxDay);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmStudentRegistrationApplication";
            Text = "Form1";
            Load += frmStudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private ComboBox cbxDay;
        private ComboBox cbxMonth;
        private ComboBox cbxYear;
        private Button registerStudent;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFile;
        private Label label7;
        private ComboBox cbxProgram;
    }
}
