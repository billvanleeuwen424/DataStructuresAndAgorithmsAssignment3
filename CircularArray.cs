using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Assignment3
{
   /// <summary>
   /// Circular array built with a queue structure.
   /// </summary>
   /// <typeparam name="T"></typeparam>
    public class CircularArray<T>
    {
        private T[] array;
        private int queueFront;
        private int queueRear;

        private int count;

        // Basic Constructor 
        // Creates an array and initializes the front and rear
        // O(1) in time O (N) in size
        public CircularArray(int size)
        {
            array = new T[size];
            queueFront = 0;
            queueRear = 0;
            count = 0;
        }


        public void addBack(T value)  //addBack is enqueue
        {
            if (count == array.Length)   //array is full, grow it
            {
                grow(array.Length * 2);
            }
            else    //there is at least one open position in the array
            {

                array[queueRear] = value;
                Console.WriteLine("{0} was added to position {1}", value, queueRear);
                count++;
                queueRear++;

                if (queueRear % array.Length == 0 && queueRear != 0)    //wrap array to front if its at the end
                {
                    queueRear = 0;
                }
            }
        }

        public T removeFront()  //removeFront is dequeue
        {
            if (count == 0)
            {
                Console.WriteLine("Why the heck would you try to delete something from an empty array.");
                return default;
            }
            else
            {
                T sample = array[queueFront];
                array[queueFront] = default(T);
                count--;
                Console.WriteLine("{0} was deleted", sample);

                if (queueFront + 1 == array.Length)
                    queueFront = 0;
                else
                    queueFront++;

                return sample;
            }
        }

        // Just returns the front element O(1)
        public T getFront()
        {
            if (count == 0)
            {
                Console.WriteLine("theres nothing to get from an empty array.");
                return default;
            }
            else
            {
                return array[queueFront];
            }

        }
        // Same old Grow, bit hard to know where to use it if at all though...
        // O(N)
        public void grow(int newsize)
        {
            T[] tempArray = new T[newsize];
            int precount = count;   //holds the count of the array before we started deleting
            for (int i = 0; i < precount; i++)   //load all the old elements into the array starting at index 0
            {
                tempArray[i] = removeFront();
            }
            queueFront = 0;
            queueRear = precount;
            count = precount;

            array = tempArray;
        }
    }
}
