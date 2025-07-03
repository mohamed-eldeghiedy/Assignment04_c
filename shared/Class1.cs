namespace shared
{
    public class Class1
    {
       
    }

    public struct person
    {

        public string Name;
        public int Age;


        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void display()
        {
            Console.WriteLine($"Name: {Name}   ,Age: {Age}");
        }
    }

    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
