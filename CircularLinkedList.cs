using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{

    class CircularLinkedList<T>
    {
        internal class Node
        {
            internal Node next;
            internal Node previous;
            internal T data;

        }

        private Node front;
        private Node back;
        public CircularLinkedList() // constructor
        { front = back = null; }


        public void enqueue(T input, int inputPriority)
        {
            // adds an element based on priority.
            // Items with equal priority should be FIFO, but higher priorty should come first (so priority 5 jumps ahead of priority 4)
        }
        // adds an element to the tail of the queue
        public T dequeue()
        {
            T temp = front.data; // 

            return temp;

        }
        public void printAll()
        {
            Node current = front;
            while (current.next != null)// you'll need an extra condition here for a circular LL
                Console.WriteLine(current.data.ToString());
        }
        public void deleteAll()
        {
            // dequeue all elements.
        }

    }
}
