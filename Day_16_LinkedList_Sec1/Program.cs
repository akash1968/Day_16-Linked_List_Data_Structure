using System;

namespace Day_16_LinkedList_Sec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of Linked List
            LinkedList list = new LinkedList(); 
            // UC4--Inserting Elements at the particular position in the linked list
            list.Add(56);
            list.Add(30);
            list.Add(70);          
            int a = list.Search(30);
            list.InsertAtParticularPosition(a+1,40);          
            list.Display();
            Console.ReadLine();
        }
    }
}
