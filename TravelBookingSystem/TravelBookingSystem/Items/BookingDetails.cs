namespace TravelBookingSystem.Items
{
    public class BookingDetails
    {
        public string Username { get; set; }
        public int Id { get; set; }
        public string BookingName { get; set; }
        public string DestinationName { get; set; }
        public string Country { get; set; }
        public string Departure { get; set; }
        public string FlightName { get; set; }
        public DateTime FlightDate { get; set; }
        public string Hotel { get; set; }
        public string ActivityName { get; set; }
        public int Price { get; set; }

        public BookingDetails()
        {
        }

        public BookingDetails(string username, int id, string bookingName, string destinationName, string country, string departure, string flightName, DateTime flightDate, string hotel, string activityName, int price)
        {
            Username = username;
            Id = id;
            BookingName = bookingName;
            DestinationName = destinationName;
            Country = country;
            Departure = departure;
            FlightName = flightName;
            FlightDate = flightDate;
            Hotel = hotel;
            ActivityName = activityName;
            Price = price;
        }
    }
}
