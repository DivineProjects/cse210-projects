// creativity and exceeds core requirements
// reads files

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
class Program
{
    static void Main(string[] args)
    {
        

        string fileLocation = "prove/Develop03/scripturez.json";
        List<Scripture> scriptures = new List<Scripture>();
        Random random = new Random();

        // load jason file
        try
        {
            using (StreamReader reader = new StreamReader(fileLocation))
            {
                string json = reader.ReadToEnd();
                scriptures = JsonSerializer.Deserialize<List<Scripture>>(json);

            }
            Console.WriteLine($"Welcome to Scripture  Memorise");
        }
        catch
        {
            Console.WriteLine($"failed to load");
        }

        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        int numberOfHiddenWords = 2;

        
        Console.Clear();
        Console.WriteLine(scripture.ScriptureDisplay());
        Console.WriteLine("Press Any Key to begin, or 'quit' to exit:");
        string input = Console.ReadLine();

     
        while (!scripture.AllWordsHidden() && !input.Equals("quit")) 
        {
            scripture.HideRandomWords(numberOfHiddenWords);
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