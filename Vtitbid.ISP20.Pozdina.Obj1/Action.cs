namespace Vtitbid.ISP20.Pozdina.Obj1
{
    public class Action
    {
        public static Action<string> writer = Console.Write;
        public static Func<string> reader = Console.ReadLine;
        public static void Main(int n, Route[] route)
        {
            for (int i = 0; i < n; i++)
            {
                writer("Введите название начального пункта маршрута: ");
                string startingPoint = reader();

                writer("Введите название конечного пунтка маршрута: ");
                string destination = reader();

                writer("Введите номер маршрута: ");
                string nomer = reader();

                Console.WriteLine();
                Console.Clear();

                route[i] = new Route(startingPoint, destination, nomer);
            }
        }

        public static void SortRoute(int n, Route[] route)
        {
            Route[] routeSort = route.OrderBy(ob => ob.Nomer).ToArray();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(routeSort[i]);
            }

            Console.WriteLine();
            writer("Поиск по номеру маршрута: ");

            string ser = reader();
            bool flag = false;

            for (int i = 0; i < routeSort.Length; i++)
            {
                if (ser.ToLower() == routeSort[i].Nomer.ToLower())
                {
                    Console.WriteLine(routeSort[i]);
                }
                else if (ser.ToLower() != routeSort[i].Destination.ToLower() && i == routeSort.Length - 1 && !flag)
                {
                    writer("Номера такого маршрута нет!");
                }
            }
        }
    }
}