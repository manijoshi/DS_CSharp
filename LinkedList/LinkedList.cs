using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    public class LinkedList<T> where T : IComparable<T>
    {
        private class Node
        {
            public T value;
            public Node next;
        }
        private Node Head;
        public LinkedList()
        {
            Head = null;
        }


        public void Insert(T value)
        {
            Node newNode = new Node();
            newNode.value = value;
            if (Head == null)
            {
                Head = newNode;
                Console.WriteLine("node inserted\n");
            }
            else
            {
                Node temp = Head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("node inserted\n");
            }
        }

        public void InsertAt(int position,T value)
        {
            Node newNode = new Node();
            newNode.value = value;
            if(position<=0 || position > Size())
            {
                Console.WriteLine("Enter a valid position starting from 1 till size of list\n");
                return;
            }
            else if (position == 1)
            {
                newNode.next = Head;
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                for(int i = 1; i < position; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            Console.WriteLine("node inserted\n");   
        }

        public void Delete(T value)
        {
            Node prev = null;
            Node temp = Head;
            try
            {
                if (Head == null)
                {
                    Console.WriteLine("List is empty\n");
                    return;
                }
                if(temp!=null && temp.value.Equals(value))
                {
                    Head = temp.next;
                    Console.WriteLine("node deleted\n");
                    return;
                }
                while(temp!=null && !(temp.value.Equals(value)))
                {
                    prev = temp;
                    temp = temp.next;
                }
                Console.WriteLine("node deleted\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteAt(int position)
        {
            Node temp = null;
            Node first = Head;
            if(position>Size() || position == 0)
            {
                Console.WriteLine("Position is not in linked list\n");
                return;
            }

            else if (position == 1)
            {
                Head = Head.next;
                Console.WriteLine("node deleted\n");
                return;
            }
            for(int i = 1; i < position - 1; i++)
            {
                first = first.next;
            }
            temp = first.next.next;
            first.next.next = null;
            first.next = temp;
            Console.WriteLine("node deleted\n");
        }

        public void Center()
        {
            Node first = Head;
            int size = Size();
            int mid;
            if (first == null)
            {
                Console.WriteLine("List is empty\n");
            }
            else
            {
                mid = size / 2;
                for(int i = 0; i < mid; i++)
                {
                    first = first.next;
                }
                Console.WriteLine("Center: " + first.value);
            }
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = Head;
            Node next = Head;
            if (current == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
            Console.WriteLine("List reversed successfully\n");
        }

        public int Size()
        {
            int count = 0;
            Node first = Head;
            while (first != null)
            {
                count++;
                first = first.next;
            }
            return count;
        }

        public void Sort()
        {
            Node temp = Head;
            if (temp == null) Console.WriteLine("List is empty\n");
            else
            {
                // Traverse the List
                while (temp != null)
                {
                    Node min = temp;
                    Node r = temp.next;

                    // Traverse the unsorted sublist
                    while (r != null)
                    {
                        if (min.value.CompareTo(r.value) > 0)
                            min = r;

                        r = r.next;
                    }

                    // Swap Data
                    int x = Convert.ToInt32(temp.value);
                    temp.value = min.value;
                    min.value = (T)Convert.ChangeType(x, typeof(T));
                    temp = temp.next;
                }
                Console.WriteLine("List sorted successfully\n");
            }
        }


        public void Iterator(LinkedList<T> myList)
        {
            if (Head == null)
            {
                Console.WriteLine("Linked list is empty\n");
                return;
            }
            LinkedList<T>.Enumerator enumerator = GetEnumerator();
            enumerator.Reset();
            Console.WriteLine("Linked list[by iterator]");
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current+" ");
            }
            Console.WriteLine();
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public class Enumerator
        {
            private Node current;
            private LinkedList<T> myList;
            public Enumerator(LinkedList<T> list)
            {
                myList = list;
                Reset();
            }
            public void Reset()
            {
                current = null;
            }
            public T Current
            {
                get
                {
                    return current.value;
                }
            }
            public bool MoveNext()
            {
                if (current == null)
                {
                    current = myList.Head;
                }
                else
                {
                    current = current.next;
                }
                return (current != null);
            }
        }
    }
    
}
