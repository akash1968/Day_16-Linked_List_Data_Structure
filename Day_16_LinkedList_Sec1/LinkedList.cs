﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_LinkedList_Sec1
{
    class LinkedList
    {
        public Node head;
        //UC 1 - Create a simple Linked List of 56,30,70
        // Insert Last Method
        public void InsertLast(int new_data)
        {
            //Creating a new new node. The next of the new node will point to the head of the Linked List
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                // getting where the last node is pointing to null
                Node lastNode = GetLastNode();
                //assigning that pointer to new node
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list " + new_node.data);
        }
        //Method to check how many elements are present in the linked list
        //New node is to be inserted at last
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //method to display elements present in the linked list
        public void Display()
        {
            Console.WriteLine("Displaying Nodes ");
            //creating a copy of head and storing in temp variable
            //temporary variable to check if head is pointing to null or not
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Is empty");
                return;
            }
            else
            {
                while(temp !=null)
                {
                    Console.Write(" "+temp.data);
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.next;
                }
            }
        }
        //UC2- Insert Elements from Front in Linked List
        public void InsertFront(int new_data)
        {
            //Creating a new new node. The next of the new node will point to the head of the Linked List
            Node new_node = new Node(new_data);
            // To add any node at the front , we want the head to point to it.
            new_node.next = this.head;
            //The previous head node is now the second node of Linked List because the new node is added at the front.
            this.head = new_node;
            Console.WriteLine("Inserted into list "+new_node.data);
        }
            

    }
}
