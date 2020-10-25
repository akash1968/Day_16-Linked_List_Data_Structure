// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_LinkedList_Sec1
{
    public class LinkedList
    {
        public Node head;
        // Method to Add Elements Elements into the Linked List
        public void Add(int data)
        {
            //Creating a new new node. The next of the new node will point to the head of the Linked List
            Node node = new Node(data);
            //checking if the head is pointing to null
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                //till the next pointer is not null running the while loop
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                //assigning the pointer to new node
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list ", node.data);
        }
        // Method to Display the Linked List
        public void Display()
        {
            Console.WriteLine("Displaying Nodes After Adding the new element ");
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
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.next;
                }
            }
        }
        //UC 8- Ability to Enter node 40 after node 30
        public int InsertAtParticularPosition(int position, int data)
        {
            //Creating a new new node. The next of the new node will point to the head of the Linked List
            Node newElement = new Node(data);
            // checking if the head pointer is pointing to null
            if (this.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
            }
            else
            {
                //creating a temporary variable which acts as pointer to check for next node
                Node temp = this.head;
                bool flag = true;
                // checking if the pointer is pointing towards entered position
                while (flag)
                {
                    if (temp.data == position)
                    {
                        flag = false;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                // declaring the new node to point towards next node
                newElement.next = temp.next;
                temp.next = newElement;
            }
            return data;
        }

       // UC_9- Method to display the size of the linked list
        public int SizeOfList()
        {
            int size = 0;
            // Checking If head is pointing to null then size of list is zero
            if (this.head == null)
            {
                return 0;
            }
            else
            {
                //temporary variable to check if head is pointing to null or not
                Node temp = this.head;
                // if the next node is not pointing to null then increasing the size of list
                while (temp.next != null)
                {
                    size++;
                    temp = temp.next;
                }
                return size + 1;
            }

        }
        // Method to search for a particular element in the linked list
        public int SearchForAnElement(int data)
        {
            int pos = 0;
            // Checking If head is pointing to null then size of list is zero
           if (this.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
                return -1;
            }
            else
            {
                //temporary variable to check if head is pointing to null or not
                Node temp = this.head;
                bool flag = true;
                while (flag)
                {
                    pos++;
                    if (temp.data == data)
                    {
                        flag = false;
                    }
                    else if (temp.next == null)
                    {
                        if (temp.data == data)
                        {
                            return pos;
                        }
                        else
                        {
                            flag = false;
                            pos++;
                        }
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                // If the position is exceeding the size of list then displaying error message
                if (pos == SizeOfList() + 1)
                {
                    Console.WriteLine("Element not found in the list");
                    return 0;
                }
                return pos;
            }
        }
        // UC_9 Deleting a particular element in the Linked List
        public void DeleteElement(int data)
        {
            // Checking If head is pointing to null or not
            if (this.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
            }
            else
            {
                //temporary variable to check if head is pointing to null or not
                Node temp = this.head;
                // Checking if the second node pointer is pointing to null or not
                while (temp.next.next != null)
                {
                    // if the second node pointer has data then moving pointer to next node 
                    if (temp.next.data == data)
                    {
                        temp.next = temp.next.next;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                // if second node pointer is pointing to null then allocating the value to garbage collector thus deleting that data
                if (temp.next.next == null)
                {
                    if (temp.next.data == data)
                    {
                        temp.next = null;
                    }
                }
            }
        }

    }
}
