using System;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        string first_name;
        string last_name;
        Console.WriteLine("");
        Console.Write("What is your first name? ");
        first_name= Console.ReadLine();
        Console.Write("What is your last name? ");
        last_name= Console.ReadLine();

        Console.WriteLine($"Your name is {first_name}, {last_name} {first_name}.");
    }
}