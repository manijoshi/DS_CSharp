﻿using System;
using System.Collections.Generic;
using System.Text;
using static Stack.StackUsingLinkedList;

namespace Stack
{
    public class Program
    {
        public static void Main()
        {
            //Console.Write("Enter size of stack: ");
            //int size = int.Parse(Console.ReadLine());
            StackUsingLinkedList obj = new StackUsingLinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Which operation you wanna perform on stack...");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Size");
                Console.WriteLine("6. Reverse");
                Console.WriteLine("7. Traverse");
                Console.WriteLine("8. Center");
                Console.WriteLine("9. Iterator");
                Console.WriteLine("10. Sort");
                Console.WriteLine("0 to Exit\n");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter an element to push: ");
                        obj.Push(int.Parse(Console.ReadLine()));

                        break;
                    case 2:
                        obj.Pop();
                        break;
                    case 3:
                        obj.Peek();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter an element to search: ");
                        int ele = int.Parse(Console.ReadLine());
                        Console.WriteLine("Item exists: " + obj.Contains(ele)+"\n");
                        break;
                    case 5:
                        Console.WriteLine("Size: "+obj.Size()+"\n");
                        break;
                    case 6:
                        obj.Reverse();
                        break;
                    case 7:
                        obj.Print();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        Console.WriteLine("Center element: "+obj.Center());
                        break;
                    case 9:
                        Iterator itr = new Iterator(obj);
                        Console.WriteLine("Print [by iterator]");
                        while (itr.hasNext())
                        {
                            Console.Write(itr.moveNext() + " ");
                        }
                        Console.WriteLine("\n");
                        break;
                    case 10:
                        obj.SelectionSort();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
            }
        }
    }
}