using System;

namespace DS2
{
    class Program
    {
        class Node
        {
            public int data;
            public Node next;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Node create karat aahot (no malloc needed in C#)
            Node newn = new Node();
            newn.data = 11;
            newn.next = null;

            Console.WriteLine("Data: {0}", newn.data);

            // Size of structure jase C madhe diste, C# madhe direct nahi det.
            // Pan approx manually pahije asel tar `System.Runtime.InteropServices.Marshal.SizeOf`
            //Console.WriteLine("Size concept C# madhe compiler ne handle hoto.");
        }
    }

}
