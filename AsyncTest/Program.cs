using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AsyncTest
{
    class Program
    {
        public static void someFunc(string name, int p)
        {
            Console.WriteLine($"Starting {name}");
            for (int i = 0; i < p * (int)Math.Pow(10, 7); i++) { }
            Console.WriteLine($"Ending {name}");
        }

        static async Task Main(string[] args)
        {
            var tasks = new List<Task>();
            tasks.Add(Task.Run(() => someFunc("1", 1)));
            tasks.Add(Task.Run(() => someFunc("2", 2)));
            tasks.Add(Task.Run(() => someFunc("3", 3)));
            tasks.Add(Task.Run(() => someFunc("4", 4)));
            Console.WriteLine("Going to do something else");
            for (int i = 0; i < 2.5 * (int)Math.Pow(10, 7); i++) { }
            Console.WriteLine("Finished. Waiting for other tasks");

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);
            Console.WriteLine("Task 0 completed");
            Console.WriteLine("Task 1 completed");
            Console.WriteLine("Task 2 completed");
            Console.WriteLine("Task 3 completed");
            Console.ReadLine();
        }
    }
}
