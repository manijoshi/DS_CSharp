using System;

namespace NChildTree
{
    public class Program
    {
        public static void Main()
        {
            // a new tree with a parameter of max child a node can hold. here, maxchild is 3.
            Tree<int> tree = new Tree<int>(3);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1. Insert");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Contains");
                Console.WriteLine("4. Get Element by Value");
                Console.WriteLine("5. Get Element by Level");
                Console.WriteLine("6. Iterator Depth First");
                Console.WriteLine("7. Iteratot Breadth First");
                Console.WriteLine("8. Print Depth First");
                Console.WriteLine("9. Print Breadth First");
                Console.WriteLine("0 to exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        tree.Insert();
                        break;

                    case 2:
                        tree.Delete();
                        break;

                    case 3:
                        Console.Write("\nEnter Value : ");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n" + tree.Contains(value));
                        break;

                    case 4:
                        tree.GetElementByValue();
                        break;

                    case 5:
                        tree.GetElementByLevel();
                        break;

                    case 6:
                        tree.IteratorDFS();
                        break;

                    case 7:
                        tree.IteratorBFS();
                        break;
                    case 8:
                        tree.PrintDFS();
                        break;

                    case 9:
                        tree.PrintBFS();
                        break;

                    case 0:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}