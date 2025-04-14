using System;
using System.Linq;

namespace Linq_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] age = { 12, 23, 21, 22, 45, 33, 20, 26, 55, 66};

            //var a = from i in age where i > 20 orderby i ascending select i;


            String[] names = { "Kedar", "Suraj", "Abhi", "Sanket", "Om", "Rohit", "Pranit" };

            var a = from name in names where name.StartsWith("S") select name;

            foreach(string item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
