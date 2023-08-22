using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, -9, 3, 5, -7, 0, -1, 2 };

        var numbers = 0;

        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0)
            {
                numbers++;
            }
        }
        Console.WriteLine(numbers);






    }
}
