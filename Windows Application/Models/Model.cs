
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
            DatabaseConnection.Query("EXEC InsertCustomer @ssn = '" + ssn + "', @name= '" + name + "', @address='" + address + "'");
        }   
        public void DeleteCustomer(string customerNbr)
        {
            DatabaseConnection.Query("EXEC deleteCustomer @customerNbr = '" + customerNbr + "'");
        }
        public void UpdateCustomer(string ssn, string name, string address, string customerNbr)
        {
            DatabaseConnection.Query("EXEC UpdateCustomer @name = '" + name + "', @address = '" + address + "', @ssn = '" + ssn + "', @customerNbr = '" + customerNbr + "'");
          
        }
        public void AddDestination(string city, string country, string hotel)
        {
            DatabaseConnection.Query("EXEC InsertDestination @city = '" + city + "', @country ='" + country + "', @hotel= '" + hotel + "'");
         
        }
        public void DeleteDestination(string destinationNbr)
        {
            DatabaseConnection.Query("EXEC DeleteDestination @destinationNbr = '" + destinationNbr + "'");
        }

        public void UpdateDestination(string city, string country, string hotel, string destinationNbr)
        {
            DatabaseConnection.Query("EXEC UpdateDestination @city = '" + city + "', @country = '" + country + "', @hotel = '" + hotel + "', @destinationNbr = '" + destinationNbr + "'");
        
        }

        public void AddBooking(int customerNbr, int destinationNbr, string dateOut, string dateHome)
        {
            DatabaseConnection.Query("EXEC CreateBooking @customerNbr = '" + customerNbr + "', @destinationNbr = '" + destinationNbr + "', @dateOut = '" + dateOut + "', @dateHome = '" + dateHome + "'");

        }
        public void DeleteBooking(int bookingNbr)
        {
            DatabaseConnection.Query("EXEC DeleteBooking @bookingNbr = '" + bookingNbr + "'");
        }
        public void UpdateBooking(string dateOut, string dateHome, int bookingNbr)
        {
            DatabaseConnection.Query("EXEC UpdateBooking @dateout = '" + dateOut + "', @dateHome = '" + dateHome + "', @bookingNbr = '"+ bookingNbr +"'");
         
        }



        public DataTable GetCustomers()
        {

            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("EXEC SelectAllCustomer", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;
            }
        }
        public DataTable GetDestinations()
        {
            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("EXEC SelectAllDestinations", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;    
            }
        }
        public DataTable GetBookings()
        {
            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("EXEC SelectAllBookings", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;
            }
        }



      
    }
}

