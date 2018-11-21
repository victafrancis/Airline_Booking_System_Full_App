using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAirlineProject
{
    class Booking
    {
        private int bookingId;
        private string bookingDate;
        private Flight flight;
        private Customer customer;

        public Booking(int bookingId, string bookingDate, Flight flight, Customer customer)
        {
            this.bookingId = bookingId;
            this.bookingDate = bookingDate;
            this.flight = flight;
            this.customer = customer;
        }

        public int getBookingId() { return bookingId; }

        public string getBookingDate() { return bookingDate; }

        public Flight getFlight() { return flight; }

        public Customer getCustomer() { return customer; }

        public string toString()
        {
            string output = "Booking ID: " + bookingId + "\nBooking Date: " + bookingDate + "\nFlight ID: " + flight.getFlightNumber()
                + "Customer ID: " + customer.getCustomerId();
            return output;
        }

    }
}
