// Divine Jigu
// Stretch Challenge added

using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        string letter, sign;
        Console.WriteLine();
        Console.WriteLine("Welcome to Letter Grade Application");
        Console.Write("Input Your Mark ");
        string input= Console.ReadLine();
        int mark= int.Parse(input);
        if (mark >= 90)
        {
            letter ="A";
        }
        else if (mark >= 80)
        {
            letter ="B";
        }
        else if (mark >= 70)
        {
            letter ="C";
        }
        else if (mark >= 60)
        {
            letter ="D";
        }
        else if (mark < 60)
        {
            letter ="F";
        }
        else
        {
            letter ="Enter Grade Made between 0 and 100";
        }

        // Stretch Challenge
        int remainder = mark % 10;
        
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder< 3)
        {
            sign = "-";
        }
        else{
            sign = "";
        }


        // Task 3
        Console.WriteLine($"{mark} is Grade: {letter}{sign}");

        // task 2
        if (mark >= 70)
        {
            Console.WriteLine("Congradulations!!! :) You have Passed");
        }
        else
        {
            Console.WriteLine("Sorry, Try Again Next Time");
        }

        

    }
}