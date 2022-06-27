using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    public class Program
    {
        public static void Main()
        {
            MyPriorityQueue<int> obj = new MyPriorityQueue<int>();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\n1. Size");
                    Console.WriteLine("2. Contains");
                    Console.WriteLine("3. Remove element");
                    Console.WriteLine("4. Add element");
                    Console.WriteLine("5. Peek element");
                    Console.WriteLine("6. Highest Priority");
                    Console.WriteLine("7. Reverse");
                    Console.WriteLine("8. Center");
                    Console.WriteLine("9. Iterator");
                    Console.WriteLine("10. Print");
                    Console.WriteLine("Enter 0 to exit");

                    int input1 = int.Parse(Console.ReadLine());

                    switch (input1)
                    {
                        case 1:
                            int count = obj.Size();
                            Console.WriteLine("Number of elements: {0}", count);
                            break;

                        case 2:
                            Console.WriteLine("Enter an element to be searched");
                            int e = int.Parse(Console.ReadLine());

                            if (obj.Contains(e))
                            {
                                Console.WriteLine("Priority Queue contains {0}\n", e);
                            }
                            else
                            {
                                Console.WriteLine("Priority Queue does not contains {0}\n", e);
                            }
                            break;

                        case 3:
                            obj.Dequeue();
                            break;

                        case 4:
                            Console.WriteLine("Enter priority");
                            int priority = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the element");
                            int element = int.Parse(Console.ReadLine());

                            obj.Enqueue(priority, element);

                            break;

                        case 5:
                            obj.Peek();
                            break;

                        case 6:
                            obj.GetHighestPriority();
                            break;
                        case 7:
                            obj.Reverse();
                            break;
                        case 8:
                            obj.Center();
                            break;
                        case 9:
                            obj.Iterator();
                            break;
                        case 10:
                            obj.Print();
                            break;
                        case 0:
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
