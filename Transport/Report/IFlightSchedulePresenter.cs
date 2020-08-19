using Transport.ly.App.Model;

namespace Transport.ly.App.Report
{
    public interface IFlightSchedulePresenter
    {
        void Print(FlightSchedule schedule);
    }
}
