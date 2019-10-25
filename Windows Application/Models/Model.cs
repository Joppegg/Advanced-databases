
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Application.Models
{
    public class Model
    {
        public void AddCustomer(string name, string ssn, string address)
        {
            DatabaseConnection.Query("INSERT INTO Customer(ssn, name, address) VALUES ('" + ssn + "','" + name + "','" + address + "');");
        }
        public void DeleteCustomer(string customerNbr)
        {
            DatabaseConnection.Query("DELETE FROM Customer WHERE custId = '" + customerNbr + "'");
        }
        public void UpdateCustomer(string ssn, string name, string address, string customerNbr)
        {
            DatabaseConnection.Query("UPDATE Customer SET name = '" + name + "', address = '" + address + "' , ssn = '" + ssn + "' WHERE custId = '" + customerNbr + "'");
        }
        public void AddDestination(string city, string country, string hotel)
        {
            DatabaseConnection.Query("INSERT INTO Destination(city, country, hotel) VALUES('" + city + "', '" + country + "', '" + hotel + "');");
        }
        public void DeleteDestination(string destinationNbr)
        {
            DatabaseConnection.Query("DELETE FROM Destination WHERE destId= '" + destinationNbr + "'");
        }
        public void UpdateDestination(string city, string country, string hotel, string destinationNbr)
        {
            DatabaseConnection.Query("UPDATE Destination SET city = '" + city + "', country = '" + country + "', hotel = '" + hotel + "' WHERE destId = '" + destinationNbr + "'");
        }

        public void AddBooking(int customerNbr, int destinationNbr, string dateOut, string dateHome)
        {
            DatabaseConnection.Query("INSERT INTO Booking (cId, dId, dateOut, dateHome) VALUES('" + customerNbr + " ', '" + destinationNbr + "', '" + dateOut + "', '" + dateHome + "');");
        }
        public void DeleteBooking(int bookingNbr)
        {
            DatabaseConnection.Query("DELETE FROM Booking WHERE BookingNbr = '" + bookingNbr + "'");
        }
        public void UpdateBooking(string dateOut, string dateHome, int bookingNbr)
        {
            DatabaseConnection.Query("UPDATE Booking SET dateOut = '" + dateOut + "', dateHome = '" + dateHome + "' WHERE bookingNbr = '" + bookingNbr + "'");
        }

        public DataTable GetCustomers()
        {

            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {

                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT custId AS 'Customer No.', name AS 'Name', address AS 'Address', ssn AS 'SSN' FROM Customer", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;
            }
        }
        public DataTable GetDestinations()
        {
            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT destId AS 'Destination No.', city AS 'City', country AS 'Country', hotel AS 'Hotel' FROM Destination", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;
            }
        }
        public DataTable GetBookings()
        {
            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Booking.cId AS 'Customer No.', Customer.name AS 'Customer Name', Booking.dId AS 'Destination No.', Destination.city AS City, dateOut AS 'Date out', dateHome AS 'Date home', bookingNbr AS 'Booking No.' FROM Booking JOIN Destination ON Destination.destId = Booking.dId JOIN Customer ON Customer.custId = Booking.cId", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;
            }
        }

      
    }
}

