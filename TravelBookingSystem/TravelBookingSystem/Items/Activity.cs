namespace TravelBookingSystem.Items
{
    public class Activity
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public int TimeHours { get; set; }
        public int TimeMinutes { get; set; }
        public int Price { get; set; }

        public Activity(int id, string activityName, int timeHours, int timeMinutes, int price)
        {
            Id = id;
            ActivityName = activityName;
            TimeHours = timeHours;
            TimeMinutes = timeMinutes;
            Price = price;
        }
    }
}
