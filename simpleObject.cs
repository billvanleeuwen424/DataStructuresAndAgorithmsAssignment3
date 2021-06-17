using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class SO : IComparable
    {
        public ulong ID;
        public double[] Data;
        private static int sizeofObject = 8191; //as per instructions
        public int priority;


        public int Priority
        {
            get { return priority; }
        }

        public override string ToString()
        {
            return "ID: " + ID.ToString() + ", priority: " + priority + ", " + "D[0]" + Data[0].ToString("G4");
            // return base.ToString();
        }

        /// <summary>
        /// generates a random priority
        /// </summary>
        /// <param name="tempID"></param>
        /// <param name="randPriority"></param>
        public SO(ulong tempID, bool randPriority=true)
        {
            ID = tempID;
            Data = new double[sizeofObject];
            for (int i = 0; i < sizeofObject; i++)
            {
                Data[i] = SriRandom.GetRandomDouble();
            }

            priority = Util.GetRandom(6);
        }

        /// <summary>
        /// inputs specified priority
        /// </summary>
        /// <param name="tempID"></param>
        /// <param name="tempPriority"></param>
        public SO(ulong tempID, int tempPriority)
        {
            ID = tempID;
            Data = new double[sizeofObject];
            for (int i = 0; i < sizeofObject; i++)
            {
                Data[i] = SriRandom.GetRandomDouble();
            }

            priority = tempPriority;
        }
        public int CompareTo(object obj)
        {
            SO b = obj as SO;
            if (obj == null) return 1;
            //A more elegant way to implement the next five lines is:
            // return this.value.CompareTo(b.value);
            if (ID < b.ID)
                return -1;
            if (ID > b.ID)
                return 1;
            else return 0;
        }
    }
}
