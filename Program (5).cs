using System;

class Program
{
    static void Main()
    {
        double xStart = 1;
        double xEnd = 7;
        double dx = 0.25;
        double[] aValues = { 0.5, 0.75, 1.0, 1.25 };

        Console.WriteLine("Значення функції y(x) = √(x + a * e^(-x²)) * (a * x²)");

        foreach (double a in aValues)
        {
            Console.WriteLine($"\na = {a}");
            for (double x = xStart; x <= xEnd + 0.0001; x += dx)
            {
                double y = Math.Sqrt(x + a * Math.Exp(-x * x)) * (a * x * x);
                Console.WriteLine($"x = {x:F2}, y = {y:F5}");
            }
        }
    }
}