using System;
namespace _03._Generating_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var array = new int[number];

            Generating01Vectors(array, 0);
        }

        private static void Generating01Vectors(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join("", array));
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                array[index] = i;

                Generating01Vectors(array, index + 1);
            }
        }
    }
}