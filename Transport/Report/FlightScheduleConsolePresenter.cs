using System;
using Transport.ly.App.Model;

namespace Transport.ly.App.Report
{
    public class FlightScheduleConsolePresenter: IFlightSchedulePresenter
    {
        public void Print(FlightSchedule schedule)
        {
            foreach (var day in schedule.Flights.Keys)
            {
                foreach (var flight in schedule.Flights[day])
                {
                    Console.WriteLine($"{flight}, day: {day}");
                }
            }
        }
    }
}
