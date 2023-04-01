using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    // Casey Hsu - Student Id: 101376814
    // Lukas Canji - Student Id: 101329428
    // Eric Grigor - Student Id: 100668121
    // Ryan Lee - Student Id: 101296633
    
    internal class Coordinator
    {
        // Declaring that the manager classes are global variables so
        // their class functions become available for the coordinator to later call
        private CustomerManager customerManager;
        private FlightManager flightManager;
        private BookingManager bookingManager;

        public Coordinator(CustomerManager customerManager, FlightManager flightManager, BookingManager bookingManager)
        {
            this.customerManager = customerManager;
            this.flightManager = flightManager;
            this.bookingManager = bookingManager;
        }

        // Customer Functions
        // These functions are just a validation and call to manager class functions

        public bool addCustomer(string customerfName, string customerlName, string customerPhone,
            string customerEmail, string customerAddress, int numBookings, bool status)
        {
            // Calling Customer Manager Function
            return customerManager.addCustomer(customerfName, customerlName, customerPhone,
                customerEmail, customerAddress, numBookings, status);
        }

        public string listCustomers()
        {
            if (customerManager != null)
            {
                // Calling Customer Manager Function
                return customerManager.listCustomers();
            }
            else
            {
                return null;
            }
        }

        public string findCustomer(int customerId)
        {
            if (customerManager != null)
            {
                // Calling Customer Manager Function
                return customerManager.findCustomer(customerId);
            }
            return null;

        }

        public string findCustomerOutput(int customerId)
        {
            if (customerManager != null)
            {
                // Calling Customer Manager Function
                return customerManager.findCustomerOutput(customerId);
            }
            return null;

        }

        public bool deleteCustomer(int customerId)
        {
            if (customerManager != null)
            {
                // Calling Customer Manager Function
                return customerManager.deleteCustomer(customerId);
            }
            return false;
        }

        // Flight Functions
        // These functions are just a validation and call to manager class functions

        public bool addFlight(string airport, string destination, string date, int capacity)
        {
            if (flightManager != null)
            {
                // Calling Flight Manager Function
                return flightManager.addFlight(airport, destination, date, capacity);               
            }
            return false;
        }

        public string listFlights()
        {
            if (flightManager != null)
            {
                // Calling Flight Manager Function
                return flightManager.listFlights();
            }

            return null;
        }

        public string findFlight(int flightNumber)
        {
            if (flightManager != null)
            {
                // Calling Flight Manager Function
                return flightManager.findFlight(flightNumber);
            }
            return null;
        }

        public bool deleteFlight(int flightNumber)
        {
            if (flightManager != null)
            {
                // Calling Flight Manager Function
                return flightManager.deleteFlight(flightNumber);
            }
            return false;
        }

        public bool addPassenger(int passengerId, Customer customer)
        {
            if (flightManager != null)
            {
                // Calling Flight Manager Function
                flightManager.addPassenger(passengerId, customer);
            }
            return false;
        }

        public string getPassengersList(int flightNumber)
        {
            if (flightManager != null)
            {
                // Calling Flight Manager Function
                flightManager.getPassengersList(flightNumber);
            }
            return null;
        }

        // Booking Functions
        // These functions are just a validation and call to manager class functions

        public bool addBooking(int flightNum, int customerNum, string destination)
        {
            // This was our solution for adding to booking since the manager classes shouldn't be interacting
            // in the back end so I then call the functions to return the specific object within the scope of the function
            Customer customerObject = customerManager.objectCustomer(customerNum);
            Flight flightObject = flightManager.objectFlight(flightNum);

            if (flightObject != null && customerObject != null) // If not null continue
            {
                // Customer number of booking increases by 1 thus not allowing to be deleted
                customerObject.setNumBookings(+1);

                // Setting the destination for the booking
                flightObject.setDestination(destination);

                // Setting the customer to the manifest/passenger list

                flightObject.setPassengerList(customerObject);

                // Calling the booking function that only accepts two objects and
                // allowing me to access both managers through the coordinator
                return bookingManager.addBooking(flightObject, customerObject);
            }
            return false;
        }

        public string listBookings()
        {
            if (flightManager != null)
            {
                // Calling Booking Manager Function
                return bookingManager.listBookings();
            }
            else
            {
                return null;
            }
        }

        public string findBooking(int bookingNumber)
        {
            // Calling Booking Manager Function
            return bookingManager.findBooking(bookingNumber);
        }

        // This assignment has taught us a lot thank you Professor Andrew!
    }
}
