using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkProsvirov
{
    public enum Roles
    {
        Customer,
        Barber,
        Administrator,
        None
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Зауважте: у реальному коді паролі мають бути захешованими!

        public Customer(int customerID, string firstName, string lastName, string phone, string email, string password)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

        // Додайте методи для взаємодії з базою даних тут...
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
                            reader.GetString(reader.GetOrdinal("Password")) // Зверніть увагу: небезпечно зчитувати паролі!
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
                    cmd.Parameters.AddWithValue("@Password", customer.Password); // Пароль має бути хешований перед передачею

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

    public class Barber
    {
        public int BarberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Зауважте: у реальному коді паролі мають бути захешованими!

        public Barber(int barberID, string firstName, string lastName, string phone, string email, string password)
        {
            BarberID = barberID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

        // Додайте методи для взаємодії з базою даних тут...
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
                    cmd.Parameters.AddWithValue("@Password", barber.Password); // Пароль має бути захешований перед передачею

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

    public class Administrator
    {
        public int AdministratorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Зауважте: у реальному коді паролі мають бути захешованими!

        public Administrator(int administratorID, string firstName, string lastName, string phone, string email, string password)
        {
            AdministratorID = administratorID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

        // Додайте методи для взаємодії з базою даних тут...
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
                string sql = "INSERT INTO Administrators (FirstName, LastName, Phone, Email, Password) VALUES (@FirstName, @LastName, @Phone, @Email, @Password)";

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

    }

    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int BarberID { get; set; }
        public int ServiceID { get; set; }
        public DateTime DateTime { get; set; }

        public Order(int orderID, int customerID, int barberID, int serviceID, DateTime datetime)
        {
            OrderID = orderID;
            CustomerID = customerID;
            BarberID = barberID;
            ServiceID = serviceID;
            DateTime = datetime;
        }

        public Order()
        {
            throw new NotImplementedException();
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
                    cmd.Parameters.AddWithValue("@DateTime", order.DateTime);

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
                var sql = "SELECT OrderID, CustomerID, BarberID, ServiceID, DateTime FROM Orders";
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

    }

    public class Review
    {
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int OrderID { get; set; }

        public Review(int reviewID, int rating, string comment, int orderID)
        {
            ReviewID = reviewID;
            Rating = rating;
            Comment = comment;
            OrderID = orderID;
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
    }

}
