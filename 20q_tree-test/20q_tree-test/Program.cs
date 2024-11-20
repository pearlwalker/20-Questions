using System;

namespace _20q_tree_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //expected: 1
            Console.WriteLine("0! with Recursion: " + FactorialRecursion(0)); 
            Console.WriteLine("0! with Iteration: " + FactorialIteration(0) + "\n");
            //expected: 24
            Console.WriteLine("4! with Recursion: " + FactorialRecursion(4)); 
            Console.WriteLine("4! with Iteration: " + FactorialIteration(4) + "\n");
            //expected: 3628800
            Console.WriteLine("10! with Recursion: " + FactorialRecursion(10));
            Console.WriteLine("10! with Iteration: " + FactorialIteration(10) + "\n");
        }

        public static int FactorialRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return n * FactorialRecursion(n - 1);
            }
            else
            {
                //invalid input
                return -1;
            }
        }
        public static int FactorialIteration(int n)
        {
            int result = 1;
            while (n > 0)
            {
                result *= n;
                n--;
            }
            return result;
        }
    }

}