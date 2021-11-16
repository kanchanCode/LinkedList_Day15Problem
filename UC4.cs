using System;
using System.Collections.Generic;
using System.Text;

namespace practice_linkedlist
{
    public class UC4
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
       /* public bool Search(int value)
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
*/
        public int AddAfter(int searchedValue,int data)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return 0;
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
               
                searchNode.next =node ;
                searchNode.next.next = temp;
                return data;
            }
        }


        /*public bool AddBetween(int data, int position)
        {
            Node node = new Node(data);


            if (position < 1)
            {
                Console.WriteLine("Cannot INSERT!! Position should be greater than 1");
                return false;
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
                else
                {
                    Console.WriteLine("previous node is null");
                }

            }
            Console.WriteLine("Data inserted " + node.data);
            return true;
        }
*/
        public void Display()
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


