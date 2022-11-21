using Vtitbid.ISP20.Pozdina.Obj2;
using Action = Vtitbid.ISP20.Pozdina.Obj2.Action;

Console.Write("Введите количество записей: ");
int n = Convert.ToInt32(Console.ReadLine());
Note[] people = new Note[n];

Action.ActionMain(n, people);
Action.Sort(people, n);