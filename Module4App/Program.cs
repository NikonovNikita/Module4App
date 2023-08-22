using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string name, int age) anketa;
        Console.Write("Введите ваше имя ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите ваш возраст ");
        anketa.age = int.Parse(Console.ReadLine());
        Console.WriteLine("Ваше имя {0}", anketa.name);
        Console.WriteLine("Ваш возраст {0}", anketa.age);
    }
}
