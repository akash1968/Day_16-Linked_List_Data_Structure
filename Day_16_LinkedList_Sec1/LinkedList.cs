using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_LinkedList_Sec1
{
    class LinkedList
    {
        public Node head;
       public void Add(int data)
        {
            //Creating a new new node. The next of the new node will point to the head of the Linked List
            Node node = new Node(data);
            //checking if the head is pointing to null
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                //till the next pointer is not null running the while loop
                while(temp.next !=null)
                {
                    temp = temp.next;
                }
                //assigning the pointer to new node
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list ",node.data);
        }
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
                while(temp !=null)
                {
                    Console.Write(" "+temp.data);
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.next;
                }
            }
        }
        //UC 4- Insert In Between Two Nodes
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            //searching for the empty node
            while(node!=null)
            {
                if(node.data==value)
                {
                    //when empty node is found then returning the count
                    return count;
                }
                //assigning pointer to next node
                node = node.next;
                //increasing the count
                count++;
            }
            return count;
        }
       //UC 4- Insert At Particular Position
       public Node InsertAtParticularPosition(int position, int data)
        {
            if(position<1)
                Console.WriteLine("Invalid Position");
            if(position==1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(position-- !=0)
                {
                    if(position==1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if(position !=1)
                    Console.WriteLine("Position out of Range");
            }
                       return head;
        }           
    }
}
