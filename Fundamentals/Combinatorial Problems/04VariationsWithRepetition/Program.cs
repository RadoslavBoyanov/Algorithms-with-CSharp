using System;
namespace _04VariationsWithRepetition
{
    public class Program
    {
        private static string[] elements;
        private static int k;
        private static string[] variations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();

            k = int.Parse(Console.ReadLine());

            variations = new string[k];

            Variation(0);
        }

        private static void Variation(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                variations[index] = elements[i];
                Variation(index + 1);
            }
        }
    }
}