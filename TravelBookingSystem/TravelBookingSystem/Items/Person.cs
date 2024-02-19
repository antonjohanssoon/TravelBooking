namespace TravelBookingSystem.Items
{
    public class Person
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public Person(string username, string firstName, string surName, int age, string email, string password)
        {
            Username = username;
            FirstName = firstName;
            SurName = surName;
            Age = age;
            Email = email;
            Password = password;
        }
    }

}
