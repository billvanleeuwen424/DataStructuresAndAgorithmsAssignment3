using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    /// <summary>
    /// a hash table for generics
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class HashTable<T>
    {
        private T[] hasharray;

        public HashTable(int size)
        { hasharray = new T[size]; }

        /// <summary>
        /// adds a value to the hash array, if a spot cant be found in 10 tries, spot will = -1, exception will be thrown.
        /// 
        /// O(1) insertion time. 
        /// Absoloute worst case, 10 operations. 
        /// best case, 1 operation.
        /// average case, 1-3 operations.
        /// 
        /// start a while loop, get the position from the function
        /// if the spot is null, insert it, otherwise start over
        /// </summary>
        /// <param name="value">string to be inserted</param>
        public void Add(T value)
        {
            int hashedvalue = hashkey(value); //send the value to the hasher to be hashed

            bool spotfound = false;
            int i = 1;
            int spot = -1;  //set to -1 to cause exception incase something goes wrong
            while (!spotfound)
            {
                spot = positionFunction(hashedvalue, i);
                if (hasharray[spot] == null)
                    spotfound = true;

                i++;

                if (i == 10) //if we have tried 10 times, just cut it.
                {
                    spot = -1;
                    spotfound=true;  //but spot not found
                }
            }

            try
            {
                hasharray[spot] = value;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("increase the size of the array. the load factor is too high to find a spot. Item was not added to the table.");
            }
        }

        /// <summary>
        /// this is almost identical to the add method.
        /// The only difference is it checks that the item at the array index is the same as the value.
        /// 
        /// O(1) search time
        /// Absoloute worst case, 10 operations. 
        /// best case, 1 operation.
        /// average case, 1-3 operations.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>-1 if not found.</returns>
        public int find(T value)
        {
            int hashedvalue = hashkey(value); //send the value to the hasher to be hashed

            bool itemfound = false;
            int i = 1;
            int spot = -1;  //set to -1 to cause exception incase something goes wrong
            while (!itemfound)
            {
                spot = positionFunction(hashedvalue, i);
                //stole the below statement from https://stackoverflow.com/questions/6480577/how-to-compare-values-of-generic-types
                //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.comparer-1.compare?view=net-5.0
                if (Comparer<T>.Default.Compare(value, hasharray[spot]) == 0)   
                    itemfound = true;

                i++;

                if (i == 10) //if we have tried 10 times, just cut it.
                {
                    spot = -1;
                    itemfound=true;  //but spot not found
                }
            }

            return spot;
        }
        public bool Find (T value)
        {
            if (this.find(value) >= 0) return true;
            else return false;
        }
        public static int hashkey(T value)
        {
           
            // if you want you can use a better hashing function here but that seems like it requires effort.
            return value.ToString().Length;
        }

        /// <summary>
        /// the quadratic probing function.
        /// currently set to 
        /// hash * i^2 % arraylength
        /// 
        /// ex
        /// hash = 5, arraylength = 100
        /// 
        /// i=1, 5 % 100 = 5
        /// i=2, 20 % 100 = 20
        /// i=3, 45 % 100 = 45
        /// i=4, 80 % 100 = 80
        /// i=5, 125 % 100 = 25
        /// etc
        /// 
        /// will repeat after a certain amount of time, depending on size of array.
        /// </summary>
        /// <param name="hashvalue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private int positionFunction(int hashvalue,int i)
        {
            return (hashvalue * (i * i) % hasharray.Length);
        }
    }
}
