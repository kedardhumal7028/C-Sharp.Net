using System;

namespace Inheritance_OOP_Example
{
    public class GanpatiMold
    {
        public void BasicShape()
        {
            Console.WriteLine("Ganpati Mold : Head, trunk, ears and body");
        }
    }

    public class GanpatiMurti : GanpatiMold
    {
        public void Decoration()
        {
            Console.WriteLine("Ganpati Murti Decorations with a colors and ornaments");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GanpatiMurti obj = new GanpatiMurti();

            obj.BasicShape();

            obj.Decoration();
        }
    }
}
