using System.Collections.Generic;

namespace Transport.ly.App.Model
{
    public class FlightSchedule
    {
        public IDictionary<int, IReadOnlyList<Flight>> Flights { get; private set; } = new Dictionary<int, IReadOnlyList<Flight>>();

        public FlightSchedule(IDictionary<int, IReadOnlyList<Flight>> flights)
        {
            Flights = flights;
        }
    }
}
