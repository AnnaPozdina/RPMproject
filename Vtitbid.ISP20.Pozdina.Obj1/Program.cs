using Vtitbid.ISP20.Pozdina.Obj1;
using Action = Vtitbid.ISP20.Pozdina.Obj1.Action;

Console.Write("Введите количесвто записей: ");
int n = Convert.ToInt32(Console.ReadLine());
Route[] route = new Route[n];

Action.Main(n, route);
Action.SortRoute(n, route);