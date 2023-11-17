using System;

public class Fraction
{
    // attributes
    private int _top;
    private int _bottom;

    // Constructior
    public Fraction()
    {
        _bottom = 1;
        _top =1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    // initiate get methods
    public int GetTop()
    {
        return _top;
    }
     public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string getString = $"{_top}/{_bottom}"; 
        return getString;
    }

    public double GetDecimalValue()
    {
        
        return (double)_top / (double)_bottom;
    }
}