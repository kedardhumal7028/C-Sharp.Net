using System;

namespace Abstraction_OOP_Example
{
    public abstract class Remote
    {
        public abstract void PressButton();
        
    }

    public class TVRemote : Remote
    {
        public override void PressButton()
        {
            Console.WriteLine("TV is ON");
        }
    }

    public class ACRemote : Remote
    {
        public override void PressButton()
        {
            Console.WriteLine("AC is ON");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Remote obj1 = new TVRemote();
            obj1.PressButton();


            Remote obj2 = new ACRemote();
            obj2.PressButton();
        }
    }
}
