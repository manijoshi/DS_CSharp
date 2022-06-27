using System;
using System.Collections.Generic;
using MyLinkedList;

namespace PriorityQueue
{
    class MyPriorityQueue<T>
    {
        
        private class QueueNode
        {
            public int priority;
            public T value;
        }
        

        private MyLinkedList<QueueNode> queue;
        private int count = 0, reverse = 0;

        
        public MyPriorityQueue()
        {
            queue = new MyLinkedList<QueueNode>();
        }


        
        public void Enqueue(int priority, T value)
        {
            QueueNode newNode = new QueueNode();
            newNode.priority = priority;
            newNode.value = value;
            int position = 1;
            // If list is empty insert at the start
            if (count == 0)
            {
                queue.Insert(newNode);
                count++;
                Console.WriteLine("\nelement enqueued");
                return;
            }
            // If queue is not reversed 
            if (reverse % 2 == 0)
            {
                foreach (var i in queue)
                {
                    if (i.priority > priority)
                    {
                        queue.InsertAt(position, newNode);
                        count++;
                        Console.WriteLine("\nelement enqueued");
                        return;
                    }
                    position++;
                }
            }
            // If queue is reversed the it would be in decreasing order of its priority in the Linked List so we traverse it differently
            else
            {
                foreach (var i in queue)
                {
                    if (i.priority < priority)
                    {
                        queue.InsertAt(position, newNode);
                        count++;
                        Console.WriteLine("\nelement enqueued");
                        return;
                    }
                    position++;
                }
            }
            queue.Insert(newNode);
            Console.WriteLine("\nelement enqueued");
            // Increment size of queue if element is enqueued
            count++;
        }

        public void Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("\nqueue is empty");
                return;
            }

            // If queue is not reversed the first element is the one with highest priority
            if (reverse % 2 == 0)
            {
                queue.DeleteAt(1);
                Console.WriteLine("\nelement dequeued");
            }

            // If queue is reversed the last element is of highest priority
            else
            {
                queue.DeleteAt(count);
                Console.WriteLine("\nelement dequeued");
            }
            // Decrement size of queue if element is dequeued
            count--;
        }

        public void Peek()
        {
            if (count == 0)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }

            // If queue is not reversed the first element is the one with highest priority
            if (reverse % 2 == 0)
            {
                var element = queue.ElementAtPosition(1);
                Console.WriteLine("\nItem with highest priority: ", element.value);
            }

            // If queue is reversed the last element is the one with highest priority
            else
            {
                var element = queue.ElementAtPosition(count);
                Console.WriteLine("\nItem with highest priority: ", element.value);
            }
        }

        public void GetHighestPriority()
        {
            if (count == 0)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            // If queue is not reversed the first element is the one with highest priority
            if (reverse % 2 == 0)
            {
                var element = queue.ElementAtPosition(1);
                Console.WriteLine("\nHighest priority "+element.priority);
            }
            // If queue is reversed the lstelement is the one with highest priority
            else
            {
                var element = queue.ElementAtPosition(count);
                Console.WriteLine("\nHighest priority " + element.priority);
            }
        }

        
        public void Center()
        {
            int size = Size();
            int mid;
            if (size == 0)
            {
                Console.WriteLine("Queue is empty\n");
            }
            else
            {
                mid = size / 2;
                int c = 0;
                foreach (var i in queue)
                {
                    if (c == mid)
                    {
                        Console.WriteLine("Priority: {0}, Value: {1}",i.priority,i.value);
                        break;
                    }
                    c += 1;
                }
                
            }
        }

        public int Size()
        {
            return count;
        }

        public bool Contains(T value)
        {
            int flag = 0;
            foreach (var i in queue)
            {
                if (i.value.Equals(value))
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reverse()
        {
            if (count == 0)
            {
                Console.WriteLine("\nQueue is Empty");
            }
            else
            {
                queue.Reverse();
                // Increment the reverse if the queue is reversed
                reverse++;
            }
        }


        public void Print()
        {
            if (count == 0)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Priority\tValue");
                foreach (var i in queue)
                {
                    Console.WriteLine(i.priority + "\t\t" + i.value);

                }
            }
        }

        public void Iterator()
        {
            if (count == 0)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
             
            MyLinkedList<QueueNode>.Enumerator enumerator = queue.GetEnumerator();
            Console.WriteLine("\nQueue [using Iterator]");
            Console.WriteLine("Priority\tValue");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.priority+"\t\t"+enumerator.Current.value);
            }
        }
    }
}