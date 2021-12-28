using System;

class MainClass
{
    enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        Console.Write("Enter your age: ");
        var age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine($"Your name is {name} and age is {age}");

        Console.Write("What is your favorite day of week? ");
        var dayOfWeek = (DayOfWeek)int.Parse(Console.ReadLine());

        Console.WriteLine($"Your favorite day is {dayOfWeek}");
    }
}