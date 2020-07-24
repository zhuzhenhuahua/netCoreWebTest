using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] array = { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"i={i},j={j},值为："+ array[i, j]);
                }
            }














            Console.ReadKey();
        }
    }
}
