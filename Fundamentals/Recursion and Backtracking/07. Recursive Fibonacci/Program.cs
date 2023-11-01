using System;
using System.Collections.Generic;
namespace _07._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);

            while (fibonacci.Count < n + 2)
            {
                var newFibonacci = fibonacci[^1] + fibonacci[^2];
                fibonacci.Add(newFibonacci);
            }

            Console.WriteLine(fibonacci[^1]);
        }

        private static int GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }


    }
}