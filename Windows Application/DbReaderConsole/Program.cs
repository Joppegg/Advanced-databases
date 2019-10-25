using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReaderConsole
{
    public class Customer
    {
        public string idNbr;
        public string name;
        public string address;
        public string ssn;

    }


    class Program
    {
        static void Main(string[] args)
        {

            localhost.WebServiceDBReader dbReader = new localhost.WebServiceDBReader();
            localhost.Customer[] customerList = dbReader.GetCustomers();
            localhost.Destination[] destinationList = dbReader.GetDestinations();
            localhost.Booking[] bookingList = dbReader.GetBookings();

            Console.WriteLine("Customers: ");
            Console.WriteLine(customerList.Length);
            foreach (DbReaderConsole.localhost.Customer c in dbReader.GetCustomers())
            {
                Console.WriteLine(c.idNbr + " " + c.ssn + " " + c.name + " " + c.address);

            }
            Console.WriteLine("Destinations:");
            foreach (DbReaderConsole.localhost.Destination d in dbReader.GetDestinations())
            {
                Console.WriteLine(d.destinationNbr + " " + d.country + " " + d.city + " " + d.hotel);

            }
            Console.WriteLine("Bookings:");
            foreach (DbReaderConsole.localhost.Booking b in dbReader.GetBookings())
            {
                Console.WriteLine(b.customerNbr + " " + b.destinationNbr + " " + b.dateOut + " " + b.dateHome + " " + b.bookingNbr);

            }

            Console.ReadLine();

        }


    }
}
