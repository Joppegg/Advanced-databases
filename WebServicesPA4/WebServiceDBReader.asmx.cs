using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesPA4
{
    /// <summary>
    /// Summary description for WebServiceDBReader
    /// </summary>
    [WebService(Namespace = "http://SeskarptDatabas.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDBReader : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public DataTable GetCollection(string query)
        {

            using (SqlConnection sqlCon = new SqlConnection(WebServiceDBReader.GetConnectionString()))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;
            }
        }

        public class Customer
        {
            public string idNbr;
            public string name;
            public string address;
            public string ssn;
            public Customer() { }
        }

        public class Destination
       {
    
          public string destinationNbr;
          public string city;
          public string country;
          public string hotel;
 
       }
        public class Booking
        {
        public string customerNbr;
        public string destinationNbr;
        public string dateOut;
        public string dateHome;
        public string bookingNbr;

        }

        [WebMethod]
        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(WebServiceDBReader.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT customerNbr AS [Cust. No] , name AS Name, address AS Address, ssn AS SSN FROM Customer", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer newCustomer = new Customer();
                            newCustomer.idNbr = reader.GetValue(0).ToString();
                            newCustomer.name = reader.GetValue(1).ToString();
                            newCustomer.address = reader.GetValue(2).ToString();
                            newCustomer.ssn = reader.GetValue(3).ToString();
                            customerList.Add(newCustomer);
                        }
                    }
                }

               
            }
            return customerList;
        }

      
        [WebMethod]
        public List<Destination> GetDestinations()
        {
            List<Destination> destinationList = new List<Destination>();
       

            using (SqlConnection connection = new SqlConnection(WebServiceDBReader.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Destination", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                 
                        while (reader.Read())
                        {

                            Destination newDestination = new Destination();
                            newDestination.destinationNbr = reader.GetValue(0).ToString();
                            newDestination.city = reader.GetValue(1).ToString();
                            newDestination.country = reader.GetValue(2).ToString();
                            newDestination.hotel = reader.GetValue(3).ToString();
                            destinationList.Add(newDestination);
                        }
                    }
                }
            }
            return destinationList;
        }

        //Metod för att hämta bokningar
        [WebMethod]
        public List<Booking> GetBookings()
        {
            List<Booking> bookingList = new List<Booking>();
            using (SqlConnection connection = new SqlConnection(WebServiceDBReader.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Booking", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                  
                        while (reader.Read())
                        {
                            Booking newBooking = new Booking();
                            newBooking.customerNbr = reader.GetValue(0).ToString();
                            newBooking.destinationNbr = reader.GetValue(1).ToString();
                            newBooking.dateOut = reader.GetValue(2).ToString();
                            newBooking.dateHome = reader.GetValue(3).ToString();
                            newBooking.bookingNbr = reader.GetValue(4).ToString();
                            bookingList.Add(newBooking);
                        }
                    }
                }
            }
            return bookingList;
        }


        public class CustomerList : List<Customer>
        {

        }

        public static string GetConnectionString()
        {
            string connectionString = "Data Source=SYST4DEV01;Initial Catalog = Seskarpt; Integrated Security = True";
            return connectionString;

        }



    }
}
