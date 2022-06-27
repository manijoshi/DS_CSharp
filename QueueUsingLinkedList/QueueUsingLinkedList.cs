using System;

namespace QueueUsingLinkedList
{
    public class QueueUsingLinkedList
    {
        private class Node
        {
            public int data;
            public Node next;
        }
        Node front, rear;
        int count;
        public QueueUsingLinkedList()
        {
            this.front = null;
            this.rear = null;
            this.count = 0;
        }

        // enqueue 
        public void Enqueue(int data)
        {
            Node newNode = new Node();
            if (rear == null)
            {
                this.front = this.rear = newNode;
            }
            count++;
            newNode.data = data;
            rear.next = newNode;
            rear = newNode;
        }

        // dequeue
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty\n");
                return;
            }
            else
            {
                count--;
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }
                Console.WriteLine("Element removed\n");
            }
        }

        // peek
        public int Peek()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty\n");
                return -1;
            }
            return front.data;
        }

        // contains
        public bool Contains(int data)
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty\n");
                return false;
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }
        }

        // size
        public int Size()
        {
            return count;
        }

        // center
        public int Center()
        {
            Node fast = front;
            Node slow = front;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.data;
        }

        

        // reverse
        public void Reverse()
        {
            if (front == null) Console.WriteLine("Queue is empty\n");
            else
            {
                Node prev = null;
                Node current = front;
                Node next = front;
                while (current != null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                front = prev;
                Console.WriteLine("Queue reversed successfully\n");
            }
        }

        public void SelectionSort()
        {
            Node temp = front;
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
                Console.WriteLine("Queue sorted successfully\n");
            }
        }

        // traverse
        public void Print()
        {
            if (front == null) Console.WriteLine("Queue is empty\n");
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }

        //iterator
        public class Iterator
        {
            private Node currentNode;
            public Iterator(QueueUsingLinkedList linkedList)
            {
                this.currentNode = linkedList.front;
            }

            // hasnext()
            public bool hasNext()
            {
                return this.currentNode != null;
            }

            // movenext()
            public int moveNext()
            {
                int data = this.currentNode.data;
                this.currentNode = this.currentNode.next;
                return data;
            }
        }
    }
}
