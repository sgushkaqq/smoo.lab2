using System;

class Program
{
 static void Main()
    {
        int sum = 0;
        int product = 1;

        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            product *= i;
        }

        Console.WriteLine("Сума: " + sum);
        Console.WriteLine("Добуток: " + product);
    }
}