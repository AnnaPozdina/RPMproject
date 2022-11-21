using System.Text.RegularExpressions;

namespace Vtitbid.ISP20.Pozdina.Obj3
{
    public class Action
    {

        public static Action<string> writer = Console.Write;
        public static Action<string> writer1 = Console.Write;
        public static Func<string> reader = Console.ReadLine;

        public static void Main(int n, Zodiac[] zodiac)
        {
            for (int i = 0; i < n; i++)
            {
                writer1($"****{i + 1}****");
                Console.WriteLine();

                writer("Имя: ");
                string firstName = reader();

                writer("Фамилия: ");
                string lastName = reader();

                writer("Дата рождения: ");
                string[] a = reader().Split(".");
                int[] age = new int[3];

                Regex r = new Regex(@"\d[1-9]{3}-\d[1-9]{3}-\d[1-9]{4}");

                for (int j = 0; j < a.Length; j++)
                {
                    age[j] = int.Parse(a[j]);
                }

                if (age[1] == 2 && age[0] > 28 || age[2] < 1800)
                {
                    writer1("Ошибка формата даты");
                    --i;
                    continue;
                }
                else if (age[0] == 0 && age[1] == 0 && age[2] == 0)
                {
                    writer1("Ошибка формата даты");
                    Console.WriteLine();
                    --i;
                    continue;
                }
                else if (age[1] == 2 && age[0] > 28 || age[2] < 1800)
                {
                    writer1("Ошибка формата даты");
                    Console.WriteLine();
                    --i;
                    continue;
                }
                else if (age[0] > 31 || age[1] > 12 || age[2] < 1800)
                {
                    writer("Ошибка формата даты");
                    --i;
                    continue;
                }
                else
                {
                    string Sing = null;
                    zodiac[i] = new Zodiac(lastName, firstName, age, Sing);
                }
                Console.Clear();
            }
        }

        public static void Sort(Zodiac[] zodiac)
        {
            Zodiac[] zodiacSort = zodiac.OrderBy(ob => ob.Sing).ToArray();

            for (int i = 0; i < zodiacSort.Length; i++)
            {
                Console.WriteLine(zodiacSort[i]);
            }

            Console.WriteLine();
            writer("Поиск по знаку зодиака: ");

            string ser = reader();
            bool flag = false;

            for (int i = 0; i < zodiac.Length; i++)
            {
                if (ser.ToLower() == zodiac[i].Sing.ToLower())
                {
                    Console.WriteLine(zodiac[i]);
                    flag = true;
                }
                else if (ser.ToLower() != zodiac[i].Sing.ToLower() && i == zodiac.Length - 1 && !flag)
                {
                    writer1("Ошибка: такого знака зодиака не существует!");
                }
            }
        }
    }
}