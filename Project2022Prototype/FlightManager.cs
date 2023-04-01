using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    internal class FlightManager
    {
        // Static increment timer and plan was to read from file count
        // the objects and reasign to flightNumber once closing of application
        private static int flightNumber = 1;
        private int numFlights;
        private int maxFlights;
        private Flight[] flightList;

        public FlightManager(int maxFlights)
        {
            numFlights = 0;
            this.maxFlights = maxFlights;
            flightList = new Flight[maxFlights];
        }

        public void writeFlights(FlightManager flightList)
        {
            try
            {
                // Writing from object to flights.txt
                StreamWriter writer = new StreamWriter("..\\..\\..\\lib\\flights.txt", false);
                writer.WriteLine(flightList.flightsToFile());
                writer.Close();
            }
            catch (Exception exception)
            {
                throw new ApplicationException("File was not found", exception);
            }
        }

        public string flightsToFile()
        {
            if (numFlights != 0)
            {
                string temp = "";
                for (int i = 0; i < numFlights; i++)
                {
                    // Grabbing the string literal values and adding comma as a seperator
                    temp += flightList[i].getFlightNumber() + ",";
                    temp += flightList[i].getDeparture() + ",";
                    temp += flightList[i].getDestination() + ",";
                    temp += flightList[i].getDate() + ",";
                    temp += flightList[i].getPassengerList() + Environment.NewLine;
                    // Enviroment.NewLine built in class for new line
                }
                return temp;
            }
            return null;
        }

        public int search(int flightNumber)
        {
            // Created a function to search the index of the Manager Flight Array
            if (numFlights != 0)
            {
                for (int i = 0; i < numFlights; i++)
                {
                    // If the number matches return the index location of the object
                    if (flightList[i].getFlightNumber() == flightNumber)
                    {
                        return i;
                    }
                }
            }
            // Returning -1 so we can later use it in if statements as a true or false
            return -1;
        }

        public string getPassengersList(int flightNumber)
        {
            // Searching for a specific flight
            int location = search(flightNumber);

            // If location is found then execute
            if (location != -1)
            {
                // Temp is a String Building variable to hold each objects ToString
                string temp = "";

                for (int i = 0; i < temp.Length; i++)
                {
                    temp += flightList[location].ToString() + Environment.NewLine;
                }
                // Returning the String Builder
                return temp;
            }
            return null;
        }

        public bool addFlight(string departure, string destination, string date, int capacity)
        {
            // If there is room to add into the Manager then execute
            if (numFlights < maxFlights)
            {
                flightList[numFlights] = new Flight(flightNumber, departure, destination, date, capacity);
                numFlights++;
                // Static (Shared variable) that is incrementing on each addition to flight
                flightNumber++;
            }
            return false;
        }

        public string listFlights()
        {
            // Checking if there are 0 flights
            if (numFlights != 0)
            {
                string temp = "";
                for (int i = 0; i < numFlights; i++)
                {
                    // Building String
                    temp += flightList[i].ToString() + Environment.NewLine;
                }
                return temp;
            }
            return null;
        }

        public string findFlight(int flightNumber)
        {
            // Calling the above function
            int location = search(flightNumber);

            // Checking if it exists
            if (location != -1)
            {
                // returning the Specific flight
                return flightList[location].ToString();
            }
            return null;
        }

        public bool deleteFlight(int flightNumber)
        {
            int location = search(flightNumber);

            if (location != -1)
            {
                // Shifting the indexes down to delete the flight object
                flightList[location] = flightList[numFlights];
                numFlights--;
            }
            return true;
        }

        public Flight objectFlight(int flightNumber)
        {
            int location = search(flightNumber);

            if (location != -1)
            {
                // Searches for a specific flight and returns that object to be added to the booking class
                return flightList[location];
            }
            return null;
        }

        public void addPassenger(int flightId, Customer customer)
        {
            int location = search(flightId);

            if (location != -1)
            {
                // Adding passenger function to assign the flight to a booking object
                flightList[location].setPassengerList(customer);
            }
        }
    }
}