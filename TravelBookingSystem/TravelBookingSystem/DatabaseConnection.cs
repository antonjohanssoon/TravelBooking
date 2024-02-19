using MySql.Data.MySqlClient;
using TravelBookingSystem.Items;

namespace TravelBookingSystem
{
    public class DatabaseConnection
    {

        string server = "localhost";
        string database = "travelbooking";
        string username = "booking_customer";
        string password = "travelingcustomer";

        string connectionString = "";

        public DatabaseConnection(string server, string database, string username, string password)
        {

            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
            Console.WriteLine("ConnectionString: " + connectionString);
        }

        public DatabaseConnection()
        {

            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
            Console.WriteLine("ConnectionString: " + connectionString);
        }


        public Person RegisterNewPerson(string username, string firstname, string surname, int age, string email, string password)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "CALL new_person(\"" + username + "\", \"" + firstname + "\", \"" + surname + "\", \""
                + age + "\", \"" + email + "\", \"" + password + "\")";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            reader.Read();

            Person customer = new Person(username, firstname, surname, age, email, password);

            mySqlConnection.Close();

            return customer;
        }

        public bool SignInCustomer(string username, string password)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT * FROM person WHERE username = @username AND user_password = @password";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@username", username);
                mySqlCommand.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<BookingDetails> GetBookingToListbox(string username)
        {
            List<BookingDetails> userBookings = new List<BookingDetails>();

            string query = "SELECT * FROM users_bookingdetails WHERE username = @username";


            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookingDetails booking = new BookingDetails(
                                reader.GetString("username"),
                                reader.GetInt32("booking_id"),
                                reader.GetString("booking_name"),
                                reader.GetString("destination_name"),
                                reader.GetString("country"),
                                reader.GetString("departure"),
                                reader.GetString("flight_name"),
                                reader.GetDateTime("flight_date"),
                                reader.GetString("hotel"),
                                reader.GetString("activity_name"),
                                reader.GetInt32("total_price")
                            );
                            userBookings.Add(booking);
                        }
                    }
                }

            }

            return userBookings;
        }

        public bool UpdateBookingName(int bookingIdToUpdate, string newBookingName)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "UPDATE booking " +
                               "SET booking_name = '" + newBookingName + "' " +
                               "WHERE booking_id = " + bookingIdToUpdate;

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("@newBookingName", newBookingName);
                    mySqlCommand.Parameters.AddWithValue("@bookingIdToUpdate", bookingIdToUpdate);

                    int rowsAffected = mySqlCommand.ExecuteNonQuery();

                    mySqlConnection.Close();

                    return rowsAffected > 0;
                }
            }
        }

        public bool RemoveTrip(int bookingId)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "DELETE FROM booking " +
                               "WHERE booking_id = " + bookingId + ";";

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("@bookingId", bookingId);

                    int rowsAffected = mySqlCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public Booking AddNewBooking(string bookingName, string username, int flightId, int activityId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "CALL new_booking(@booking_name, @username, @flight_id, @activity_id)";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@booking_name", bookingName);
            mySqlCommand.Parameters.AddWithValue("@username", username);
            mySqlCommand.Parameters.AddWithValue("@flight_id", flightId);
            mySqlCommand.Parameters.AddWithValue("@activity_id", activityId);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            reader.Read();

            Booking newBooking = new Booking(0, bookingName, username, flightId, activityId);

            mySqlConnection.Close();

            return newBooking;
        }

        public List<Flight> GetFlights()
        {
            List<Flight> flights = new List<Flight>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT * FROM flight;";

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight(
                                reader.GetInt32("flight_id"),
                                reader.GetString("flight_name"),
                                reader.GetDateTime("flight_date"),
                                reader.GetString("destination"),
                                reader.GetString("departure"),
                                reader.GetInt32("price")
                            );

                            flights.Add(flight);
                        }
                    }
                }
            }

            return flights;
        }

        public List<string> GetDeparturesForFlight(int flightId)
        {
            List<string> departures = new List<string>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT DISTINCT departure FROM flight WHERE flight_id = @flightId;";

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("@flightId", flightId);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            departures.Add(reader.GetString("departure"));
                        }
                    }
                }
            }

            return departures;
        }

        public List<DateTime> GetDatesForFlight(int flightId)
        {
            List<DateTime> dates = new List<DateTime>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT DISTINCT flight_date FROM flight WHERE flight_id = @flightId;";

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("@flightId", flightId);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dates.Add(reader.GetDateTime("flight_date"));
                        }
                    }
                }
            }

            return dates;
        }

        public List<string> GetHotelsForFlight(int flightId)
        {
            List<string> hotels = new List<string>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT DISTINCT hotel FROM destination WHERE destination_id IN " +
                               "(SELECT destination_id FROM flight WHERE flight_id = @flightId);";

                using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("@flightId", flightId);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hotels.Add(reader.GetString("hotel"));
                        }
                    }
                }
            }

            return hotels;
        }
        public List<Activity> GetActivitiesForFlight(int flightId)
        {
            List<Activity> activities = new List<Activity>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT a.activity_id, a.activity_name, a.time_hours, a.time_minutes, a.price " +
                               "FROM activity a " +
                               "JOIN activity_at_destination ad ON a.activity_id = ad.activity_id " +
                               "JOIN flight f ON ad.destination_id = f.destination_id " +
                               "WHERE f.flight_id = @flightId;";

                using MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                {
                    mySqlCommand.Parameters.AddWithValue("@flightId", flightId);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Activity activity = new Activity(
                                reader.GetInt32("activity_id"),
                                reader.GetString("activity_name"),
                                reader.GetInt32("time_hours"),
                                reader.GetInt32("time_minutes"),
                                reader.GetInt32("price")
                            );

                            activities.Add(activity);
                        }
                    }
                }
            }

            return activities;
        }

    }


}
