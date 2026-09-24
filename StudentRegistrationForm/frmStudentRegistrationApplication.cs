namespace StudentRegistrationForm
{
    public partial class frmStudentRegistrationApplication : Form
    {
        public string lastName;
        public string firstName;
        public string middleName;
        public string gender;
        public string birthDay;
        public string birthMonth;
        public string birthYear;
        public string program;

        public frmStudentRegistrationApplication()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            int day;
            for (day = 1; day <= 31; day++)
            {
                cbxDay.Items.Add(day);
            }

            int month;
            for (month = 1; month <= 12; month++)
            {
                cbxMonth.Items.Add(month);
            }

            int year;
            int currentYear;
            currentYear = 2026;
            for (year = 1900; year <= currentYear; year++)
            {
                cbxYear.Items.Add(year);
            }

        }
        
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select Photo";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void DisplayStudentInfo(string fName, string mName, string lName, string gen, string bDay, string bMonth, string bYear, string prog)
        {
            string message = "Student name: " + fName + " " + mName + " " + lName +
                             "\nGender: " + gen +
                             "\nDate of birth: " + bDay + "/" + bMonth + "/" + bYear +
                             "\nProgram: " + prog;
            MessageBox.Show(message, "Student Registration");
        }
        public void DisplayStudentInfo(string fName, string mName, string lName, string prog)
        {
            string message = "Student name: " + fName + " " + mName + " " + lName +
                             "\nProgram: " + prog;
            MessageBox.Show(message, "Student Registration");
        }
        public void DisplayStudentInfo(string fName, string lName, string prog)
        {
            string message = "Student name: " + fName + " " + lName +
                             "\nProgram: " + prog;
            MessageBox.Show(message, "Student Registration");
        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;
            middleName = txtMiddleName.Text;
            birthDay = cbxDay.Text;
            birthMonth = cbxMonth.Text;
            birthYear = cbxYear.Text;
            program = cbxProgram.Text;

            gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            DisplayStudentInfo(firstName, middleName, lastName, gender, birthDay, birthMonth, birthYear, program);
            DisplayStudentInfo(firstName, middleName, lastName, program);
            DisplayStudentInfo(firstName, lastName, program);
        }
    }
}
