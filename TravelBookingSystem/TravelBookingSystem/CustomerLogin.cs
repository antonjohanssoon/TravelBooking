namespace TravelBookingSystem
{
    public partial class CustomerLogin : Form
    {
        public MainMenu mainMenu;
        public DatabaseConnection databaseConnection;
        public CustomerOverview customerOverview;
        public CustomerLogin customerLogin;
        private string loggedInUser;

        public CustomerLogin(MainMenu mainMenu)
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
            customerLogin = this;
            this.mainMenu = mainMenu;

        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            mainMenu.Show();
        }

        public bool validUser;

        private void signinButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            validUser = databaseConnection.SignInCustomer(username, password);

            if (validUser)
            {
                Hide();
                validUser = true;
                loggedInUser = username;
                customerOverview = new CustomerOverview(validUser, mainMenu, customerLogin, loggedInUser);
                customerOverview.validUser = validUser;
                customerOverview.Show();
                usernameTextbox.Clear();
                passwordTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                passwordTextbox.Clear();
            }
        }
    }
}
