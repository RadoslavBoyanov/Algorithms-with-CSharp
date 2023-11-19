using System;
using System.Linq;

namespace _03BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {

            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            BubbleSort(items);

            Console.WriteLine(string.Join(" ", items));

        }

        private static void BubbleSort(int[] items)
        {
            var isSorted = false;
            var i = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int j = 1; j < items.Length - i; j++)
                {
                    if (items[j - 1] > items[j])
                    {
                        isSorted = false;
                        Swap(items, j - 1, j);
                    }
                }
                i += 1;
            }
        }

        private static void Swap(int[] items, int firstElement, int secondElement)
        {
            (items[firstElement], items[secondElement]) = (items[secondElement], items[firstElement]);
        }
    }
}