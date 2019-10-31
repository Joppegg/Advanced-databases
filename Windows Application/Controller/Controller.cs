using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Application.Views;
using Windows_Application.Models;
using System.Data;

namespace Windows_Application.Presenters
{
   public class Controller
    {
       private IView m_View;
       private IBooking booking;
       private Model model = new Model();
       private IAddCustomer addCustomer_View;
       private IUpdateCustomer updateCustomer_View;
       private IAddDestination addDestination_View;
       private IUpdateDestination updateDestination_View;
       private IUpdateBooking updateBooking_View;

        public Controller (IUpdateDestination updateDestinationView)
        {
            updateDestination_View = updateDestinationView;
        }

        public Controller(IAddDestination destinationView)
        {
            addDestination_View = destinationView;
        }

        public Controller (IUpdateBooking updateBookingView)
        {
            updateBooking_View = updateBookingView;
        }

        public Controller(IUpdateCustomer customerView)
        {
            updateCustomer_View = customerView;

        }

        public Controller (IView view)
        {
            m_View = view;
    
        }
        
        public Controller (IAddCustomer customerView)
        {
            addCustomer_View = customerView;
        }

        public Controller(AddBooking addBooking)
        {
            booking = addBooking;
        }

        public void AddBooking()
        {
            model.AddBooking(booking.CustomerNbr, booking.DestinationNbr, booking.DateOut.ToString(), booking.DateHome.ToString());
        }

        public void UpdateBooking()
        {
            model.UpdateBooking(updateBooking_View.DateOut.ToString(), updateBooking_View.DateHome.ToString(), updateBooking_View.BookingNbr);
        }

            public void AddCustomer()
        {
            model.AddCustomer(addCustomer_View.PersonName, addCustomer_View.PersonSsn, addCustomer_View.PersonAddress);
        }

        public void DeleteCustomer()
        {
        
            model.DeleteCustomer(m_View.CustomerNbr);
        }
        public void Updatecustomer()
        {
            model.UpdateCustomer( updateCustomer_View.PersonSsn, updateCustomer_View.PersonName, updateCustomer_View.PersonAddress, updateCustomer_View.CustomerNbr);
        }   
        
        public void AddDestination()
        {
            model.AddDestination(addDestination_View.DestinationCity, addDestination_View.DestinationCountry, addDestination_View.DestinationHotel);
        }
        public void UpdateDestination()
        {
            model.UpdateDestination(updateDestination_View.DestinationCity, updateDestination_View.DestinationCountry, updateDestination_View.DestinationHotel, updateDestination_View.DestinationNbr);
        }
        
        public void DeleteDestination()
        {
            model.DeleteDestination(m_View.DestinationNbr);
        }

        public void DeleteBooking()
        {
            model.DeleteBooking(m_View.BookingNbr);
        }
        
        public void PopulateTables()
        {
            DataTable dtblCustomers = model.GetCustomers();
            DataTable dtblDestinations = model.GetDestinations();
            DataTable dtblBookings = model.GetBookings();
            m_View.DataGridViewCustomer.DataSource = dtblCustomers;
            m_View.DataGridViewDestination.DataSource = dtblDestinations;
            m_View.DataGridViewBooking.DataSource = dtblBookings;

        }
        public void PopulateAddBookingTables()
        {
            DataTable dtblCustomers = model.GetCustomers();
            DataTable dtblDestinations = model.GetDestinations();
            booking.DataGridViewCustomer.DataSource = dtblCustomers;
            booking.DataGridViewDestination.DataSource = dtblDestinations;
        }
        public void PopulateUpdateBookingTables()
        {
            DataTable dtblCustomers = model.GetCustomers();
            DataTable dtblDestinations = model.GetDestinations();
            updateBooking_View.DataGridViewCustomer.DataSource = dtblCustomers;
            updateBooking_View.DataGridViewDestination.DataSource = dtblDestinations;
        }
    }

}
