using System;
using System.Collections.Generic;
using System.Text;
//node structure
namespace practice_linkedlist
{
    class UC3
    {
        internal Node head;
        //Add new element at the end of the list
        public void append(int data)
        {
            Node newNode = new Node(data);

            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = newNode;
                temp = head;
                while (temp.next != null)

                    temp = temp.next;
                temp.next = newNode;

            }
            Console.WriteLine("Element inserted " + newNode.data);

        }
        //display the content of the list
        public void PrintList()
        {
            Node temp = head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    }
}

