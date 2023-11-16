namespace _00.LinearSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var searchedItem = int.Parse(Console.ReadLine());

            var result = LinearSearch(items, searchedItem);

            Console.WriteLine(result);
        }

        private static bool LinearSearch(int[] items, int item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (item == items[i])
                {
                    return true;
                }
            }

            return false;   
        }
    }
}