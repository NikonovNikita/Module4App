using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите свое имя ");
        string name = Console.ReadLine();
        Console.Write("Буквы вашего имени в обратном порядке: ");
        for (int i = name.Length - 1; i >= 0; i --)
        {
            Console.Write(name[i] + " ");
        }

        
    }
}
