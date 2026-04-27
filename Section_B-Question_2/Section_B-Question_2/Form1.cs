//Wian Sandenbergh
/*
HomeAffairsDigitalldentityProcessor, is designed to facilitate the creation and validation of digital citizen profiles.
The application enables users to input a person's details, validate their identification number, and generate a summary
profile in a GUI.

Graphical USer Inteface Components
- Labels: Used for guiding the user through the entry of name, ID number, citizenship selection, and for displaying results.
- TextBoxes: Two text boxes are provided; one for the user's name and one for the ID number.
- ComboBox: This control allows the user to select citizenship status from at least three options:
Citizen, Permanent Resident, and Visitor.
- Buttons: There are two buttons -Validate ID and Generate Profile- to perform the respective actions
- Results Display: The output summary is shown in a multi-line TextBox or Label, presenthing the processed information.
- CitizenProfile Class Design
- The CitizenProfile class holds critical information for each profile and encapsulates the logic required for validation and age calculation.

Properties:
- FullName
- IDNumber 
- Age
- CitizenshipStatus
Constructor: Accepts the name, ID number, and citizenship status, then calculates the age using a dedicated method.
- Age Calculation: The method extracts the birth date from the first six degits of the ID number (YYMMDD), 
determines the century (1900s or 2000s), and computes the current age accordingly.

ValidateID() Method:
- Ensures the ID number contains exactly 13 digits
- Verifies that the ID number is fully numeric
- Uses the calculated age as part of the validation criteria
- Returns a validiation message indicating the result of these checks.

Application Functionality
- When the Validate ID button is pressed, the application reads the user inputs, creates a CitizenProfile object, and 
dispalys the validation result in the results area. 
- Pressing the Generate Profile button produces a formatted profile summary containing the full name, ID number, calculated
age, citizenship status, validation result, and a processing timestamp message.

 */
namespace Section_B_Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting the value for labels
            lblTitel.Text = "Home Affairs Digital Identity Processor";
            lblName.Text = "Enter your Name:";
            lblID.Text = "Enter your ID:";
            lblCitizen.Text = "Choose your Citizen:";
            lblResults.Text = "";
            //Setting the value for the texboxes
            txtBoxName.PlaceholderText = "FullName";
            txtBoxIdNum.PlaceholderText = "1234567812345";
            //Setting the value for the buttons
            btnValidateId.Text = "Validate ID";
            btnGenPrf.Text = "Generate Profile";
            btnGenPrf.BackColor = System.Drawing.Color.Green;
            btnValidateId.BackColor = System.Drawing.Color.Green;
            //Setting the value for the list box
            lsBoxSummary.Items.Clear();
            //Setting the value for the combo box
            cmbBoxCitizen.Items.Clear();
            cmbBoxCitizen.Items.Add("Citizen");
            cmbBoxCitizen.Items.Add("Permanent Resident");
            cmbBoxCitizen.Items.Add("Visitor");
            //Setting the form back ground color
            this.BackColor = System.Drawing.Color.PeachPuff;
        }

        private void lblTital_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxIdNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCitizen_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxCitizen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValidateId_Click(object sender, EventArgs e)
        {
            string fullName = txtBoxName.Text;
            string idNumber = txtBoxIdNum.Text;
            string citizenship = cmbBoxCitizen.SelectedItem?.ToString() ?? "Unknown";

            DigitalCitizenProfile profile = new DigitalCitizenProfile(fullName, idNumber, citizenship);
            lblResults.Text = profile.ValidateID();
        }

        private void lsBoxSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenPrf_Click(object sender, EventArgs e)
        {
            //Saving the input as variables
            string fullName = txtBoxName.Text;
            string idNumber = txtBoxIdNum.Text;
            string citizenship = cmbBoxCitizen.SelectedItem?.ToString() ?? "Unknown";
            //Creating a Digital Citizen Profile to make it easier to call, generate and work with
            DigitalCitizenProfile profile = new DigitalCitizenProfile(fullName, idNumber, citizenship);
            //Creating teh Summary page and answers
            lsBoxSummary.Items.Clear();
            lsBoxSummary.Items.Add("==== DIGITAL CITIZEN SUMMARY ====");
            lsBoxSummary.Items.Add($"Name: {profile.FullName}");
            lsBoxSummary.Items.Add($"ID Number: {profile.IDNumber}");
            lsBoxSummary.Items.Add($"Age: {profile.Age}");
            lsBoxSummary.Items.Add($"Citizenship: {profile.CitizenshipStatus}");
            lsBoxSummary.Items.Add($"Validation: {profile.ValidateID()}");
            lsBoxSummary.Items.Add("Processed at: Home Affairs Digital Desk");
            lsBoxSummary.Items.Add($"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}");
        }
    }
    public class DigitalCitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }
        public DigitalCitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            //Converting the var
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(idNumber);
        }
        //Getting the user age from ID number
        private int CalculateAge(string idNumber)
        {
            //getting first 6 numbers
            string birthDateStr = idNumber.Substring(0, 6);
            //Breaking it down to year,month and day
            int year = int.Parse(birthDateStr.Substring(0, 2));
            int month = int.Parse(birthDateStr.Substring(2, 2));
            int day = int.Parse(birthDateStr.Substring(4, 2));
            year += (year <= DateTime.Now.Year % 100) ? 2000 : 1900;
            //Getting teh age
            try
            {
                DateTime birthDate = new DateTime(year, month, day);
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now < birthDate.AddYears(age)) age--;
                return age;
            }
            catch
            {
                return -1;
            }
        }
        public string ValidateID()
        {
            if (IDNumber.Length != 13 || !IDNumber.All(char.IsDigit))
                return "Invalid ID: must be 13 numeric digits.";
            int age = CalculateAge(IDNumber);
            if (age == -1)
                return "Invalid ID: Does not exist.";
            return $"Valid ID. Citizen is {age} years old.";
        }

    }
}
