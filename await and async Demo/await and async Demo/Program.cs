using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace await_and_async_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadLine();
        }

        public static void Task1()
        {
            Console.WriteLine("Task 1 Started");
            Thread.Sleep(4000);
            Console.WriteLine("Task 1 completed");
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Task 2 completed");
        }

        public static void Task3()
        {
            Console.WriteLine("Task 3 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Task 3 completed");
        }

        public static void Task4()
        {
            Console.WriteLine("Task 4 Started");
            Thread.Sleep(1000);
            Console.WriteLine("Task 4 completed");
        }


    }
}
