namespace TravelBookingSystem
{
    public partial class MainMenu : Form
    {
        Register registerNewCustomer;
        CustomerLogin customerLogin;
        CustomerOverview customerOverview;
        DatabaseConnection databaseConnection;


        public MainMenu()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection("localhost", "travelbooking", "root", "Dalstorp23!");
            registerNewCustomer = new Register();
            registerNewCustomer.mainMenu = this;
            registerNewCustomer.databaseConnection = databaseConnection;

            customerLogin = new CustomerLogin(this);
            customerLogin.databaseConnection = databaseConnection;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Hide();
            registerNewCustomer.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Hide();

            customerLogin.Show();
        }


    }
}
