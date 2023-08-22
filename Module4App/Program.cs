using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int [][] array = new int [3][];
        array[0] = new int[3] {1, 2, 3 };
        array[1] = new int[5] {1, 2, 3, 4, 5};
        array[2] = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

        foreach (var num in array)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }


        



    }
}
