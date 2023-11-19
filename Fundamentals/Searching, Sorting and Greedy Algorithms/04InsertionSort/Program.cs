using System;
using System.Linq;

namespace _04InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {

            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            InsertionSort(items);

            Console.WriteLine(string.Join(" ", items));

        }

        private static void InsertionSort(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var j = i;

                while (j > 0 && items[j] < items[j - 1])
                {
                    Swap(items, j, j - 1);
                    j--;
                }
            }
        }

        private static void Swap(int[] items, int firstElement, int secondElement)
        {
            (items[firstElement], items[secondElement]) = (items[secondElement], items[firstElement]);
        }
    }
}