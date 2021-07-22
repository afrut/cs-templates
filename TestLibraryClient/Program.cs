using System;

namespace TestLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library test string is: {0}", TestLibrary.TestClass.TestString);
            Console.ReadLine();
        }
    }
}