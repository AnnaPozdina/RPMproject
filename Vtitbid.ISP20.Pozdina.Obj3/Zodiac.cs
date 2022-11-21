namespace Vtitbid.ISP20.Pozdina.Obj3
{
    public class Zodiac
    {
        public string LastName;
        public string FirstName;
        public string Sing;
        public int[] Age = new int[3];

        public Zodiac(string lastName, string firstName, int[] age, string sing)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;

            switch (age[1])
            {
                case 1:
                    if (age[0] <= 20)
                    {
                        Sing = "Козерог";
                    }
                    else if (age[0] >= 21)
                    {
                        Sing = "Водолей";
                    }
                    break;
                case 2:
                    if (age[0] >= 19)
                    {
                        Sing = "Рыбы";
                    }
                    else if (age[0] <= 18)
                    {
                        Sing = "Водолей";
                    }
                    break;
                case 3:
                    if (age[0] >= 21)
                    {
                        Sing = "Овен";
                    }
                    else if (age[0] <= 20)
                    {
                        Sing = "Рыбы";
                    }
                    break;
                case 4:
                    if (age[0] >= 20)
                    {
                        Sing = "Телец";
                    }
                    else if (age[0] <= 19)
                    {
                        Sing = "Овен";
                    }
                    break;
                case 5:
                    if (age[0] >= 21)
                    {
                        Sing = "Близнецы";
                    }
                    else if (age[0] <= 22)
                    {
                        Sing = "Телец";
                    }
                    break;
                case 6:
                    if (age[0] >= 22)
                    {
                        Sing = "Рак";
                    }
                    else if (age[0] <= 21)
                    {
                        Sing = "Близнецы";
                    }
                    break;
                case 7:
                    if (age[0] >= 23)
                    {
                        Sing = "Лев";
                    }
                    else if (age[0] <= 22)
                    {
                        Sing = "Рак";
                    }
                    break;
                case 8:
                    if (age[0] >= 23)
                    {
                        Sing = "Дева";
                    }
                    else if (age[0] <= 22)
                    {
                        Sing = "Лев";
                    }
                    break;
                case 9:
                    if (age[0] >= 23)
                    {
                        Sing = "Весы";
                    }
                    else if (age[0] <= 22)
                    {
                        Sing = "Дева";
                    }
                    break;
                case 10:
                    if (age[0] >= 24)
                    {
                        Sing = "Скорпион";
                    }
                    else if (age[0] <= 23)
                    {
                        Sing = "Весы";
                    }
                    break;
                case 11:
                    if (age[0] >= 23)
                    {
                        Sing = "Стрелец";
                    }
                    else if (age[0] <= 22)
                    {
                        Sing = "Скорпион";
                    }
                    break;
                case 12:
                    if (age[0] >= 22)
                    {
                        Sing = "Козерог";
                    }
                    else if (age[0] <= 21)
                    {
                        Sing = "Стрелец";
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}," +
                $" Фамилия: {LastName}," +
                $" Знак зодиака: {Sing}," +
                $" Дата рождения: {Age[0]}-{Age[1]}-{Age[2]}";
        }
    }
}