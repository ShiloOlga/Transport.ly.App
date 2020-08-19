namespace Transport.ly.App.Model
{
    public class Flight
    {
        public int Id { get; private set; }
        public IATA From { get; private set; }
        public IATA To { get; private set; }

        private Flight() { }

        public Flight(int id, IATA from, IATA to)
        {
            Id = id;
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return $"Flight: {Id}, departure: {From}, arrival: {To}";
        }
    }
}
