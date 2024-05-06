using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkProsvirov
{
    public class DataService
    {
        private UserAuthorization userAuthorization;

        public DataService(string connectionString)
        {
            userAuthorization = new UserAuthorization(connectionString);
        }

        public static List<Customer> LoadCustomers(string connectionString)
        {
            var customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Відкриття з'єднання
                connection.Open();

                // SQL запит
                var sql = "SELECT CustomerID, FirstName, LastName, Phone, Email, Password FROM Customers";
                SqlCommand command = new SqlCommand(sql, connection);

                // Виконання запиту та обробка результатів
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new Customer(
                            reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            reader.GetString(reader.GetOrdinal("FirstName")),
                            reader.GetString(reader.GetOrdinal("LastName")),
                            reader.GetString(reader.GetOrdinal("Phone")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetString(
                                reader.GetOrdinal("Password")) // Зверніть увагу: небезпечно зчитувати паролі!
                        );
                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }

        public static void AddCustomer(string connectionString, Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "AddNewCustomer"; // Назва збереженої процедури

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@Password",
                        customer.Password); // Пароль має бути хешований перед передачею

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Barber> LoadBarbers(string connectionString)
        {
            var barbers = new List<Barber>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = "SELECT BarberID, FirstName, LastName, Phone, Email, Password FROM Barbers";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var barber = new Barber(
                            reader.GetInt32(reader.GetOrdinal("BarberID")),
                            reader.GetString(reader.GetOrdinal("FirstName")),
                            reader.GetString(reader.GetOrdinal("LastName")),
                            reader.GetString(reader.GetOrdinal("Phone")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetString(reader.GetOrdinal("Password")) // Паролі мають бути захешовані
                        );
                        barbers.Add(barber);
                    }
                }
            }

            return barbers;
        }

        public static void AddBarber(string connectionString, Barber barber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "AddNewBarber"; // Назва збереженої процедури

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", barber.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", barber.LastName);
                    cmd.Parameters.AddWithValue("@Phone", barber.Phone);
                    cmd.Parameters.AddWithValue("@Email", barber.Email);
                    cmd.Parameters.AddWithValue("@Password",
                        barber.Password); // Пароль має бути захешований перед передачею

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Administrator> LoadAdministrators(string connectionString)
        {
            var administrators = new List<Administrator>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = "SELECT AdministratorID, FirstName, LastName, Phone, Email, Password FROM Administrators";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admin = new Administrator(
                            reader.GetInt32(reader.GetOrdinal("AdministratorID")),
                            reader.GetString(reader.GetOrdinal("FirstName")),
                            reader.GetString(reader.GetOrdinal("LastName")),
                            reader.GetString(reader.GetOrdinal("Phone")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetString(reader.GetOrdinal("Password")) // Паролі мають бути захешовані
                        );
                        administrators.Add(admin);
                    }
                }
            }

            return administrators;
        }

        public static void AddAdministrator(string connectionString, Administrator admin)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql =
                    "INSERT INTO Administrators (FirstName, LastName, Phone, Email, Password) VALUES (@FirstName, @LastName, @Phone, @Email, @Password)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", admin.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", admin.LastName);
                    cmd.Parameters.AddWithValue("@Phone", admin.Phone);
                    cmd.Parameters.AddWithValue("@Email", admin.Email);
                    cmd.Parameters.AddWithValue("@Password", admin.Password); // Пароль має бути хешований

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddOrder(string connectionString, Order order)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "AddOrder"; // Назва збереженої процедури

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    cmd.Parameters.AddWithValue("@BarberID", order.BarberID);
                    cmd.Parameters.AddWithValue("@ServiceID", order.ServiceID);
                    cmd.Parameters.AddWithValue("@Date", order.DateTime);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Order> LoadOrders(string connectionString)
        {
            var orders = new List<Order>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = "SELECT OrderID, CustomerID, BarberID, ServiceID, Date, Time FROM Orders";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new Order(
                            reader.GetInt32(reader.GetOrdinal("OrderID")),
                            reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            reader.GetInt32(reader.GetOrdinal("BarberID")),
                            reader.GetInt32(reader.GetOrdinal("ServiceID")),
                            reader.GetDateTime(reader.GetOrdinal("DateTime"))
                        );
                        orders.Add(order);
                    }
                }
            }

            return orders;
        }

        public static void AddReview(string connectionString, Review review)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "AddNewReview"; // Назва збереженої процедури

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rating", review.Rating);
                    cmd.Parameters.AddWithValue("@Comment", review.Comment);
                    cmd.Parameters.AddWithValue("@OrderID", review.OrderID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Review> LoadReviews(string connectionString)
        {
            var reviews = new List<Review>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = "SELECT ReviewID, Rating, Comment, OrderID FROM Reviews";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var review = new Review(
                            reader.GetInt32(reader.GetOrdinal("ReviewID")),
                            reader.GetInt32(reader.GetOrdinal("Rating")),
                            reader.IsDBNull(reader.GetOrdinal("Comment"))
                                ? null
                                : reader.GetString(reader.GetOrdinal("Comment")),
                            reader.GetInt32(reader.GetOrdinal("OrderID"))
                        );
                        reviews.Add(review);
                    }
                }
            }

            return reviews;
        }
    }
}