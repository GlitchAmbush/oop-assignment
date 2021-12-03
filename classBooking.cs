using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oopAssignment
{
    class Booking
    {
          private DateTime date { get; }
        private int bookingID { get; }
        private Customer c { get; }
        private Flight f { get; }
        public Booking(DateTime date, int bookingID, int flightID, Customer customer, Flight flight)
        {
            this.date = date;
            this.bookingID = bookingID;
            c = customer;
            f = flight;
            
        }
        
        public string toString() {
            string s = "Booking";
            s += "\nBooking id :" + bookingID;
            s += "\nBooking date: " + date;;
            return s;
        }
    }
}
