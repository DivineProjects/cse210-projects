// Author: Divine Jigu
// W02
// 
// Showing Creativity and Exceeding Requirements
//-----------------------------------------------------------------------------------------------------------------------
// 1. Improve the process of saving: that is check if there is any data to write, if not it doesnt save 
// 2. loading to save such that it checks if file exists, if not it writes and if present, it appends at the end of list
// 3. Gives crush tolerent as it doesnt stop if anything error occurs at any stage


using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] choiceList = {"Write", "Display","Load","Save","Exit"}; 
        List<string> writeList = new List<string>();
        string filename = "questions.txt";
        string saved_location="";
        
        Console.WriteLine("choose");
        int choice= 5;
        string inputQstnResponse="";
        do 
        {
            for (int i=0; i < choiceList.Length; ++i)
            {
                Console.WriteLine($"{i+1}. {choiceList[i]}");
            }

            Console.Write("What Would you Like to do? ");
            string inputChoice = Console.ReadLine();
            choice = int.Parse(inputChoice);
            
            if (choice == 1)
            {
                // Read the questions
                ReadFile question = new ReadFile(filename);
                string questionAsked= question.GetQuestion();
                Console.WriteLine(questionAsked);
                inputQstnResponse = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string writeResponse= $"Date: {dateText} - Prompt: {questionAsked}";
                writeList.Add(writeResponse);
                writeList.Add(inputQstnResponse);
                // Console.WriteLine("Journal Entry Saved");
            }
            else if (choice == 2)
            {
                if (writeList.Count != 0)
                {
                    foreach(string line in writeList)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("Your Journal Entry is Empty, Write or Load your Journal First");
                }
            }
            else if (choice == 3)
            {
                // read the saved file
                
                Console.Write("What is the Journal Name: ");
                filename= Console.ReadLine();
                ReadFile question = new ReadFile(filename);
                question.Display();
            
                
            }
            else if (choice == 4)
            {
                // read the saved file
                if (writeList.Count != 0)
                {
                    SaveFile journalEntry = new SaveFile(writeList);
                    journalEntry.Save();
                    saved_location= journalEntry.SavedFileName();
                    foreach(string line in writeList)
                    {

                    }
                }
                else
                {
                    Console.WriteLine("File Does Not Exist or you have to write first or input an integer");
                }
                
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                choice = -1;
            }

            
            
        } while(choice!= 5);
        
    

    }
}