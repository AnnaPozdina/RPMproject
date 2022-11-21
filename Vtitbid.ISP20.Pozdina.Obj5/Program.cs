using Vtitbid.ISP20.Pozdina.Obj5;

Console.WriteLine("Введите количество записей: ");
int n = Convert.ToInt32(Console.ReadLine());

Bill[] bills = new Bill[n];
Bill bill = new Bill();

bill.MakingPayment(n, bills);
bill.SortMakingPayment(n, bills);