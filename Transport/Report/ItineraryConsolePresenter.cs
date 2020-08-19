using System;
using System.Collections.Generic;
using Transport.ly.App.Model;

namespace Transport.ly.App.Report
{
    public class ItineraryConsolePresenter: IItineraryPresenter
    {
        public void Print(IReadOnlyList<Itinerary> itineraries)
        {
            foreach (var item in itineraries)
            {
                string line;
                if (item.IsDefined)
                {
                    line = $"Order: {item.Order.Id}, flightNumber: {item.Flight.Id}, " +
                        $"departure: {item.Flight.From}, arrival: {item.Flight.To}, day: {item.Flight.Day}";
                }
                else
                {
                    line = $"Order: {item.Order.Id}, flightNumber: not scheduled";
                }
                Console.WriteLine(line);
            }
        }
    }
}
