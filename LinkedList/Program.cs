using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main()
        {
            LinkedList<int> obj = new LinkedList<int>();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Which operation you wanna perform...");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Insert At position");
                    Console.WriteLine("3. Delete");
                    Console.WriteLine("4. Delete At a position");
                    Console.WriteLine("5. Sort");
                    Console.WriteLine("6. Reverse");
                    Console.WriteLine("7. Center");
                    Console.WriteLine("8. Size");
                    Console.WriteLine("9. Iterator");
                    Console.WriteLine("0 to Exit\n");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.Write("Enter an element to insert: ");
                            obj.Insert(int.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.Write("Enter an element to insert: ");
                            int data = int.Parse(Console.ReadLine());
                            Console.Write("Enter position: ");
                            int pos = int.Parse(Console.ReadLine());
                            obj.InsertAt(pos, data);
                            break;
                        case 3:
                            Console.Write("Enter an element to delete: ");
                            obj.Delete(int.Parse(Console.ReadLine()));
                            break;
                        case 4:
                            Console.Write("Enter position: ");
                            int pos1 = int.Parse(Console.ReadLine());
                            obj.DeleteAt(pos1);
                            break;
                        case 5:
                            obj.Sort();
                            break;
                        case 6:
                            obj.Reverse();
                            break;
                        case 7:
                            obj.Center();
                            break;
                        case 8:
                            Console.WriteLine("Count " + obj.Size() + "\n");
                            break;
                        case 9:
                            obj.Iterator(obj);
                            break;
                        case 0:
                            flag = false;
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}

