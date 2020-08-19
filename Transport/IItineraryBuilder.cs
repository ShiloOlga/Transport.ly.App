using System;
using System.Collections.Generic;
using Transport.ly.App.Model;

namespace Transport.ly.App
{
    public interface IItineraryBuilder
    {
        IReadOnlyList<Itinerary> GenerateItineraries(IReadOnlyList<Order> orders);
    }
}
