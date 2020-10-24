using System;
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
            //Creating an object of Node
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
                    Console.WriteLine(" "+temp.data);
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.next;
                }
            }
        }
            

    }
}
