using System;

namespace HashTable
{
    public class Program
    {
        public static void Main()
        {
            Hashtable<int> hash = new Hashtable<int>(5);
            int value;
            string key;
            bool flag = true;

            while (flag)
            {
                try
                {
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Delete");
                    Console.WriteLine("3. Contains");
                    Console.WriteLine("4. Get Value By Key");
                    Console.WriteLine("5. Size");
                    Console.WriteLine("6. Iterator");
                    Console.WriteLine("7. Print");
                    Console.WriteLine("0 to exit");
                    Console.Write("\nEnter Choice of Operation: ");
                    int choice;
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Key : ");
                            key = Console.ReadLine();
                            Console.Write("Value: ");
                            value = int.Parse(Console.ReadLine());
                            hash.Insert(key, value);
                            break;

                        case 2:
                            Console.Write("Key : ");
                            key = Console.ReadLine();
                            hash.Delete(key);
                            break;

                        case 3:
                            Console.Write("Key : ");
                            key = Console.ReadLine();
                            bool result = hash.Contains(key);
                            Console.WriteLine("\n" + result);
                            break;

                        case 4:
                            Console.Write("Key : ");
                            key = Console.ReadLine();
                            try
                            {
                                Console.WriteLine("Value at key:{0} is " + hash.GetValueByKey(key), key + "\n");
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("No Such key present in Hash Table\n");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Size: " + hash.Size() + "\n");
                            break;

                        case 6:
                            hash.Iterator();
                            break;

                        case 7:
                            hash.Print();
                            break;

                        case 0:
                            flag = false;
                            break;

                        default:
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