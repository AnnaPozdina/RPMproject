namespace Vtitbid.ISP20.Pozdina.Obj5
{
    public class Bill
    {
        public double PayerAccount { get; set; }
        public double RcipientAccount { get; set; }
        public double AmountTransferred { get; set; }
        public double AmountWithdrawn { get; set; }

        public void MakingPayment(int n, Bill[] person)
        {
            for (int i = 0; i < n; i++)
            {
                person[i] = new Bill();

                Console.Write("Введите расчетный счет плательщика: ");
                person[i].PayerAccount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите расчетный счет получателя: ");
                person[i].RcipientAccount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите перечисляемую сумму: ");
                person[i].AmountTransferred = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
            }
        }
        public void SortMakingPayment(int n, Bill[] person)
        {
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                j++;
                Console.WriteLine($"    Информация о {j} операцие");
                Console.WriteLine(person[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Введите расчетный счет плательщика, чтобы узнать информацию о платеже");

            double Score = Convert.ToDouble(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (Score == person[i].PayerAccount)
                {
                    Console.WriteLine("Снятая сумма с плательщика: " + person[i].AmountTransferred);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Информация о данном платеже отсутствует");
            }
        }

        public override string ToString()
        {
            return $"Расчетный счет плательщика: {PayerAccount}\n" +
                $"Расчетный счет получателя: {RcipientAccount}\n" +
                $"Перечисляемая сумма: {AmountTransferred}\n";
        }
    }
}