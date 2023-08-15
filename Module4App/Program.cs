using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Цикл While:");
        int k = 0;
        while (k < 3)
        {
            Console.WriteLine(k);
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var text = Console.ReadLine();
            if (text == "stop")
            {
                Console.WriteLine("Цикл остановлен");
                break;
            }
            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");

                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");

                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");

                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is Yellow now!");

                    break;

            }
            k++;
        }
        Console.WriteLine("Цикл Do While:");
        int t = 0;
        do
        {
            Console.WriteLine(t);
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var text = Console.ReadLine();
            if (text == "stop")
            {
                Console.WriteLine("Цикл остановлен");
                break;
            }
            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");

                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");

                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");

                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is Yellow now!");

                    break;

            }
            t++;
        }
        while (t < 3);
    }
}
