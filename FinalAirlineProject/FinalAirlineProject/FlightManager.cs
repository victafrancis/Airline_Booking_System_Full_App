using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAirlineProject
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] listFlights;

        public FlightManager(int maxFlt)
        {
            this.maxFlights = maxFlt;
            numFlights = 0;
            listFlights = new Flight[maxFlights];
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) return false;
            listFlights[numFlights] = new Flight(flightNo, origin, destination, maxSeats);
            numFlights++;
            return true;
        }

        private int findFlight(int flightNo)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (listFlights[i].getFlightNumber() == flightNo)
                    return i;
            }
            return -1;
        }

        public bool flightExist(int flightNo)
        {
            if (findFlight(flightNo) == -1) return false;
            return true;
        }

        public Flight getFlight(int flightNo)
        {
            int loc = findFlight(flightNo);
            return listFlights[loc];
        }

        public bool deleteFlight(int flightNo)
        {
            int loc = findFlight(flightNo);
            if (loc == -1) return false;
            listFlights[loc] = listFlights[numFlights - 1];
            numFlights--;
            return true;
        }

        public string getFlightList()
        {
            string output ="[flight #] from [start point] to [end point]\n";
            for (int i = 0; i < numFlights; i++)
            {
                output += listFlights[i].getFlightNumber() + " from " + listFlights[i].getOrigin() + " to " +
                    listFlights[i].getDestination() + "\n";
            }
            return output;
        }
    }
}
