using TravelBookingSystem.Items;

namespace TravelBookingSystem
{
    public partial class NewBooking : Form
    {
        CustomerLogin customerLogin;
        public string loggedInUser;
        DatabaseConnection databaseConnection;
        public string selectedDestination;
        public string selectedDeparture;
        public CustomerOverview customerOverview;

        public NewBooking(CustomerLogin customerLogin, string loggedInUser, CustomerOverview customerOverview)
        {
            InitializeComponent();
            this.customerLogin = customerLogin;
            this.loggedInUser = loggedInUser;
            this.customerOverview = customerOverview;
            databaseConnection = new DatabaseConnection();
            destinationCombobox.Text = "Destination";
            activityCombobox.Text = "Activity";
        }
        private void destinationCombobox_MouseClick(object sender, MouseEventArgs e)
        {
            FillDestinationCombobox();
        }


        public void FillDestinationCombobox()
        {
            destinationCombobox.Items.Clear();
            List<Flight> flights = databaseConnection.GetFlights();

            foreach (Flight flight in flights)
            {

                string displayText = $"{flight.Id} - {flight.Destination}";

                destinationCombobox.Items.Add(displayText);
            }

            destinationCombobox.SelectedIndexChanged += DestinationCombobox_SelectedIndexChanged;
        }

        private void DestinationCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFlightInfo = destinationCombobox.SelectedItem.ToString();

            int flightId = int.Parse(selectedFlightInfo.Split('-')[0].Trim());

            FillOtherInfo(flightId);
            departureLabel.Visible = true;
            dateLabel.Visible = true;
            hotelLabel.Visible = true;

            FillActivityCombobox(flightId);
        }

        private void FillActivityCombobox(int flightId)
        {
            activityCombobox.Items.Clear();

            List<Activity> activities = databaseConnection.GetActivitiesForFlight(flightId);

            foreach (Activity activity in activities)
            {
                string displayText = $"{activity.Id} - {activity.ActivityName}";

                activityCombobox.Items.Add(displayText);
            }
        }

        private void FillOtherInfo(int flightId)
        {
            List<string> departures = databaseConnection.GetDeparturesForFlight(flightId);
            departureLabel.Text = "Departures from: " + string.Join(", ", departures);


            List<DateTime> dates = databaseConnection.GetDatesForFlight(flightId);
            dateLabel.Text = "Date & time: " + string.Join(", ", dates);


            List<string> hotels = databaseConnection.GetHotelsForFlight(flightId);
            hotelLabel.Text = "Hotel: " + string.Join(", ", hotels);
        }


        public void confirmBookingButton_Click(object sender, EventArgs e)
        {
            string bookingName = bookingNameTextbox.Text;
            string username = loggedInUser;
            string selectedflight = destinationCombobox.SelectedItem.ToString();
            int flightId = int.Parse(selectedflight.Split('-')[0].Trim());
            string selectedactivity = activityCombobox.SelectedItem.ToString();
            int activityId = int.Parse(selectedactivity.Split('-')[0].Trim());


            if (string.IsNullOrWhiteSpace(bookingNameTextbox.Text) || (destinationCombobox.Items == null) ||
                (activityCombobox.Items == null))
            {
                MessageBox.Show("Please enter a name for your trip, then choose destination and activity");
                return;
            }

            Booking newBooking = databaseConnection.AddNewBooking(bookingName, username, flightId, activityId);
            succesfulBookingLabel.Visible = true;
            succesfulBookingLabel.Text = "Your booking named: " + bookingName + " succesfully made!";
        }



        private void overviewButton_Click(object sender, EventArgs e)
        {
            Hide();
            customerOverview.Show();
        }
    }
}
