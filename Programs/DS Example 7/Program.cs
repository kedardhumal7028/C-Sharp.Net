using System;

namespace DS_Example_7
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public static void InsertFirst(ref Node first, int NO)
        {
            Node newn = new Node();

            newn.data = NO;
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
            Console.WriteLine("Elements of linklist are : ");

            while(first != null)
            {
                Console.Write(" | " +first.data + " | -> ");
                first = first.next;
            }

            Console.WriteLine("\n");
        }

        public static int Count(Node first)
        {
            int iCnt = 0;

            while(first != null)
            {
                iCnt++;
                first = first.next;
            }

            return iCnt;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node Head = null;

            InsertFirst(ref Head, 51);
            InsertFirst(ref Head, 21);
            InsertFirst(ref Head, 11);

            Display(Head);
            int iRet = Count(Head);

            Console.WriteLine("Number of elements are : {0}",iRet);
        }
    }
}
