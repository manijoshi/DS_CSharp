using System;
using System.Collections.Generic;

namespace HashTable
{
    public class Hashtable<T>
    {
        // Node of a Hash Table
        public class Node
        {
            public Node Next { get; set; }
            public string Key { get; set; }
            public T Value { get; set; }
        }
        public int size;
        private int tableSize;
        private Node[] buckets;

        public Hashtable(int size)
        {
            // Create a new Array of buckets of given size
            buckets = new Node[size];
            tableSize = size;
        }

        // Inserting new Node in Hash Table
        public void Insert(string key, T value)
        {
            var (_, element) = GetNode(key);

            // Checks if Hash Table is Full
            if (size == tableSize)
            {
                Console.WriteLine("\nHash Table Overflow");
                return;
            }
            // Checks if the entered key is in the hash table already or not
            if (element != null)
            {
                Console.WriteLine("Key is already in the hash table");
                return;
            }
            // Create a instance of new Node
            Node newNode = new Node
            {
                Key = key,
                Value = value,
                Next = null
            };
            // Get position in hash table were you want to insert
            int position = GetBucketByKey(key);
            Node hashtable = buckets[position];

            // If node is empty at given position
            if (null == hashtable)
            {
                buckets[position] = newNode;
                //Increment Size
                size++;
                return;
            }
            // If node already has a element at that position then traverse the linked list and add at the end
            while (hashtable.Next != null)
            {
                hashtable = hashtable.Next;
            }
            hashtable.Next = newNode;
            size++;
        }

        // Method checks if key is present in hash table
        protected (Node previous, Node current) GetNode(string key)
        {
            // Gets the position of new Node by calling this method
            int position = GetBucketByKey(key);
            Node hashtable = buckets[position];
            Node previous = null;

            while (hashtable!=null)
            {
                if (hashtable.Key == key)
                {
                    return (previous, hashtable);
                }
                previous = hashtable;
                hashtable = hashtable.Next;
            }
            return (null, null);
        }

        // Gets the value of given key
        public T GetValueByKey(string key)
        {
            // check the hash table if key is present
            var (_, element) = GetNode(key);

            // If key not found then throw an exception
            if (element == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            return element.Value;
        }

        
        // Deleting an element from the hash table at a given key
        public void Delete(string key)
        {
            // Gets position where to delete 
            int position = GetBucketByKey(key);
            var (previous, current) = GetNode(key);
            // If table is empty
            if (size == 0)
            {
                Console.WriteLine("Hash Table is empty!");
                return;
            }
            // If key not found in hash table
            if (current==null)
            {
                Console.WriteLine("No such Element with key present in the Hash Table");
                return;
            }
            // If key Found at start of linked list i.e. in the array position
            if (previous==null)
            {
                buckets[position] = null;
                buckets[position] = current.Next;
                size--;
                return;
            }
            // If not at start but in the linked list
            previous.Next = current.Next;
            size--;
        }

        public bool Contains(string key)
        {
            var (_, element) = GetNode(key);
            return element!=null;
        }

        // Method is Used to give index to a new Node
        public int GetBucketByKey(string key)
        {
            return key[0] % buckets.Length;
        }

        // returns the no of elements in the hashtable
        public int Size()
        {
            return size;
        }

        // Prints the hash table
        public void Print()
        {
            if (size == 0)
            {
                Console.WriteLine("Hash Table is empty!");
                return;
            }
            Console.WriteLine("Key\tValue");
            foreach (var i in buckets)
            {
                if (i != null)
                {
                    var temp = i;
                    while (temp.Next != null)
                    {
                        Console.WriteLine(temp.Key + "\t\t" + temp.Value);
                        temp = temp.Next;
                    }
                    Console.WriteLine(temp.Key + "\t\t" + temp.Value);
                }
            }
        }

        

        // Iterator of hash table
        public void Iterator()
        {
            if (size == 0)
            {
                Console.WriteLine("Hash Table is empty!");
                return;
            }

            else
            {
                IEnumerable<Node> hashTable = GetIteratedTable();
                Console.WriteLine("Hash Table [using Iterator]");
                Console.WriteLine("Key\tValue");
                foreach (var i in hashTable)
                {
                    Console.WriteLine(i.Key + "\t\t" + i.Value);
                }
            }
        }

        public IEnumerable<Node> GetIteratedTable()
        {
            Node temp;
            foreach (var items in buckets)
            {
                temp = items;
                // Returning the element after every iteration
                if (items != null && items.Next == null)
                {
                    yield return items;
                }
                if (items != null && items.Next != null)
                {
                    while (temp.Next != null)
                    {
                        yield return temp;
                        temp = temp.Next;
                    }
                    yield return temp;
                }
            }
        }

    }
}