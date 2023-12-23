using Microsoft.VisualBasic;

namespace _05Quicksort
{
    public class Program
    {
        static void Main(string[] args)
        {

            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            QuickSort(items, 0, items.Length - 1);

            Console.WriteLine(string.Join(" ", items));

        }

        private static void QuickSort(int[] items, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            var pivot = startIndex;
            var leftIndex = startIndex + 1;
            var rightIndex = endIndex;

            while (leftIndex <= rightIndex)
            {
                if (items[leftIndex] > items[pivot] && items[rightIndex] < items[pivot])
                {
                    Swap(items, leftIndex, rightIndex);
                }

                if (items[leftIndex] <= items[pivot])
                {
                    leftIndex +=1;
                }

                if (items[rightIndex] >= items[pivot])
                {
                    rightIndex -=1;
                }

                Swap(items, pivot, rightIndex);

                var isLeftSubAraySmaller = rightIndex - 1 - startIndex < endIndex - (rightIndex + 1);

                if (isLeftSubAraySmaller)
                {
                    QuickSort(items, startIndex, rightIndex - 1);
                    QuickSort(items, rightIndex + 1, endIndex);
                }
                else
                {
                    QuickSort(items, rightIndex + 1, endIndex);
                    QuickSort(items, startIndex, rightIndex - 1);
                }
            }
        }

        private static void Swap(int[] items, int firstElement, int secondElement)
        {
            (items[firstElement], items[secondElement]) = (items[secondElement], items[firstElement]);
        }
    }
}
