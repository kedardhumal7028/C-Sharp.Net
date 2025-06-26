using System;

namespace DS_Example_4
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
            // logic here 
        }

        public static void Display(Node first)
        {
            // logic here
        }



        static void Main(string[] args)
        {
            Node Head = null;

            
            InsertFirst(ref Head, 51 );
            InsertFirst(ref Head, 21);
            InsertFirst(ref Head, 11);

            Display(Head);

        }
    }
}
