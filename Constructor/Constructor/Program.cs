using System;

namespace Constructor
{
    class Program
    {
        class Car
        {
             public string model;

            public Car()
            {
                model = "Tata";
            }
        }
        static void Main(string[] args)
        {
            Car ford = new Car();
            Console.WriteLine(ford.model);
        }
    }
}
