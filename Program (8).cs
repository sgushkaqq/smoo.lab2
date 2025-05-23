using System;

class Program
{
    static void Main()
    {
        double[] alphas = { 0.5, 1.0, 1.5, 2.0 };

        foreach (double alpha in alphas)
        {
            Console.WriteLine($"\nАльфа = {alpha}");
            Console.WriteLine("X\tY");

            for (double x = 1; x <= 7; x += 0.25)
            {
                double y = alpha * Math.Sin(x);
                Console.WriteLine($"{x:F2}\t{y:F4}");
            }
        }
    }
}