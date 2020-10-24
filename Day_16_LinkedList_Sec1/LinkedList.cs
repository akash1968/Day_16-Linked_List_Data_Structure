using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_LinkedList_Sec1
{
    class LinkedList
    {
        public Node head;
        //UC 3 - Create a simple Linked List of 56,30,70
        // Append Elements at Last In Linked List 
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
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.next;
                }
            }
        }
        //UC-5-Delete the first element in the linked list
        public Node DeleteFirstNode()
        {
            if(this.head==null)
            {
                return null;
            }
            //move the head pointer to next node, previous will automatically allocate for garbage collector
            this.head = this.head.next;
            return this.head;
        }
    }
}
