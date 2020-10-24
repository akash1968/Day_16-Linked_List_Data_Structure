using System;

namespace Day_16_LinkedList_Sec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of Linked List
            LinkedList list = new LinkedList();
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
