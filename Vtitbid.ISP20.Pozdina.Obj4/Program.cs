using Vtitbid.ISP20.Pozdina.Obj4;
using Action = Vtitbid.ISP20.Pozdina.Obj4.Actoin;

Console.Write("Введите количество записей: ");
int n = Convert.ToInt32(Console.ReadLine());
Price[] price = new Price[n];

Action.PriceCreat(n, price);
Actoin.SortPrice(n, price);