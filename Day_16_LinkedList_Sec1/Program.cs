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
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            //Deleting Last node in the list
            list.DeleteLastNode();
            list.Display();
            Console.ReadLine();
        }
    }
}
