namespace _05Quicksort
{
    public class Program
    {
        static void Main(string[] args)
        {

            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            QuickSort(items);

            Console.WriteLine(string.Join(" ", items));

        }

        private static void QuickSort(int[] items)
        {
            
        }

        private static void Swap(int[] items, int firstElement, int secondElement)
        {
            (items[firstElement], items[secondElement]) = (items[secondElement], items[firstElement]);
        }
    }
}