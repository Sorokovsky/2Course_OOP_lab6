//Variant 12
namespace Task_1;
public static class Program
{
    public static void Main()
    {
        Fraction fraction1 = new Fraction(4, 2, 3, 1);
        Fraction fraction2 = new Fraction(1, 6, 5, -1);
        Console.WriteLine($"{(double)fraction1} < {(double)fraction2} = {fraction1 < fraction2}");
    }
}
