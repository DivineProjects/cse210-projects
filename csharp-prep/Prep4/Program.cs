/* Author: Divine Jigu
    Stretch Challenge
    1. Have the user enter both positive and negative numbers, then find the smallest positive number 
    2. Sort the numbers in the list and display the new, sorted list. 
     */

using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            
            // Only add the number 
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        // Part 1:
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // check if this number > max
                max = number;
            }
        }

        Console.WriteLine($"The maximum is: {max}");

        // Stretch Challenge
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                // check if this number > max
                min = number;
            }
        }

        Console.WriteLine($"The minimum is: {min}");

        // soerting
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}