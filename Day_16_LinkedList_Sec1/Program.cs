// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace Day_16_LinkedList_Sec1
{
     public class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of Linked List
            LinkedList list = new LinkedList();
            // UC 10- Sorting the elements of the Linked List In the Ascending order
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.sortLinkedList();
            list.Display();
            Console.ReadLine();
        }
    }
}
