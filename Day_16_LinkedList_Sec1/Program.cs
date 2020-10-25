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
            // UC9- Ability to delete a particular node
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("Enter the element to be deleted ");
            int del = Convert.ToInt32(Console.ReadLine());
            int ifPresent = list.SearchForAnElement(del);
            if (ifPresent >= 1)
            {
                list.DeleteElement(del);
                list.Display();
            }
            // Showing the size of the list
            Console.WriteLine("\nSize of the list after deleting "+list.SizeOfList());
            Console.ReadLine();
        }
    }
}
