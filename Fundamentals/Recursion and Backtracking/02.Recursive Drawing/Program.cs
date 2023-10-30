using System;
namespace _02.Recursive_Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            RecursiveDrawing(number);
        }

        private static void RecursiveDrawing(int number)
        {
            if (number <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', number));
            RecursiveDrawing(number - 1);
            Console.WriteLine(new string('#', number));
        }
    }
}