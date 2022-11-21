using Vtitbid.ISP20.Pozdina.Obj3;
using Action = Vtitbid.ISP20.Pozdina.Obj3.Action;

Console.Write("Введите количество человек: ");
int n = Convert.ToInt32(Console.ReadLine());//Int.Parse
Zodiac[] zodiac = new Zodiac[n];

Action.Main(n, zodiac);
Action.Sort(zodiac);