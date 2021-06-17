using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class HashTable<T>
    {
        private T[] hasharray;

        public HashTable(int size)
        { hasharray = new T[size]; }

        public void Add(T value)
        {

            // this is where insertion goes
            // should use the method hashkey to generate the key/index 
            // remember to account for quadratic probing
        }
        private int find(T value)
        {
            //returns the index the item is found at, or -1 if it isn't found
            //
            return -1;
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
    }
}
