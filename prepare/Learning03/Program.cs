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
    }
}