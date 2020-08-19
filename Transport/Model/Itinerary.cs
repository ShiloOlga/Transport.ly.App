namespace Transport.ly.App.Model
{
    public class Itinerary
    {
        public Order Order { get; set; }
        public ScheduledFlight Flight { get; set; }

        public bool IsDefined => Flight != null;
    }
}
