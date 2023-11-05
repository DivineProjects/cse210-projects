// Divine Jigu
// Stretch Challenge added

using System;

class Program
{
    static void Main(string[] args)
    {
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess_number = -1;
        int guesses = 1;
        string yes_no = "yes";

        do
        {
            while (guess_number != magicNumber)
            {
                Console.Write("Guess a Number? ");
                guess_number = int.Parse(Console.ReadLine());

                if (magicNumber > guess_number)
                {
                    Console.WriteLine("Guess Higher");
                    guesses++;
                }
                else if (magicNumber < guess_number)
                {
                    Console.WriteLine("Guess Lower");
                    guesses++;
                }
                else
                {
                    Console.WriteLine("Awesome !!! You got it!");
                }
                
            }
        
            Console.WriteLine($"Number of guesses: {guesses}");
            guesses = 1;
            guess_number = -1;
            Console.Write("Do you want to Play again (yes / no): ");
            yes_no = Console.ReadLine();
        } while (yes_no =="yes" || yes_no =="Yes" || yes_no =="YES");


    }
}