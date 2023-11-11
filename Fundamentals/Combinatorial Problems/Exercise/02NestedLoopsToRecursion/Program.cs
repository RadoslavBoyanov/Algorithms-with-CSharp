using System;
namespace _02NestedLoopsToRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];

            NestLoop(array, 0);
        }

        private static void NestLoop(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                array[index] = i;
                NestLoop(array, index + 1);
            }
        }
    }
}