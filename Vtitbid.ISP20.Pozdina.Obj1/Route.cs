namespace Vtitbid.ISP20.Pozdina.Obj1
{
    public class Route
    {
        public string StartingPoint { get; set; }
        public string Destination { get; set; }
        public string Nomer { get; set; }

        public Route(string startingPoint, string destination, string nomer)
        {
            StartingPoint = startingPoint;
            Destination = destination;
            Nomer = nomer;
        }
        public override string ToString()
        {
            return $"Начало маршрута: {StartingPoint}," +
                $" Конец маршрута: {Destination}," +
                $" Номер маршрута: {Nomer}";
        }
    }
}