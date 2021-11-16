using System;
using System.Collections.Generic;
using System.Text;

namespace practice_linkedlist
{
    class UC10
    {
        internal Node head;

        public void AddNSort(int data)
        {

            Node node = new Node(data);
            Node temp;
            if (head == null || head.data>=node.data)
            {
                node.next = head; 
                head = node;

            }
           
            else
            {
                temp = head;
                while (temp.next != null && temp.next.data<node.data)
                {
                    temp = temp.next;
                    node.next = temp.next;
                    
                }
                temp.next = node;
            }
         
            Console.WriteLine("Data inserted " + node.data);
        }

        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write("Sorted list is "+temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

