using System;
using System.Collections.Generic;
using Transport.ly.App.Model;

namespace Transport.ly.App.Report
{
    public interface IItineraryPresenter
    {
        void Print(IReadOnlyList<Itinerary> itineraries);
    }
}
