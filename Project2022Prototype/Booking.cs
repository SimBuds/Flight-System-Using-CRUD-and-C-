using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    internal class Booking
    {
        // Booking class holding two objects from Flight and Customers
        private int bookingNum;
        private Flight flightNumber;
        private Customer customerNumber;

        public Booking(int bookingNum, Flight flightNumber, Customer customerNumber)
        {
            this.bookingNum = bookingNum;
            this.flightNumber = flightNumber;
            this.customerNumber = customerNumber;
        }

        public int getBookingNum()
        {
            return bookingNum;
        }

        public void setBookingNum(int bookingNum)
        {
            this.bookingNum = bookingNum;
        }

        public Flight getFlightNumber()
        {
            return flightNumber;
        }

        public void setFlightNumber(Flight flightNumber)
        {
            this.flightNumber = flightNumber;
        }


        public Customer getCustomerNumber()
        {
            return customerNumber;
        }

        public void setCustomerNumber(Customer customerNumber)
        {
            this.customerNumber = customerNumber;
        }


        public override string ToString()
        {
            return $"\nBooking ID: {bookingNum} \n{flightNumber} \n{customerNumber}";
        }
    }
}
