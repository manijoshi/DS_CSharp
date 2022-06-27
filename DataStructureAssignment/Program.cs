using System;

namespace DataStructureAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Linked List");
                Console.WriteLine("2. Stack");
                Console.WriteLine("3. Queue");
                Console.WriteLine("4. Priority Queue");
                Console.WriteLine("5. Hash Table");
                Console.WriteLine("6. N-Child Tree");
                Console.WriteLine("0 to Exit\n");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        LinkedList.Program.Main();
                        break;
                    case 2:
                        Stack.Program.Main();
                        break;
                    case 3:
                        QueueUsingLinkedList.Program.Main();
                        break;
                    case 4:
                        PriorityQueue.Program.Main();
                        break;
                    case 5:
                        HashTable.Program.Main();
                        break;
                    case 6:
                        NChildTree.Program.Main();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
            }
        }
    }
}
