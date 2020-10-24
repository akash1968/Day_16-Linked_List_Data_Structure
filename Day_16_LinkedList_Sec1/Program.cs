using System;

namespace Day_16_LinkedList_Sec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of Linked List
            LinkedList list = new LinkedList();
            //Searching for an particular element in the linked list the linked list
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            Console.WriteLine("Searching for 30 "+ list.Search(30));
            list.Display();    
            Console.ReadLine();
        }
    }
}
