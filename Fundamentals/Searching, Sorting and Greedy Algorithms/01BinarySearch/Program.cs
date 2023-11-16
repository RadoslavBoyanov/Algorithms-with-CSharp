using System;
using System.Linq;

namespace _01BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var searchedItem = int.Parse(Console.ReadLine());

            var result = BinarySearch(items, searchedItem);

            Console.WriteLine(result);
        }

        private static int BinarySearch(int[] items, int searchedItem)
        {
            int left = 0;
            int right = items.Length - 1;

            while (left <= right)
            {
                int mid = (right + left) / 2;
                var element = items[mid];

                if (element == searchedItem)
                {
                    return mid;
                }

                if (searchedItem > element)
                {
                    left = mid + 1;
                }

                if (searchedItem < element)
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}