
using shared;
using System;
namespace Assignment04_c
{
    internal class Program
    {
        static void Main()
        {

            #region p1:Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the Week: ");
            //foreach (WeekDays day in Enum.GetValues(typeof(shared.WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion


            #region p2:Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //person[] people = new person[3];


            //people[0] = new person("muhammed", 23);
            //people[1] = new person("mostafa", 20);
            //people[2] = new person("sayed", 22);


            //Console.WriteLine("List of Persons:");
            //foreach (person p in people)
            //{
            //    p.display();
            //}
            #endregion


            #region p3:Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine()!;


            //if (Enum.TryParse(input, true, out Season season))
            //{

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Enter a valid season.");
            //}
            #endregion


            #region p4: Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color (Red, Green, Blue):");
            //string input = Console.ReadLine()!;


            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    if (Enum.IsDefined(typeof(Colors), color))
            //    {
            //        Console.WriteLine($"{color} is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{color} is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Enter a valid color.");
            //}


            #endregion


            #region p5:Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //{

            //    Console.WriteLine("Enter of the first point (X Y):");
            //    string[] point1Input = Console.ReadLine()!.Split();
            //    double x1 = Convert.ToDouble(point1Input[0]);
            //    double y1 = Convert.ToDouble(point1Input[1]);


            //    Point point1 = new Point(x1, y1);


            //    Console.WriteLine("Enter of the second point (X Y):");
            //    string[] point2Input = Console.ReadLine()!.Split();
            //    double x2 = Convert.ToDouble(point2Input[0]);
            //    double y2 = Convert.ToDouble(point2Input[1]);

            //    Point point2 = new Point(x2, y2);


            //    double distance = point1.Distance(point2);


            //    Console.WriteLine($"The distance between the two points is: {distance}");


            #endregion


            #region p6: Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine()!;
            //    Console.Write("Age: ");
            //    int age;
            //    while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            //    {
            //        Console.Write(" Please enter a valid age: ");
            //    }

            //    persons[i] = new Person(name, age);

            //}

            //Person oldest_person = persons[0];

            //for (int j = 1; j < persons.Length; j++)
            //{
            //    if (persons[j].Age > oldest_person.Age)
            //    {
            //        oldest_person = persons[j];
            //    }
            //}

            //Console.WriteLine("\n The oldest person is:");
            //Console.WriteLine($"Name: {oldest_person.Name}, Age: {oldest_person.Age}");
            #endregion

        }
    }
}
