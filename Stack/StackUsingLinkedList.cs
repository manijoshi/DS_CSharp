using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackUsingLinkedList
    {
        private class Node
        {
            public int data;
            public Node next;
        }
        private Node top;
        public int count;
        public StackUsingLinkedList()
        {
            this.top = null;
            this.count = 0;
        }

        // push() operation
        public void Push(int data)
        {
            Node temp = new Node();
            if (temp == null) Console.WriteLine("Stack Overflow\n");
            else
            {
                count++;
                temp.data = data;
                temp.next = top;
                top = temp;
                Console.WriteLine("Item pushed\n");
            }
        }

        // pop() operation
        public void Pop()
        {
            if (top == null) Console.WriteLine("Stack Underlfow\n");
            else
            {
                count--;
                top = top.next;
                Console.WriteLine("Item popped\n");
            }
        }

        // peek() operation
        public int Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        // contains operation
        public bool Contains(int data)
        {
            Node temp = top;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("Item exists\n");
                    return true;
                }    
                temp = temp.next;
            }
            return false;
        }

        // size()
        public int Size()
        {
            return count;
        }

        //center
        public int Center()
        {
            Node fast = top;
            Node slow = top;
            while(fast!=null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.data;
        }

        //sort
        public void SelectionSort()
        {
            Node temp = top;
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
                        if (min.data.CompareTo(r.data) > 0)
                            min = r;

                        r = r.next;
                    }

                    // Swap Data
                    //int x = Convert.ToInt32(temp.data);
                    int x = temp.data;
                    temp.data = min.data;
                    min.data = x;
                    temp = temp.next;
                }
                Console.WriteLine("Stack sorted successfully\n");
            }
        }

        public void Reverse()
        {
            if (top == null) Console.WriteLine("Stack is empty\n");
            else
            {
                Node prev = null;
                Node current = top;
                Node next = top;
                while (current != null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                top = prev;
                Console.WriteLine("Stack reversed successfully\n");
            }
        }

        // traverse
        public void Print()
        {
            if (top == null) Console.WriteLine("List is empty");
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        // isempty() operation
        public bool IsEmpty()
        {
            return top == null;
        }

        // iterator
        public class Iterator
        {
            private Node currentNode;
            public Iterator(StackUsingLinkedList linkedList)
            {
                this.currentNode = linkedList.top;
            }

            // hasnext()
            public bool hasNext()
            {
                return this.currentNode != null;
            }

            // movenext()
            public int  moveNext()
            {
                int data = this.currentNode.data;
                this.currentNode = this.currentNode.next;
                return data;
            }
        }
    }
}
