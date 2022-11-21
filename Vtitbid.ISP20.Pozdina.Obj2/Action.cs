namespace Vtitbid.ISP20.Pozdina.Obj2
{
    public class Action
    {
        public static Action<string> writer = Console.Write;
        public static Func<string> reader = Console.ReadLine;
        public static void ActionMain(int n, Note[] people)
        {
            for (int i = 0; i < n; i++)
            {
                writer("Введите имя: ");
                string FirstName = reader();

                writer("Введите фамилию: ");
                string LastName = reader();

                writer("Введите номер телефона: ");
                double PhoneNumber = Convert.ToDouble(reader());

                writer("Введите дату рождения: ");
                string[] a = reader().Split(".");
                int[] age = new int[3];

                for (int j = 0; j < a.Length; j++)
                {
                    age[j] = int.Parse(a[j]);
                }

                if (age[1] == 2 && age[0] > 28 || age[2] < 1800)
                {
                    writer("Ошибка формата даты");
                    Console.WriteLine();
                    --i;
                    continue;
                }
                else if (age[0] == 0 && age[1] == 0 && age[2] == 0)
                {
                    writer("Ошибка формата даты");
                    Console.WriteLine();
                    --i;
                    continue;
                }
                else if (age[1] == 2 && age[0] > 28 || age[2] < 1800)
                {
                    writer("Ошибка формата даты");
                    Console.WriteLine();
                    --i;
                    continue;
                }
                else if (age[0] > 31 || age[1] > 12 || age[2] < 1800)
                {
                    writer("Ошибка формата даты");
                    Console.WriteLine();
                    --i;
                    continue;
                }
                else
                {
                    people[i] = new Note(FirstName, LastName, PhoneNumber, age);
                }
                Console.Clear();
            }
        }

        public static void Sort(Note[] people, int n)
        {
            Note[] peoplesSort = people.OrderBy(ob => ob.LastName).ToArray();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(peoplesSort[i]);
            }

            Console.WriteLine();
            writer("Поиск по фамилии: ");

            string ser = reader();
            bool flag = false;

            for (int i = 0; i < peoplesSort.Length; i++)
            {
                if (ser.ToLower() == peoplesSort[i].LastName.ToLower())
                {
                    Console.WriteLine(peoplesSort[i]);
                    flag = true;
                }
                else if (ser.ToLower() != peoplesSort[i].LastName.ToLower() && i == peoplesSort.Length - 1 && !flag)
                {
                    writer("Ошибка: такой фамилии не найдено!");
                }
            }
        }
    }
}