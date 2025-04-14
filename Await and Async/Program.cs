using System;
using System.Threading.Tasks;

namespace Await_and_Async
{
    class Program
    {
        static async Task Main(string[] args) 
        {
            Console.WriteLine("Hello World!");

            
            await Task.WhenAll(Task1(), Task2(), Task3(), Task4());

            Console.WriteLine("All tasks completed."); 
        }

        public static async Task Task1() 
        {
            Console.WriteLine("Task 1 Starting");
            await Task.Delay(4000); 
            Console.WriteLine("Task 1 Completed");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Task 2 Starting");
            await Task.Delay(2000);
            Console.WriteLine("Task 2 Completed");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Task 3 Starting");
            await Task.Delay(3000);
            Console.WriteLine("Task 3 Completed");
        }

        public static async Task Task4()
        {
            Console.WriteLine("Task 4 Starting");
            await Task.Delay(1000);
            Console.WriteLine("Task 4 Completed");
        }
    }
}