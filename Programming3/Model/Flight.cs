namespace Programming3
{
    public class Flight
    {
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public int FlightTimeInMinutes { get; set; }

        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public Flight()
        {
            DeparturePoint = "Москва";
            DestinationPoint = "Санкт-Петербург";
            FlightTimeInMinutes = 60;
        }
    }
}