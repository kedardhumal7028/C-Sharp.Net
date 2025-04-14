using System;

namespace MultipleClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MultipleClass2 Tata = new MultipleClass2();
            Tata.Model = "Punch";
            Tata.color = "Black";
            Tata.Year = "2018";

            MultipleClass2 Suzuki = new MultipleClass2();
            Suzuki.Model = "Swift";
            Suzuki.color = "white";
            Suzuki.Year = "2014";

            Console.WriteLine(Tata.Model);
            Console.WriteLine(Suzuki.Year);
        }
    }
}
