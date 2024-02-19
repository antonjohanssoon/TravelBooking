namespace TravelBookingSystem.Items
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightName { get; set; }
        public DateTime FlightDate { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int Price { get; set; }

        public Flight(int id, string flightName, DateTime flightDate, string destination, string departure, int price)
        {
            Id = id;
            FlightName = flightName;
            FlightDate = flightDate;
            Destination = destination;
            Departure = departure;
            Price = price;
        }
    }
}
