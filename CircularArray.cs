using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Assignment3
{
   /// <summary>
   /// Circular array built with a queue structure.
   /// 
   /// queueFront - the index of the item at the front
   /// queueRear - the index of the next open position
   /// </summary>
   /// <typeparam name="T"></typeparam>
    public class CircularArray<T>
    {
        private SO[] array;
        private int queueFront;
        private int queueRear;

        private int count;

        // Basic Constructor 
        // Creates an array and initializes the front and rear
        // O(1) in time O (N) in size
        public CircularArray(int size)
        {
            array = new SO[size];
            queueFront = 0;
            queueRear = 0;
            count = 0;
        }


        /// <summary>
        /// adds to the back of the queue, no matter the objects priority
        /// </summary>
        /// <param name="value"></param>
        public void addBack(SO value)  //addBack is enqueue
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

        /// <summary>
        /// adds to queue according to priority
        /// O(N) where N is the distance we need to search for the position
        /// worst case, 2N where N is the array.Length
        /// best case O(1)
        /// </summary>
        /// <param name="anObject"></param>
        public void addToQueue(SO anObject)
        {
            if (count == array.Length)   //array is full, grow it
            {
                grow(array.Length * 2);
            }
            else    //there is at least one open position in the array
            {
                int j;  //position holder, used for the console writeline, and in the forloop
                if (count == 0) //if the array is empty
                {
                    j = queueFront;
                    array[queueFront] = anObject;
                }
                else    //if the array is not empty, but has space
                {
                    j = queueRear;
                    bool posFound = false;
                    while (!posFound)
                    {
                        j--;
                        if(j < 0)   //all items in array are lower priority. this goes first so that there isnt an array index exception
                        {
                            posFound = true;
                            j = queueFront;
                        }
                        else if (array[j] == null|| array[j].priority >= anObject.priority)  //if the object to be inserted has a higher priority than the one in the search. or if the spot is empty(just to stop stuff from breaking).
                        {
                            posFound = true;
                            j++; //step back one
                        }
                    }

                    for (int i = queueRear; i != j; i--)  //start at the end of the array, move each item to the right
                    {
                        if(i-1 < 0) //for the wrap
                        {
                            array[i] = array[array.Length-1];   //put the end element at 0
                            i = array.Length;   //start counting at the end of the array
                        }
                        else
                            array[i] = array[i - 1];
                    }

                    array[j] = anObject;    //assign the position
                }
                
                

                Console.WriteLine("{0} was added to position {1}", anObject, j);
                count++;
                queueRear++;

                if (queueRear % array.Length == 0 && queueRear != 0)    //wrap array to front if its at the end
                {
                    queueRear = 0;
                }
            }

        }
        
        /// <summary>
        /// deletes the highest priority item. ie the item at the front of the queue
        /// </summary>
        /// <returns>the item in which it is deleteing</returns>
        public SO removeFront()  
        {
            if (count == 0)
            {
                Console.WriteLine("Why the heck would you try to delete something from an empty array.");
                return default;
            }
            else
            {
                SO sample = array[queueFront];
                array[queueFront] = default;
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
        public SO getFront()
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
            Console.WriteLine("--------------------------\ndeleting all items from the old array\n-------------------------------------");
            SO[] tempArray = new SO[newsize];
            int precount = count;   //holds the count of the array before we started deleting
            for (int i = 0; i < precount; i++)   //load all the old elements into the array starting at index 0
            {
                tempArray[i] = removeFront();
            }
            queueFront = 0;
            queueRear = precount;
            count = precount;

            array = tempArray;

            Console.WriteLine("--------------------------\nAll items have been transfered to new array\n----------------------------------------");
        }

        /// <summary>
        /// deletes all items in the array, sets count and queue to zero
        /// </summary>
        public void DeleteAll()
        {
            int precount = count;   //holds the count of the array before we started deleting
            for (int i = 0; i < precount; i++)
            {
                removeFront();
            }
            queueFront = 0;
            queueRear = 0;
            count = 0;
        }

        /// <summary>
        /// prints all objects in the array, from front of the queue to the end
        /// controlls for wrapping
        /// </summary>
        public void PrintAll()
        {
            Console.WriteLine("\nprintall:");
            for(int i = queueFront; i != queueRear; i++)
            {
                if(i == array.Length)   //stop array from over indexing
                {
                    i = 0;
                }

                Console.WriteLine(array[i]);
            }
        }
    }
}
