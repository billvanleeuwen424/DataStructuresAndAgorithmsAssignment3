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
            internal SO data;
        }

        private int count = 0;
        private Node front;
        private Node back;

        public CircularLinkedList() // constructor
        { front = back = null; }


        public void Enqueue(SO input)
        {
            if (front == null)  //list is empty
            {
                front = new Node();
                front.data = input;

                back = front;
            }

            else if (front.data.priority < input.priority)   //easy code to cut down on time. if the front of the queue has a lower priority than the input, put the input at the front.
            {
                Node oldFront = front;
                Node newFront = new Node();
                newFront.data = input;

                oldFront.previous = newFront;
                newFront.next = oldFront;
                newFront.previous = back;
                back.next = newFront;

                front = newFront;
            }

            else if (back.data.priority >= input.priority)   //easy code to cut down on time. if the back of the queue has a higher priority than the input, put this at the back.
            {
                Node oldBack = back;
                Node newBack = new Node();
                newBack.data = input;

                oldBack.next = newBack;
                newBack.next = front;
                front.previous = newBack;
                newBack.previous = oldBack;

                back = newBack;
            }

            else   //go through the regular motion of searching the list to find a proper location. shouldnt have a problem with infinite loops or messing with front or back, becuase of the last two ifs
            {
                Node temp = new Node();
                Node toInsert = new Node();
                toInsert.data = input;

                temp = back;
                bool found = false;
                while (!found)  //find a node with greater or equal priority to the node to be inserted
                {
                    temp = temp.previous;
                    if (temp.data.priority >= input.priority)
                    {
                        found = true;
                    }
                }

                Node behind = new Node();
                behind = temp.next;

                behind.previous = toInsert;
                toInsert.previous = temp;

                temp.next = toInsert;
                toInsert.next = behind;
            }
            count++;
        }

        /// <summary>
        /// removes the highest priority item on the list, ie the front element.
        /// 
        /// 1. if the front is empty, the list is empty. nothing is there to delete
        /// 2. if the back == front, there is only one element on the list, delete that one.
        /// 3. otherwise, remove the front element of the list, and change all the pointers and the front.
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("This list has no nodes to delete...");
                return default;
            }
            else if (back == front)//last item on list
            {
                Node toDelete = front;
                Node toReturn = toDelete;   //just for the sake of returning something
                toDelete = null;
                front = null;
                back = null;

                count--;

                return toReturn;
            }
            else
            {
                Node toDelete = front;
                Node newFront = toDelete.next;
                Node toReturn = toDelete;   //just for the sake of returning something

                
                newFront.previous = back;  //change the previous to the back

                back.next = newFront;
                newFront.previous = back;

                toDelete.next = null;
                toDelete.previous = null;
                toDelete = null; //delete the toDelete

                front = newFront;
                count--;

                return toReturn;
            }
        }

        public void printAll()
        {
            Node current = front;
            Console.WriteLine("\nprintall:");

            if (front == null)
            {
                Console.WriteLine("List is empty");
            }

            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("#{0} -- {1}", i, current.data);
                    current = current.next;
                }
            }
        }

        //O(1)
        //deletes all items in the list
        public void DeleteAll()
        {
            //clear the front and back. zero the count. The rest of the nodes are cut off and left to the garbage collector to deal with
            front = null;
            back = null;
            count = 0;
        }

    }
}
