using System;
namespace _06CombinationsWithRepetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] combinations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();

            int k = int.Parse(Console.ReadLine());

            combinations = new string[k];

            Combination(0, 0);
        }

        private static void Combination(int index, int startIndex)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = startIndex; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                Combination(index + 1, i);
            }
        }
    }
}