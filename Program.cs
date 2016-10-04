using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlights
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger[] passengers = new Passenger[] {
            new Passenger("John", 100, 200),
            new Passenger("Mark", 101, 200),
            new Passenger("Charlie", 102, 201)};

            Flight[] flights = new Flight[] {
            new Flight(200, "Berlin", "Moscow", "05.10.2016"),
            new Flight(201, "Paris", "Madrid", "06.10.2016")};

            var searchId = Int32.Parse(args[0]);

            var data = from f in flights
                       join p in passengers on f.ID equals p.Flight
                       where f.ID == searchId
                       select new { flight = f, passenger = p };

            if (data.Any())
            {
                var format = "{0} departs {1} for {2} on flight {3} in seat {4} on {5}";
                foreach (var item in data)
                {
                    Console.WriteLine(string.Format(format, item.passenger.Name, item.flight.Origin, item.flight.Destination,item.flight.ID, item.passenger.Seat, item.flight.Date));
                }
            }
        }
    }

}