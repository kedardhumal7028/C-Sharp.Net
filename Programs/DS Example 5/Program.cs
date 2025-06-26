using System;

namespace DS_Example_5
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public static void InsertFirst(ref Node first, int no)
        {
            Node newn = new Node();

            newn.data = no;
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
