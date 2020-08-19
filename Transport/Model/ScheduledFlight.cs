using System.Diagnostics.CodeAnalysis;

namespace Transport.ly.App.Model
{
    public class ScheduledFlight
    {
        public int Id { get; private set; }
        public IATA From { get; private set; }
        public IATA To { get; private set; }
        public int Day { get; set; }
        public int CurrectCapacity { get; set; }

        public ScheduledFlight(int day, [NotNull]Flight flight)
        {
            Day = day;
            Id = flight.Id;
            From = flight.From;
            To = flight.To;
        }
    }
}
