using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAirlineProject
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] listPassenger;

        public Flight(int flightNumber, string origin, string destination, int maxSeats)
        {
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            this.maxSeats = maxSeats;
            numPassengers = 0;
            listPassenger = new Customer[maxSeats];
        }

        public bool addPassenger(Customer cust)
        {
            if (numPassengers >= maxSeats) return false;
            listPassenger[numPassengers] = cust;
            numPassengers++;
            return true;
        }

        public int findPassenger(int custId)
        {
            for (int i = 0; i < numPassengers; i++)
            {
                if (listPassenger[i].getCustomerId() == custId)
                    return i;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            listPassenger[loc] = listPassenger[numPassengers - 1];
            return true;
        }

        public string getPassengerList()
        {
            string output = "Passenger List:\nNumber\tName\t\tPhone\n";
            for (int i = 0; i < numPassengers; i++)
            {
                output += listPassenger[i].getCustomerId() + "\t" + listPassenger[i].getFirstName() + " " +
                    listPassenger[i].getLastName() + "\t" + listPassenger[i].getPhone() + "\n";
            }
            return output;
        }

        public int getFlightNumber() { return flightNumber; }

        public string getOrigin() { return origin; }

        public string getDestination() { return destination; }

        public int getMaxSeats() { return maxSeats; }

        public int getNumPassengers() { return numPassengers; }

        public string toString()
        {
            string output = "Flight Number: " + flightNumber + "\nOrigin: " + origin + "\nDestination: " + destination +
                "\nMax Seats: " + maxSeats + "\nNo. of Passengers: " + numPassengers + "\n";
            return output;
        }

    }
}
