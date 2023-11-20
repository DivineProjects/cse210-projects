public class Reference
{
    private string _book;   // All of my attributes are private – they can only be used in this class
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _book= "1 Nephi";
        _chapter= 1;
        _verse= 1;
        _endVerse= 2;
    }
    public Reference(string book, int chapter, int verse)
    {
        // First constructor – Need to set all the attributes to an initial value using the parameters in this function
        _book= book;
        _chapter= chapter;
        _verse= verse;

        // You are not given the endVerse, so you have to initialize it something
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        // Second constructor – Need to set all the attributes to an initial value using the parameters in this function
        _book= book;
        _chapter= chapter;
        _verse= verse;
        _endVerse= endVerse;
    }
    public string GetDisplayText()
    {
        // Create a string that has the book, chapter, verse, and endVerse (if its used)
        // In stub code, if the function is supposed to return something, then we make something up for now
        return $"{_book} {_chapter}:{_verse}";
    }
}