namespace TravelBookingSystem.Items
{
    public class Destinaiton
    {
        public int Id { get; set; }
        public string DestinationName { get; set; }
        public string Country { get; set; }
        public string Hotel { get; set; }

        public Destinaiton(int id, string destinationName, string country, string hotel)
        {
            Id = id;
            DestinationName = destinationName;
            Country = country;
            Hotel = hotel;
        }
    }
}
