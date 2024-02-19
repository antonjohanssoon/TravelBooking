using TravelBookingSystem.Items;

namespace TravelBookingSystem
{
    public partial class Register : Form
    {
        public MainMenu mainMenu;
        public DatabaseConnection databaseConnection;

        Dictionary<string, Person> customers = new Dictionary<string, Person>();

        public Register()
        {
            InitializeComponent();
        }

        private void mainmenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            mainMenu.Show();
        }

        public void registerButton_Click(object sender, EventArgs e)
        {
            string customerFirstName = firstnameTextbox.Text;
            string customerSurName = surnameTextbox.Text;
            int customerAge = (int)ageUpDown.Value;
            string customerEmail = emailTextbox.Text;
            string customerUsername = usernameTextbox.Text;
            string customerPassword = passwordTextbox.Text;

            if (string.IsNullOrWhiteSpace(firstnameTextbox.Text) || string.IsNullOrWhiteSpace(surnameTextbox.Text) ||
                string.IsNullOrWhiteSpace(emailTextbox.Text) || string.IsNullOrWhiteSpace(usernameTextbox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextbox.Text))
            {
                MessageBox.Show("Please fill in all information!");
                return;
            }
            else if (ageUpDown.Value < 18)
            {
                MessageBox.Show("Minimum age to register: 18");
                return;
            }

            Person newCustomer = databaseConnection.RegisterNewPerson(customerUsername, customerFirstName,
                customerSurName, customerAge, customerEmail, customerPassword);

            customers.Add(customerUsername, newCustomer);

            succesfulregisterLabel.Text = customerFirstName + " " + customerSurName + " succesfully registerd.";

            firstnameTextbox.Clear();
            surnameTextbox.Clear();
            ageUpDown.Value = 0;
            emailTextbox.Clear();
            usernameTextbox.Clear();
            passwordTextbox.Clear();
        }

    }
}
