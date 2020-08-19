using System.Collections.Generic;
using Transport.ly.App.Model;

namespace Transport.ly.App.Data
{
    public class FlightMockDataProvider: IFlightDataProvider
    {

        public FlightSchedule Load()
        {
            var Montreal = new IATA("YUL");
            var Toronto = new IATA("YYZ");
            var Calgary = new IATA("YYC");
            var Vancouver = new IATA("YVR");
            var data = new Dictionary<int, IReadOnlyList<Flight>>
            {
                {
                    1, new List<Flight>(3)
                        {
                            new Flight(1, Montreal, Toronto),
                            new Flight(2, Montreal, Calgary),
                            new Flight(3, Montreal, Vancouver),
                        }
                },
                {
                    2, new List<Flight>(3)
                        {
                            new Flight(4, Montreal, Toronto),
                            new Flight(5, Montreal, Calgary),
                            new Flight(6, Montreal, Vancouver),
                        }
                }
            };
            var schedule = new FlightSchedule(data);
            return schedule;
        }
    }
}
