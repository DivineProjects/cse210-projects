
using System;
class Program
{
    static void Main(string[] args)
    {
        
        string verses = "He will bestow countless privilege blessings, and miracles upon the faithful";
        List<Scripture> scriptures = new List<Scripture>();
        
        Random random = new Random();
        // string verses = "";
        // scriptures = [["He will bestow countless privileges,"],[" blessings, and miracles upon the faithful"]];
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        int numberOfHiddenWors = 2;

        
        Console.Clear();
        Console.WriteLine(scripture.ScriptureDisplay());
        Console.WriteLine("Press Any Key to begin, or 'quit' to exit:");
        string input = Console.ReadLine();

     
        while (!scripture.AllWordsHidden() && !input.Equals("quit")) 
        {
            scripture.HideRandomWords(numberOfHiddenWors);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("Press Enter to continue, or type 'quit' to exit:");
                input = Console.ReadLine();;
            }
        }
    }



    
}