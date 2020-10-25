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
            // UC8--Ability to search node 30 and insert node 40 after it in the linked list
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(30, 40);
            list.Display();
            Console.ReadLine();
        }
    }
}
