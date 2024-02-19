using TravelBookingSystem.Items;

namespace TravelBookingSystem
{
    public partial class CustomerOverview : Form
    {
        CustomerLogin customerLogin;
        public CustomerOverview customerOverview;
        MainMenu mainMenu;
        DatabaseConnection databaseConnection;
        public NewBooking newBooking;
        public bool validUser;
        public string loggedInUser;
        public List<BookingDetails> userBookings;

        public CustomerOverview(bool validUser, MainMenu mainMenu, CustomerLogin customerLogin, string loggedInUser)
        {
            InitializeComponent();
            this.validUser = validUser;
            this.mainMenu = mainMenu;
            this.customerLogin = customerLogin;
            this.loggedInUser = loggedInUser;
            List<BookingDetails> userBookings = new List<BookingDetails>();
            newBooking = new NewBooking(customerLogin, loggedInUser, customerOverview);
            newBooking.customerOverview = this;
            databaseConnection = new DatabaseConnection();

            FillListBox();

            welcomeLabel.Text = "Welcome to your profilepage!";
        }

        private void FillListBox()
        {
            List<BookingDetails> userBookings = databaseConnection.GetBookingToListbox(loggedInUser);

            myTripsListbox.Items.Clear();

            foreach (BookingDetails booking in userBookings)
            {
                myTripsListbox.Items.Add(booking.BookingName);
            }
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            customerLogin.validUser = false;
            Hide();
            mainMenu.Show();
        }

        private void myTripsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BookingDetails> userBookings = databaseConnection.GetBookingToListbox(loggedInUser);

            if (myTripsListbox.SelectedIndex != -1 && myTripsListbox.SelectedIndex < userBookings.Count)
            {
                BookingDetails selectedBooking = userBookings[myTripsListbox.SelectedIndex];
                destinationLabel.Text = "Destination: " + selectedBooking.DestinationName;
                countryLabel.Text = "Country: " + selectedBooking.Country;
                departureLabel.Text = "Departure from: " + selectedBooking.Departure;
                flightnameLabel.Text = "Flight name: " + selectedBooking.FlightName;
                dateLabel.Text = "Date: " + selectedBooking.FlightDate.ToString();
                hotelLabel.Text = "Hotel: " + selectedBooking.Hotel;
                activityLabel.Text = "Activity planned: " + selectedBooking.ActivityName;
                totalPriceLabel.Text = "Total price: " + selectedBooking.Price.ToString() + "kr";

                destinationLabel.Visible = true;
                countryLabel.Visible = true;
                departureLabel.Visible = true;
                flightnameLabel.Visible = true;
                dateLabel.Visible = true;
                hotelLabel.Visible = true;
                activityLabel.Visible = true;
                totalPriceLabel.Visible = true;
            }
        }

        public void UpdateUserBookings(List<BookingDetails> userBookings)
        {
            // Antag att du har en ListBox som heter bookingsListBox
            myTripsListbox.Items.Clear();

            foreach (var booking in userBookings)
            {
                // Formatera bokningen på önskat sätt (anpassa detta efter din ListBox-struktur)
                string formattedBooking = $"{booking.BookingName}";

                // Lägg till den formaterade bokningen i ListBox
                myTripsListbox.Items.Add(formattedBooking);
            }
        }

        private void updateTripnameButton_Click(object sender, EventArgs e)
        {
            List<BookingDetails> userBookings = databaseConnection.GetBookingToListbox(loggedInUser);

            int tripIndexToUpdate = myTripsListbox.SelectedIndex;
            if (tripIndexToUpdate == -1)
            {
                MessageBox.Show("Please select a trip to rename.");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(bookingnameTextbox.Text))
                {
                    MessageBox.Show("Please give your trip a new name");
                    return;

                }


                BookingDetails booking = userBookings[tripIndexToUpdate];
                myTripsListbox.SelectedIndex = -1;
                string newTripName = bookingnameTextbox.Text;
                bool succes = databaseConnection.UpdateBookingName(booking.Id, newTripName);

                if (succes)
                {
                    booking.BookingName = newTripName;
                    FillListBox();
                    bookingnameTextbox.Clear();
                }
            }

        }


        private void cancelTripButton_Click(object sender, EventArgs e)
        {
            List<BookingDetails> userBookings = databaseConnection.GetBookingToListbox(loggedInUser);

            int tripIndexToRemove = myTripsListbox.SelectedIndex;
            if (tripIndexToRemove != -1)
            {
                BookingDetails booking = userBookings[tripIndexToRemove];
                myTripsListbox.SelectedIndex = -1;
                bool succes = databaseConnection.RemoveTrip(booking.Id);

                if (succes)
                {
                    userBookings.RemoveAt(tripIndexToRemove);
                    FillListBox();
                    destinationLabel.Visible = false;
                    countryLabel.Visible = false;
                    departureLabel.Visible = false;
                    flightnameLabel.Visible = false;
                    dateLabel.Visible = false;
                    hotelLabel.Visible = false;
                    activityLabel.Visible = false;
                    totalPriceLabel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to remove.");
                return;
            }
        }

        private void newBookingButton_Click(object sender, EventArgs e)
        {
            Hide();
            newBooking.Show();
        }

        private void updateListbox_Click(object sender, EventArgs e)
        {
            FillListBox();
        }
    }
}
