using System;

namespace Polymorphism_Method_Overriding_OOP_Example
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Speak");
        }
    }


    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Barks");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal obj = new Dog();

            obj.Speak();


            Animal obj1 = new Animal();

            obj1.Speak();
        }
    }
}
