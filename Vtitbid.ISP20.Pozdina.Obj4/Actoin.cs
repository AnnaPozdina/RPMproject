namespace Vtitbid.ISP20.Pozdina.Obj4
{
    public class Actoin
    {
        public static Action<string> writer = Console.Write;
        public static Action<string> writer1 = Console.WriteLine;
        public static Func<string> reader = Console.ReadLine;

        public static void PriceCreat(int n, Price[] price)
        {
            for (int i = 0; i < n; i++)
            {
                writer("Введите название товара: ");
                string product = reader();

                writer("Введите название магазина: ");
                string shop = reader();

                writer("Введите стоимость товара (*в рублях): ");
                string cost = reader();

                Console.Clear();

                price[i] = new Price(product, shop, cost);
            }
        }

        public static void SortPrice(int n, Price[] price)
        {
            Price[] priceSort = price.OrderBy(ob => ob.Shop).ToArray();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(priceSort[i]);
            }

            Console.WriteLine();
            writer("Поиск по магазину: ");

            string ser = reader();
            bool flag = false;

            for (int i = 0; i < priceSort.Length; i++)
            {
                if (ser.ToLower() == priceSort[i].Shop.ToLower())
                {
                    Console.WriteLine(priceSort[i]);
                }
                else if (ser.ToLower() != priceSort[i].Shop.ToLower() && i == priceSort.Length - 1 && !flag)
                {
                    writer1("Такого магазина нет в списке");
                }
            }
        }
    }
}