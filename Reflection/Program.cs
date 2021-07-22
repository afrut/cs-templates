using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // let the compiler automatically determine the type
            var foo = 34.77;
            System.Type type = foo.GetType();
            Console.WriteLine(type.ToString());

            var bar = "44";
            type = bar.GetType();
            Console.WriteLine(type.ToString());

            var baz = '3';
            type = baz.GetType();
            Console.WriteLine(type.ToString());
            Console.ReadKey();
        }
    }
}
