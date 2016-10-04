using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlights
{
    class Flight
    {
        public Flight(int id, string origin, string destination, string date)
        {
            ID = id;
            Origin = origin;
            Destination = destination;
            Date = date;
        }

        public int ID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }
    }
}
