using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Transport.ly.App.Data;
using Transport.ly.App.Model;

namespace Transport.ly.App
{
    public class ItineraryBuilder: IItineraryBuilder
    {
        private readonly IFlightRepository _flightRepository;

        public ItineraryBuilder(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public IReadOnlyList<Itinerary> GenerateItineraries(IReadOnlyList<Order> orders)
        {
            var result = new List<Itinerary>(orders.Count);
            foreach (var order in orders)
            {
                var itinerary = new Itinerary
                {
                    Order = order,
                    Flight = _flightRepository.ScheduleFlightAndBookItem(order.Destination)
                };
                result.Add(itinerary);
            }
            return result;
        }

    }
}
