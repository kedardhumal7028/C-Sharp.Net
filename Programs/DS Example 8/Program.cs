using System;

namespace DS_Example_8
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
            Node newn = new Node();

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

        public static void InsertLast(ref Node first, int No)
        {
            Node newn = new Node();
            newn.data = No;
            newn.next = null;

            if (first == null)
            {
                first = newn;
            }
            else
            {
                Node temp = first;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newn;
            }
        }


        public static void Display(Node first)
        {
            Console.WriteLine("Elements of Lin ked List are : \n");
            while (first != null)
            {
                Console.WriteLine("| {0} | -> ", first.data);
                first = first.next;
            }
            Console.WriteLine("NULL\n");
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

            Console.WriteLine("number of elements are : {0}",iRet);

            InsertLast(ref Head, 101);
            InsertLast(ref Head, 111);

            Display(Head);
            iRet = Count(Head);

            Console.WriteLine("number of elements are : {0}", iRet);
        }

    }
}
