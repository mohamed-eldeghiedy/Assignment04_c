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
            Console.WriteLine($"Name: {Name}   ,\n Age: {Age}");
        }
    }

    public struct Point
    {
        public double X;
        public double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double  Distance(Point other)
        {
            double deltaX = X - other.X;
            double deltaY = Y - other.Y;

            return (int)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public struct Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
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


    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    public enum Colors
    {
        Red,
        Green,
        Blue,
        
    }
}
