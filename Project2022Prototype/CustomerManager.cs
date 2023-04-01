using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    internal class CustomerManager
    {
        // Static increment timer and plan was to read from file count
        // the objects and reasign to flightNumber once closing of application
        private static int customerId = 1;
        private int numCustomers;
        private int maxCustomers;
        private Customer[] customerList;

        public CustomerManager(int maxCustomers)
        {
            numCustomers = 0;
            this.maxCustomers = maxCustomers;
            customerList = new Customer[maxCustomers];
        }

        // Search used again
        public int search(int customerId)
        {
            if (numCustomers != 0)
            {
                for (int i = 0; i < numCustomers; i++)
                {
                    if (customerList[i].getCustomerId() == customerId)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static void readCustomers()
        {
            // Function for reading from a file back to a object
            Customer[] tempCustomers;
            string line;
            if (File.Exists("..\\..\\..\\lib\\customers.csv")) // Checking if file exists
            {
                StreamReader reader = new StreamReader("..\\..\\..\\lib\\customers.csv");
                // Number of customers on the first line of the text file to determine how many customers to write and read to static variable
                int numCustomers = Convert.ToInt32(reader.ReadToEnd());
                // Adding a padding to existing manager that was saved to file
                tempCustomers = new Customer[numCustomers + 100];

                for (int i = 0; i < numCustomers; i++)
                {
                    // Grabbing line
                    line = reader.ReadLine();
                    // Breaking each comma seperated value
                    string[] indexes = line.Split(',');
                    // Adding the values to each temp Customer
                    tempCustomers[i] = new Customer(Int32.Parse(indexes[0]), indexes[1], indexes[2], indexes[3], indexes[4], indexes[5], Int32.Parse(indexes[6]), bool.Parse(indexes[7]));
                }
                reader.Close();
            }
        }

        public void writeCustomers(CustomerManager customerManager)
        {
            try
            {
                // Writing is the same as Flights
                StreamWriter writer = new StreamWriter("..\\..\\..\\lib\\customers.txt", false);
                writer.WriteLine(customerManager.customersToFile());
                writer.Close();
            }
            catch (Exception exception)
            {
                throw new ApplicationException("File was not found", exception);
            }
        }

        public string customersToFile()
        {
            if (numCustomers != 0)
            {
                string temp = "";
                for (int i = 0; i < numCustomers; i++)
                {
                    // Same implementation as Flight for file from customer object
                    temp += customerList[i].getCustomerId() + ",";
                    temp += customerList[i].getCustomerfName() + ",";
                    temp += customerList[i].getCustomerlName() + ",";
                    temp += customerList[i].getCustomerPhone() + ",";
                    temp += customerList[i].getCustomerEmail() + ",";
                    temp += customerList[i].getCustomerAddress() + ",";
                    temp += customerList[i].getNumBookings() + ",";
                    temp += customerList[i].getStatus() + Environment.NewLine;
                }
                return temp;
            }
            return null;
        }

        // Functionally the same as flights
        public bool addCustomer(string customerfName, string customerlName, string customerPhone,
            string customerEmail, string customerAddress, int numBookings, bool status)
        {
            if (numCustomers < maxCustomers)
            {
                customerList[numCustomers] = new Customer(customerId, customerfName, customerlName,
                    customerPhone, customerEmail, customerAddress, numBookings, status);
                numCustomers++;
                customerId++;
            }
            return false;
        }

        // Functionally the same as flights
        public string listCustomers()
        {
            if (numCustomers != 0)
            {
                string temp = "";

                for (int i = 0; i < numCustomers; i++)
                {
                    temp += customerList[i].ToString();
                }

                return temp;
            }
            return null;
        }

        // Functionally the same as flights
        public string findCustomer(int customerId)
        {
            int location = search(customerId);

            if (location != -1)
            {
                return customerList[location].ToString();
            }

            return null;
        }

        // Functionally the same as flights
        public string findCustomerOutput(int customerId)
        {
            int location = search(customerId);

            if (location != -1)
            {
                return Convert.ToString(customerList[location].getCustomerId());
            }

            return null;
        }

        // Functionally the same as flights
        public bool deleteCustomer(int customerId)
        {
            int location = search(customerId);

            if (location != -1)
            {
                // If the number of bookings is 0 then delete this Customer Object
                if (customerList[location].getNumBookings() == 0)
                {
                    customerList[location] = customerList[numCustomers];
                    numCustomers--;
                }
            }
            return true;
        }

        // Functionally the same as flights just returning a customer object instead.
        public Customer objectCustomer(int customerId)
        {
            int location = search(customerId);

            if (location != -1)
            {
                return customerList[location];
            }
            return null;
        }
    }
}
