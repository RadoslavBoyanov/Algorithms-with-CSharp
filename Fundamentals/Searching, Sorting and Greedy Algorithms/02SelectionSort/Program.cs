using System;
using System.Linq;

namespace _02SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            SelectionSort(items);

            Console.WriteLine(string.Join(" ", items));
            
        }

        private static void SelectionSort(int[] items)
        {
            for (int index = 0; index < items.Length; index++)
            {
                var min = index;
                for (int curr = index + 1; curr < items.Length; curr++)
                {
                    if (items[curr] < items[min])
                    {
                        min = curr;
                    }
                }
                Swap(items, index, min);
            }
        }

        private static void Swap(int[] items, int firstElement, int secondElement)
        {
            (items[firstElement], items[secondElement]) = (items[secondElement], items[firstElement]);
        }
    }
}