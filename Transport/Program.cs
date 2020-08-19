using System;
using System.IO;
using Transport.ly.App.Data;
using Transport.ly.App.Report;

namespace Transport.ly.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            IFlightDataProvider flightDataProvider = new FlightMockDataProvider();
            var schedule = flightDataProvider.Load();

            IFlightRepository repository = new FlightRepository();
            repository.Initialize(schedule);

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "coding-assigment-orders.json");
            IOrderDataProvider orderDataProvider = new OrderFileDataProvider(filePath);
            var orders = orderDataProvider.Load();

            IItineraryBuilder manager = new ItineraryBuilder(repository);
            var itineraries = manager.GenerateItineraries(orders);

            IFlightSchedulePresenter schedulePresenter = new FlightScheduleConsolePresenter();
            schedulePresenter.Print(schedule);
            IItineraryPresenter itineraryPresenter = new ItineraryConsolePresenter();
            itineraryPresenter.Print(itineraries);

            Console.ReadKey();
        }
    }

    
}
