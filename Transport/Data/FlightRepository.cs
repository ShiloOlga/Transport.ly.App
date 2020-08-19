
using System.Collections.Generic;
using System.Linq;
using Transport.ly.App.Model;

namespace Transport.ly.App.Data
{
    public class FlightRepository : IFlightRepository
    {
        private const int PlainCapacity = 20;
        private IList<ScheduledFlight> _flights;

        public void Initialize(FlightSchedule schedule)
        {
            _flights = new List<ScheduledFlight>(schedule.Flights.Count);
            _flights = schedule.Flights
               .SelectMany(x => x.Value.Select(y => new { Day = x.Key, Flight = y }))
               .Select(x => new ScheduledFlight(x.Day, x.Flight))
               .ToList();
        }

        public ScheduledFlight ScheduleFlightAndBookItem(IATA destination)
        {
            var flight = _flights.FirstOrDefault(x => x.To == destination && x.CurrectCapacity < PlainCapacity);
            if (flight != null)
            {
                flight.CurrectCapacity++;
            }
            return flight;
        }

        public IEnumerable<ScheduledFlight> GetAllFlights()
        {
            return _flights;
        }
    }
}
