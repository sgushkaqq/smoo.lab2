using System;
class Program
{ static Random rnd = new Random();
    static int userScore = 0;
    static int compScore = 0;

    static void Main()
    { Console.WriteLine("=== Гра: Вгадай число ===");
        bool win = PlayLevel(1, 1, 10, 3, 0.5, 5);
        if (win)
        {
            Console.Write("\nПерейти до другого рівня? (так/ні): ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "так")
            {
                PlayLevel(2, 10, 100, 2, 0.25, 10);
            }
        }
        Console.WriteLine($"\nКІНЕЦЬ ГРИ\nОчки гравця: {userScore}");
        Console.WriteLine($"Очки комп'ютера: {compScore}");
    }

    static bool PlayLevel(int level, int min, int max, int rounds, double lifeFraction, int scoreMultiplier)
    {
        Console.WriteLine($"\n=== РІВЕНЬ {level}: Від {min} до {max} ===");
        bool passed = true;

        for (int round = 1; round <= rounds; round++)
        { int range = max - min + 1;
            int lives = (int)Math.Round(range * lifeFraction);
            int startLives = lives;
            int number = rnd.Next(min, max + 1);
            Console.WriteLine($"\n--- Раунд {round}: Вгадай число ---");
            bool guessed = false;
            while (lives > 0)
            {
                Console.Write($"Залишилось життів: {lives}. Введи число: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                { Console.WriteLine(" Правильно!");
                    guessed = true;
                    break;
                }
                else
                {
                    lives--;
                    Console.WriteLine(" Неправильно.");
                    Console.Write("Підказка? (так/ні): ");
                    string hint = Console.ReadLine();
                    if (hint.ToLower() == "так" && lives > 0)
                    {
                        lives--;
                        if (guess < number)
                            Console.WriteLine("Підказка: загаданe число більше.");
                        else
                            Console.WriteLine("Підказка: загаданe число менше.");
                    }
                } }

            if (guessed)
            {
                int points = lives * scoreMultiplier;
                userScore += points;
                Console.WriteLine($"Раунд виграно! Отримано очок: {points}"); }
            else
            {
                int points = startLives * scoreMultiplier;
                compScore += points;
                Console.WriteLine($"Раунд програно. Комп’ютер отримав {points} очок.");
                passed = false; }
        }
        Console.WriteLine($"\nПІДСУМКИ РІВНЯ {level}");
        Console.WriteLine($"Очки гравця: {userScore}, комп'ютера: {compScore}");
        return passed; } }