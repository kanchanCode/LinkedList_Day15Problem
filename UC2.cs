using System;
using System.Collections.Generic;
using System.Text;

namespace practice_linkedlist
{
    class UC2
    {
        internal Node head;
        public void AddFront(int data)
        {

            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = node;
                node.next = head;
                head = node;

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
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
