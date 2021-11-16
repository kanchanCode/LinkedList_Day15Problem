using System;

namespace practice_linkedlist
{
    public class Node
    {
        public static readonly object UC6;
        public int data;
        public int prev_node;
        public Node next;
 
        public Node(int data)
        {
            this.data = data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. UC1 Simple Linklist \n2. UC2 Add node at front \n3. UC3 Append nodes to head(user input list) \n4. UC4 Insert in between nodes \n" +
                "5. UC5 Delete the first item of the list \n6. UC6 Delete the last node \n7. UC7-9 TestCases \n8. UC10 Add in ascending order");

            Console.WriteLine("Enter the number whose output you want to check");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    UC1 list = new UC1();
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                case 2:

                    UC2 list1 = new UC2();
                    list1.AddFront(70);
                    list1.AddFront(30);
                    list1.AddFront(56);
                    list1.Display();
                    break;

                case 3:
                    UC3 MyList = new UC3();
                    Console.WriteLine("How many elements you want to enter ?");
                    int input = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= n; i++)
                    {
                        Console.WriteLine("Enter element ");
                        int e = Convert.ToInt32(Console.ReadLine());
                        MyList.append(e);

                    }
                    // MyList.append(56);
                    //  MyList.append(30);
                    // MyList.append(70);
                    MyList.PrintList();
                    break;

                case 4:
                    UC4 mylist = new UC4();
                    mylist.Add(70);
                    mylist.Add(56);
                    mylist.AddAfter(70, 30);
                    mylist.AddAfter(30, 40);
                    Console.Write("list after insertion is :");
                    mylist.Display();

                    break;
                case 5:
                    UC5 list2 = new UC5();  
                    list2.Add(56);
                    list2.Add(30);
                    list2.Add(70);
                    list2.PopFirst();
                    Console.Write("After pop :");
                    list2.Display();
                    break;
                case 6:
                    UC6 list3 = new UC6();
                    list3.Add(56);
                    list3.Add(30);
                    list3.Add(70);
                    list3.PopLast();
                    Console.Write("After pop :");
                    list3.Display();
                    break;

                case 7:
                    testFunctions obj = new testFunctions();
                    obj.Add(56);
                    obj.Add(30);
                    obj.Add(70);

                    if (obj.Search(30))
                    {
                        Console.WriteLine("Element found");
                    }
                    else
                    {
                        Console.WriteLine("Element not found");
                    }

                    obj.AddAfter(30, 40);
                    obj.Delete(30);
                    obj.Display();
                    break;
                case 8:
                    UC10 obj1 = new UC10();
                    obj1.AddNSort(10);
                    obj1.AddNSort(8);
                    obj1.AddNSort(50);
                    obj1.AddNSort(25);
                    obj1.Display();

                    break;

            }



            
        }
    }

    
}
