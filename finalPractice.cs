using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        Console.Write("Enter your age: ");
        var age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine($"Your name is {name} and age is {age}");

        Console.Write("Enter your birthdate: ");
        var birthdate = Console.ReadLine();

        Console.WriteLine($"Your birthdate is {birthdate}");
    }
}