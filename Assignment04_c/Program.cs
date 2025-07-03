
using shared;
namespace Assignment04_c
{
    internal class Program
    {
        static void Main()
        {


            Console.WriteLine("Days of the Week: ");
            foreach (WeekDays day in Enum.GetValues(typeof(shared.WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
    }
}
