using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;

        Console.Write("Введите имя питомца ");
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;

        Console.Write("Введите вид питомца ");
        Pet.Type = Console.ReadLine();

        Console.Write("Введите возраст питомца ");
        Pet.Age = double.Parse(Console.ReadLine());

        Console.WriteLine("Имя вашего питомца {0}", Pet.Name);
        Console.WriteLine("Вид вашего питомца {0}", Pet.Type);
        Console.WriteLine("Возраст вашего питомца {0}", Pet.Age);
        Console.WriteLine("Длина имени вашего питомца {0}", Pet.NameCount);
    }
}
