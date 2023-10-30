namespace _01.RecursiveArraySum
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = GetSumOfArray(array, 0);
            Console.WriteLine(result);
        }

        private static int GetSumOfArray(int[] array,int index)
        {
            if (index >= array.Length) 
            {
                return 0;
            }

            return array[index] + GetSumOfArray(array, index + 1);
        }
    }
}