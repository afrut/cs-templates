using System;

namespace BasicRecursion
{
    class Program
    {
        static int factorial(int n)
        {
            if (n > 1)
                return n * factorial(n - 1);
            else
                return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadKey();
        }
    }
}
