// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_LinkedList_Sec1
{
    //The node of a singly linked list contains a data part and a link part
    //The link will contain the address of next node and is initialized to null

   public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
           this.data = data;
            this.next = null;
        }
    }
}
