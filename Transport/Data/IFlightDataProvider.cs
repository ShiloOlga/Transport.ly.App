using Transport.ly.App.Model;

namespace Transport.ly.App.Data
{
    public interface IFlightDataProvider
    {
        FlightSchedule Load();
    }
}
