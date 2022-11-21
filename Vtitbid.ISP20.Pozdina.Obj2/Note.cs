namespace Vtitbid.ISP20.Pozdina.Obj2
{
    public class Note
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double PhoneNumber { get; set; }
        public int[] Age = new int[3];

        public Note(string firstName, string lastName, double phoneNumber, int[] age)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Age = age;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}, " +
                $"Фамилия: {LastName}, " +
                $"Номер: {PhoneNumber}, " +
                $"Дата рождения: {Age[0]}-{Age[1]}-{Age[2]}";
        }
    }
}