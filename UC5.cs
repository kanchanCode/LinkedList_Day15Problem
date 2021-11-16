using System;
using System.Collections.Generic;
using System.Text;

namespace practice_linkedlist
{
    class UC5
    {

        internal Node head;

        public void Add(int data)
        {

            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Data inserted " + node.data);
        }

        public void PopFirst()
        {
            if (head != null)
            {
                Node temp = head;
                head = head.next;
                temp = null;

            }

            else
                Console.WriteLine("List is empty");
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


