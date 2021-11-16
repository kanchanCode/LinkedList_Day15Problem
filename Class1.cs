using System;
using System.Collections.Generic;
using System.Text;

namespace practice_linkedlist
{
    public class testFunctions
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
        public bool Search(int value)
        {
            Node current = head; // Initialize current
            while (current != null)
            {
                if (current.data == value)
                    return true; // data found
                current = current.next;
            }

            return false; // data not found
        }
       
        public Node AddAfter(int searchedValue, int data)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return null;
            }

            else
            {
                Node node = new Node(data);
                Node searchNode = head;

                while (searchNode.data != searchedValue)
                {
                    searchNode = searchNode.next;
                }
                Node temp = searchNode.next;

                searchNode.next = node;
                searchNode.next.next = temp;
                return searchNode;
            }
        }


        public int Delete(int searchedValue)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return 0;
            }

            else
            {
                Node temp = head;
                Node previous = null;

                while (temp.data != searchedValue)
                {
                    previous = temp;
                    temp = temp.next;
                }
                previous.next = temp.next;
                Console.WriteLine("Removed " + searchedValue);

                
                int size = 1;
                while (temp != null)
                {
                    size++;
                    temp = temp.next;
                }

                return size;
        
            }
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
