using System;


namespace practice_linkedlist
{
   public class UC6
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

        public void PopLast()
        {
            if (head != null)
            {
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    Node temp = head;
                    while (temp.next.next != null)

                        temp = temp.next;
                    Node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
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


