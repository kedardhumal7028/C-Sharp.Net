using System;

namespace DS_Example_6
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public static void InsertFirst(ref Node first, int No)
        {
            Node newn = new Node(); // object banvla 

            newn.data = No;
            newn.next = null;

            if(first == null)
            {
                first = newn;
            }
            else
            {
                newn.next = first;
                first = newn;
            }
        }

        public static void Display(Node first)
        {
            Console.WriteLine("Elements of linked list are:");

            while (first != null)
            {
                Console.Write(first.data + " -> ");
                first = first.next;
            }

            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node Head = null;

            InsertFirst(ref Head, 51);
            InsertFirst(ref Head, 21);
            InsertFirst(ref Head, 11);

            Display(Head);
        }
    }
}
