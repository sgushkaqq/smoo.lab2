using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double term = 1;
        double sum = term;
        int n = 1;

        while (Math.Abs(term) > 1e-6)
        {
            term *= x / n;
            sum += term;
            n++;
        }

        Console.WriteLine($"Наближене значення exp({x}) = {sum:F6}");
        Console.WriteLine($"Перевірка: Math.Exp({x}) = {Math.Exp(x):F6}");
    }
}