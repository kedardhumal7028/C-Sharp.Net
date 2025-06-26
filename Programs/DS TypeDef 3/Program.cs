using System;

namespace DS_TypeDef_3
{
    class Program
    {
        class Node
        {
            public int data;
            public  Node next;
        }

        // C# मध्ये typedef, pointer, malloc वापरले जात नाही. आपण class वापरून तेच logic लिहू शकतो:


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node newn = new Node();

            newn.data = 11;
            newn.next = null;

            Console.WriteLine("Data : {0}",newn.data);
            Console.WriteLine("Size  nat manually calculate");

        }
    }
}
