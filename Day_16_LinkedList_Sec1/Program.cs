using System;

namespace Day_16_LinkedList_Sec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of Linked List
            LinkedList list = new LinkedList(); 
            //Inserting Elements at the front of the linked list
            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
