using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class classMenu
    {
        Manager m = new Manager();

        public void mainMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ Airlines Limited.");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1: Customers");
            Console.WriteLine("2: Flights");
            Console.WriteLine("3: Bookings");
            Console.WriteLine("4: Exit");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        customerMenu();
                        break;
                    case 2:
                        flightMenu();
                        break;
                    case 3:
                        bookingMenu();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);

        }
        public void customerMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Customer Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Add Customer");
            Console.WriteLine("2. View Customers");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1: // Add Customer
                        Console.Clear();
                        string fName;
                        string lName;
                        string phone;
                        long phoneNum;
                        Console.WriteLine("Adding new customer...\nPlease enter the following:");
                        Console.Write("First Name: ");
                        fName = Console.ReadLine();
                        while (String.IsNullOrEmpty(fName))
                        {
                            Console.Write(" Name cannot be empty.\n Please try again: ");
                            fName = Console.ReadLine();
                        }
                        Console.Write("Last Name: ");
                        lName = Console.ReadLine();
                        while (String.IsNullOrEmpty(lName))
                        {
                            Console.Write(" Name cannot be empty.\n Please try again: ");
                            lName = Console.ReadLine();
                        }
                        Console.Write("Phone Number (no dashes or spaces): ");
                        phone = Console.ReadLine();
                        while (!Int64.TryParse(phone, out phoneNum))
                        {
                            Console.Write("Not a valid phone number, please try again: ");
                            phone = Console.ReadLine();
                        }

                        if (m.addCustomer(fName, lName, phoneNum) == false)
                            Console.WriteLine("\nCustomer already exists.\nPlease try again.");
                        else
                            Console.WriteLine("\nCustomer successfully added!");

                        m.addCustomer(fName, lName, phone);
                        Console.WriteLine("\nPress any key to go back to the Customer Menu...");
                        Console.ReadKey();
                        customerMenu();
                        break;
                    case 2: // View All Customers
                        Console.Clear();
                        Console.WriteLine(m.listAllCustomers());
                        Console.WriteLine("\nPress any key to go back to the Customer Menu...");
                        Console.ReadKey();
                        customerMenu();
                        break;
                    case 3: // Delete Customer
                        Console.Clear();
                        string delete;
                        int d;
                        Console.WriteLine(m.listAllCustomers());
                        Console.WriteLine("Removing a customer...");
                        Console.Write("\nEnter a Customer ID to delete: ");
                        delete = Console.ReadLine();
                        while (!int.TryParse(delete, out d))
                        {
                            Console.Write("Not a valid ID, please try again: ");
                            phone = Console.ReadLine();
                        }
                        
                        if (m.deleteCustomer(delete) == true)
                            Console.WriteLine("\nSuccessfully Deleted.");
                        else 
                            Console.WriteLine("\nNo customer found.");

                        Console.WriteLine("\nPress any key to go back to the Customer Menu...");
                        Console.ReadKey();
                        customerMenu();
                        break;
                    case 4:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }

        public void flightMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Flight Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Add Flights");
            Console.WriteLine("2. View Flights");
            Console.WriteLine("3. View a particular Flight");
            Console.WriteLine("4. Delete Flight");
            Console.WriteLine("5. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1: // Add Flight
                        Console.Clear();
                        string flightNum;
                        int fn;
                        string origin;
                        string destination;
                        string numSeats;
                        int ns;
                        Console.WriteLine("Adding new flight...\nPlease enter the following:");
                        Console.Write("Flight Number: ");
                        flightNum = Console.ReadLine();
                        while (!int.TryParse(flightNum, out fn))
                        {
                            Console.Write("Not a valid input, please try again: ");
                            flightNum = Console.ReadLine();
                        }
                        Console.Write("Flight Origin: ");
                        origin = Console.ReadLine();
                        while (String.IsNullOrEmpty(origin))
                        {
                            Console.Write(" Field cannot be empty.\n Please try again: ");
                            origin = Console.ReadLine();
                        }
                        Console.Write("Flight Destination: ");
                        destination = Console.ReadLine();
                        while (String.IsNullOrEmpty(destination))
                        {
                            Console.Write(" Field cannot be empty.\n Please try again: ");
                            destination = Console.ReadLine();
                        }
                        Console.Write("Number of Seats: ");
                        numSeats = Console.ReadLine();
                        while (!int.TryParse(numSeats, out ns))
                        {
                            Console.Write("Not a input, please try again: ");
                            numSeats = Console.ReadLine();
                        }
                        m.addFlight(flightNum, origin, destination, numSeats);
                        Console.WriteLine("\nPress any key to go back to the Flight Menu...");
                        Console.ReadKey();
                        flightMenu();
                        break;
                    case 2: // List all Flights
                        Console.WriteLine(m.listAllFlights());
                        Console.WriteLine("\nPress any key to go back to the Flight Menu...");
                        Console.ReadKey();
                        flightMenu();
                        break;
                    case 3: // View Specific Flight
                        Console.Clear();
                        int fNum;
                        string fnString;
                        Console.Write("Finding Specific Flight...\nPlease enter Flight Number: ");
                        fnString = Console.ReadLine();
                        while (!int.TryParse(fnString, out fNum))
                        {
                            Console.Write("Not a valid flight number, please try again: ");
                            fnString = Console.ReadLine();
                        }
                        Console.WriteLine("\nPress any key to go back to the Flight Menu...");
                        Console.ReadKey();
                        flightMenu();
                        break;
                    case 4: // Delete Flight
                        Console.Clear();
                        int d;
                        string delete;
                        Console.WriteLine(m.listAllFlights());
                        Console.WriteLine("Removing a flight...");
                        Console.Write("\nEnter a Flight ID to delete: ");
                        delete = Convert.ToInt32(Console.ReadLine());

                        while (!int.TryParse(delete, out d))
                        {
                            Console.Write("Not a valid flight ID, please try again: ");
                            delete = Console.ReadLine();
                        }

                        if (m.CheckExistFlight(delete) == true)
                        {
                            if (m.deleteFlight(delete) == true)
                                Console.WriteLine("\nSuccessfully deleted");
                            else
                                Console.WriteLine("\nThis flight has passengers. Remove passengers first.");
                        }
                        else
                            Console.WriteLine("\nCannot find flight.");

                        Console.WriteLine("\nPress any key to go back to the Flight Menu...");
                        Console.ReadKey();
                        flightMenu();
                        break;
                    case 5:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }

        public void bookingMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Booking Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Make Booking");
            Console.WriteLine("2. View Bookings");
            Console.WriteLine("3. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        // add booking function
                        int c;
                        int f;
                        Console.WriteLine(m.listAllCustomers());
                        Console.WriteLine(m.listAllFlights());
                        Console.WriteLine("Enter customer id");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter flight id");
                        f = Convert.ToInt32(Console.ReadLine());
                        m.addBooking(c,f);
                        Console.WriteLine(m.listAllBookings());
                        break;
                    case 2:
                        // view booking function
                        Console.WriteLine(m.listAllBookings());
                        break;
                    case 3:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }
    }
}
