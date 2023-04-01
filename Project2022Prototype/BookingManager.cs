using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    internal class BookingManager
    {
        private static int bookingId = 1;
        private int numBookings;
        private int maxBookings;
        private Booking[] bookingList;

        public BookingManager(int maxbookings)
        {
            numBookings = 0;
            this.maxBookings = maxbookings;
            bookingList = new Booking[maxBookings];
        }

        // Searching function
        public int search(int bookingNumber)
        {
            if (numBookings != 0)
            {
                for (int i = 0; i < numBookings; i++)
                {
                    if (bookingList[i].getBookingNum() == bookingNumber)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        // Functionally the same as flights and customers but accepting two objects
        // This is called later in the coordinator
        public bool addBooking(Flight flightNumber, Customer customerNumber)
        {
            if (numBookings < maxBookings)
            {
                bookingList[numBookings] = new Booking(bookingId, flightNumber, customerNumber);
                numBookings++;
                bookingId++;
            }
            return false;
        }

        // Functionally the same as flights and customers
        public string listBookings()
        {
            if (numBookings != 0)
            {
                string temp = "";

                for (int i = 0; i < numBookings; i++)
                {
                    temp += bookingList[i].ToString();
                }

                return temp;
            }
            return null;
        }

        // Functionally the same as flights and customersand customers
        public string findBooking(int bookingNumber)
        {
            int location = search(bookingNumber);

            if (location != -1)
            {
                return bookingList[location].ToString();
            }

            return null;
        }
    }
}
