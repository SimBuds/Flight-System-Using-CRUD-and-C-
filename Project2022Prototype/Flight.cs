using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2022Prototype
{
    internal class Flight
    {
        // Flight Class
        private int flightNumber;
        private string departure;
        private string destination;
        private string date;
        private int capacity;
        private Customer[] passengerList;

        public Flight(int flightNumber, string departure, string destination, string date, int capacity)
        {
            this.flightNumber = flightNumber;
            this.departure = departure;
            this.destination = destination;
            this.date = date;
            this.capacity = capacity;
            passengerList = new Customer[capacity];
        }

        public int getFlightNumber()
        {
            return flightNumber;
        }

        public string getDeparture()
        {
            return departure;
        }

        public void setDeparture(string departure)
        {
            this.departure = departure;
        }

        public string getDestination()
        {
            return destination;
        }

        public void setDestination(string destination)
        {
            this.destination = destination;
        }

        public string getDate()
        {
            return date;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public Customer[] getPassengerList()
        {
            return passengerList;
        }

        // Solution to adding a Customer to the passengerList(Manifest)
        public void setPassengerList(Customer customer)
        {
            for (int i = 0; i < passengerList.Length; i++)
            {
                if (passengerList[i] == null)
                {
                    passengerList[i] = customer;
                }   
            }
        }

        public override string ToString()
        {
            return $"\nFlight Number: {flightNumber} \nAirport: {departure} \nDestination: {destination} \nDate: {date} \nCapacity: {capacity} \nPassengers: {passengerList.Length}";
        }
    }
}
