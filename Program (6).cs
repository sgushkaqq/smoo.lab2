using System;

class Program
{
    static void Main()
    {
        double[] controlX = { 0.25, -1.0 / 3, 0.5 };
        Console.WriteLine("Обчислення ряду та порівняння з y = ln(1 + 2x)");

        foreach (double x in controlX)
        { double s = 0;
            int n = 1;
            double term;
            do
            { term = (Math.Pow(2, n) * Math.Pow(x, n)) / n;
                s += term;
                n++;
            } while (Math.Abs(term) >= 1e-6);

            double y = Math.Log(1 + 2 * x);
            Console.WriteLine($"\nx = {x:F3}");
            Console.WriteLine($"Ряд S(x) = {s:F6}");
            Console.WriteLine($"y(x) = ln(1 + 2x) = {y:F6}");
        }
    } }