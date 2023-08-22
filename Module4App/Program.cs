using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string LastName, string Login, int LoginLength, 
            bool HasPet, string[] favcolors, double Age) User;

        for (int x = 0; x < 3; x++)
        {

            Console.Write("Введите имя ");
            User.Name = Console.ReadLine();
            Console.Write("Введите вашу фамилию ");
            User.LastName = Console.ReadLine();
            Console.Write("Введите логин ");
            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;

            Console.Write("У вас есть животные? ");
            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }

            Console.Write("Введите возраст ");
            User.Age = double.Parse(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета (цвет + Enter) ");

            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }

    }
}

