namespace Transport.ly.App.Model
{

    public class Order
    {
        public string Id { get; private set; }
        public IATA Destination { get; private set; }

        public Order(string id, IATA destination)
        {
            Id = id;
            Destination = destination;
        }
    }
}
