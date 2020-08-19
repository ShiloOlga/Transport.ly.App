using System.Collections.Generic;
using Transport.ly.App.Model;

namespace Transport.ly.App.Data
{
    public interface IFlightRepository
    {
        void Initialize(FlightSchedule schedule);
        IEnumerable<ScheduledFlight> GetAllFlights();
        ScheduledFlight ScheduleFlightAndBookItem(IATA destination);
    }
}
