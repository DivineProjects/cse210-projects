using System;
using System.IO.Enumeration;

public class SaveFile
{
    string input, fileName;
    //string[] txtEntry;
    List<string> txtEntry = new List<string>();
    // Constructor Declaration of Class
    public SaveFile(List<string> txtEntry)//string[] txtEntry)
    {
        this.txtEntry = txtEntry;
    }
    public void Save()
    {
        Console.WriteLine("What is the File Name");
        input= Console.ReadLine();
        fileName = input+".txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            // You can add text to the file with the WriteLine method
            // DateTime theCurrentTime = DateTime.Now;
            // string dateText = theCurrentTime.ToShortDateString();
            // outputFile.WriteLine($"Date: {dateText} - {txtEntry}");
            //Console.WriteLine("Journal Entry Saved");
            if (txtEntry.Count !=0 )
            {
                foreach (string wline in txtEntry)
                    {
                        outputFile.WriteLine($"{wline}");
                    }
                Console.WriteLine("File Success Fully Saved :) ");  
            }
            else
            {
                Console.WriteLine("Cant Write the File");
            }
            
        }
    }

    public string SavedFileName()
    {
        return fileName;
    }
    
    
}