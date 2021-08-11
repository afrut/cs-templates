using System;
using System.Threading.Tasks;

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
            var tasks = new Task[10];
            tasks[0] = Task.Run(() => someFunc("1", 1));
            tasks[1] = Task.Run(() => someFunc("2", 2));
            tasks[2] = Task.Run(() => someFunc("3", 3));
            tasks[3] = Task.Run(() => someFunc("4", 4));
            Console.WriteLine("Going to do something else");
            for (int i = 0; i < 2.5 * (int)Math.Pow(10, 7); i++) { }
            Console.WriteLine("Finished. Waiting for other tasks");
            await tasks[0];
            Console.WriteLine("Task 0 completed");
            await tasks[1];
            Console.WriteLine("Task 1 completed");
            await tasks[2];
            Console.WriteLine("Task 2 completed");
            await tasks[3];
            Console.WriteLine("Task 3 completed");
            Console.ReadLine();
        }
    }
}
