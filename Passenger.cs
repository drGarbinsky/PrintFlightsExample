using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlights
{
    class Passenger
    {
        public Passenger(string name, int seat, int flight)
        {
            Name = name;
            Seat = seat;
            Flight = flight;
        }

        public int Flight { get; set; }

        public int Seat { get; set; }

        public string Name { get; set; }
    }
}
