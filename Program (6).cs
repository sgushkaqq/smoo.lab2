using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть ціле число a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть ціле число b:");
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = 0, count = 0;

        for (int i = a; i <= b; i++)
        {
            sum += i;
            count++;
        }

        Console.WriteLine("Сума: " + sum);
        Console.WriteLine("Кількість: " + count);
    }
}