using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract = new Fraction();
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue());

        Fraction fract2 = new Fraction(5);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());

        ///////////////////////////
        //////////////////////////
        ///
        List<string> words = new List<string>();
        List<string> newWords = new List<string>();
        foreach (var word in words)
        {
            newWords.Add(word);
        }
        
        string disp= "";
        //int idx=1;
        Console.WriteLine("===========================");
        newWords[1] = "_______";
        Console.WriteLine($"new word = {newWords[1]}");
        Console.WriteLine($"old word = {words[1]}");
        
        bool isPresent= newWords.Contains(words[1]);
        Console.WriteLine($"{newWords[1]} == {words[1]} is {isPresent}" );

        Console.WriteLine("-===================================");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    

        List<string> AuthorList = new List<string>();  
        AuthorList.Add("Mahesh Chand");  
        AuthorList.Add("Praveen Kumar");  
        AuthorList.Add("Raj Kumar");  
        AuthorList.Add("Nipun Tomar");  
        AuthorList.Add("Mahesh Chand");  
        AuthorList.Add("Dinesh Beniwal");  

        // Contains - Check if an item is in the list    
        if (AuthorList.Contains("Mahesh Chand"))  
        {  
            Console.WriteLine("Author found!");  
        }  

        // Find an item and replace it with new item  
        int idx = AuthorList.IndexOf("Nipun Tomar");  
        if (idx >= 0)  
        {  
            AuthorList[idx] = "-----";  
        }  
        Console.WriteLine("\nIndexOf "); 
        foreach (var author in AuthorList)  
        {  
            Console.WriteLine(author);  
        }  


        Console.WriteLine("quit or play");
        //decision = Console.ReadLine();
    }
}