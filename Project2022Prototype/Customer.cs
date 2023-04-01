using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    internal class Customer
    {
        // Customer Class
        private int customerId;
        private string customerfName;
        private string customerlName;
        private string customerPhone;
        private string customerEmail;
        private string customerAddress;
        private int numBookings;
        private bool status;

        public Customer(int customerId, string customerfName, string customerlName, string customerPhone, string customerEmail, string customerAddress, int numBookings, bool status)
        {
            this.customerId = customerId;
            this.customerfName = customerfName;
            this.customerlName = customerlName;
            this.customerPhone = customerPhone;
            this.customerEmail = customerEmail;
            this.customerAddress = customerAddress;
            this.numBookings = numBookings;
            this.status = status;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public string getCustomerfName()
        {
            return customerfName;
        }

        public void setCustomerfName(string customerfName)
        {
            this.customerfName = customerfName;

        }

        public string getCustomerlName()
        {
            return customerlName;
        }

        public void setCustomerlName(string customerName)
        {
            this.customerlName = customerName;
        }

        public string getCustomerPhone()
        {
            return customerPhone;
        }

        public void setCustomerPhone(string customerPhone)
        {
            this.customerPhone = customerPhone;
        }

        public string getCustomerEmail()
        {
            return customerEmail;
        }

        public void setCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public string getCustomerAddress()
        {
            return customerAddress;
        }

        public void setcustomerAddress(string customerAddress)
        {
            this.customerAddress = customerAddress;
        }

        public int getNumBookings()
        {
            return numBookings;
        }

        public void setNumBookings(int numBookings)
        {
            this.numBookings = numBookings;
        }

        public bool getStatus()
        {
            return status;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }

        public override string ToString()
        {
            return $"\nCustomer ID: {customerId} \nCustomers First Name: {customerfName} \nCustomer Last Name: {customerlName} \nCustomer Phone: {customerPhone}" +
                $" \nCustomer Email: {customerEmail} \nCustomer Address: {customerAddress} \nNumber of Bookings: {numBookings} \nActive Status: {status}\n";
        }
    }
}
