namespace TravelBookingSystem.Items
{
    public class Booking
    {
        public int Id { get; set; }
        public string BookingName { get; set; }
        public string Username { get; set; }
        public int FlightId { get; set; }
        public int ActivityId { get; set; }

        public Booking(int id, string bookingName, string username, int flightId, int activityId)
        {
            Id = id;
            BookingName = bookingName;
            Username = username;
            FlightId = flightId;
            ActivityId = activityId;
        }
    }
}
