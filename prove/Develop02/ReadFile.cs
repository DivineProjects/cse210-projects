using System;
using System.IO.Enumeration;

public class ReadFile
{
    string filename;
    Random randInt= new Random();

    // Constructor Declaration of Class
    public ReadFile(string filename)
    {
        this.filename= filename + ".txt";
    }

    public void Display()
    {
        try{
            string[] lines = System.IO.File.ReadAllLines(filename);
            // Console.WriteLine(lines[randInt.Next(0,lines.Length)]);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch(Exception)
            {
                Console.WriteLine("File Does not Exist");
            }
    }

    public string GetQuestion()
    {
 
        try
        {
            filename= "questions.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
           
            return lines[randInt.Next(0,lines.Length)];
        }
        catch(Exception)
        {
            // Console.Write("No question Available");
            return "No question Available";
        }
    }
    
    
}