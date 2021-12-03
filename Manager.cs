using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class Manager
    {
        private oopAssignment.Customer[] clist;
        private oopAssignment.Booking[] blist;
        private int numCustomer;
        private int numBookings;
        private int numFlight;
        private int maxBookings;
        private int maxCustomer;
        private int maxFlights;

        public Manager()
        {
            numCustomer = 0;
            numBookings = 0;
            numFlight = 0;
            maxCustomer = 100;
            maxBookings = 99999;
            maxFlights = 99999;
            clist = new Customer[maxCustomer];
            blist = new Booking[maxBookings];
            flist = new Flight[maxFlights];
        }

        public bool addCustomer(string fnam, string lName, long phone)
        {
            if (numCustomer < maxCustomer)
            {
                Random rnd = new Random();
                int id = rnd.Next(10000, 99999);
                clist[numCustomer] = new Customer(id, fnam, lName, phone);
                numCustomer++;
                return true;
            }
            return false;
        }

        public string listAllCustomers()
        {
            string s = "=== Customer List ===\n";
            for (int i = 0; i < numCustomer; i++)
            {
                if (clist[i].GetType() == typeof(Customer))
                {
                    s += ((Customer)clist[i]).ToString() + "\n";
                }
            }
            return s;
        }

        public int findCustomer(int custId)
        {
            for (int x = 0; x < maxBookings; x++)
            {
                if (clist[x].getCustomerID() == custId)
                    return x;
            }
            return -1;
        }

        public bool deleteCustomer(int custId)
        {
            int loc = findCustomer(custId);
            if (loc == -1) return false;
            clist[loc] = clist[numCustomer - 1];
            numCustomer--;
            return true;
        }

        public string listAllFlights()
        {
            string s = "=== Flight List ===\n";
            for (int i = 0; i < numFlight; i++)
            {
                if (flist[i].GetType() == typeof(Flight))
                {
                    s += flist[i].toString() + "\n";
                }
            }
            return s;
        }
        public int findFlight(int fNum)
        {
            for (int x = 0; x < maxBookings; x++)
            {
                if (flist[x].getFlightNumber() == fNum)
                    return x;
            }
            return -1;
        }

        public string findSpecificFlight(int fNum)
        {
            string s = "";
            int loc = findFlight(fNum);
            if (loc == -1)
            {
                s = "Flight not found.";
            }
            s += "=== Flight ===\n";
            s += flist[loc].toString();
            return s;
        }

        public bool deleteFlight(int flightID)
        {
            int loc = findFlight(flightID);
            if (flist[loc].getNumPassengers() > 0) return false;
            flist[loc] = flist[numFlight - 1];
            numFlight--;
            return true;
        }

        public bool CheckExistFlight(int flightID)
        {
            int loc = findFlight(flightID);
            if (loc == -1) return false;
            return true;
        }

        public bool addBooking(int customerID, int flightID)
        {
            if (numBookings < maxBookings)
            {
                Random rnd = new Random();
                int bID = rnd.Next(100, 999);
                string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                blist[numBookings] = new Booking(date, bID, customerID, flightID);
                numBookings++;
                return true;
            }
            return false;
        }
    }
}
