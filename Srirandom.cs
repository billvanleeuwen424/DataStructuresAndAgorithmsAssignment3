using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// 
///  You shouldn't need to touch anything in this code
///  
/// 
/// 
/// 
/// </summary>
namespace Assignment3
{
    // The built in way
    public static class Util // This used the built in C# RNG.  
    {
        private static Random rnd = new Random();
        public static int GetRandom()
        {
            return rnd.Next(9999);
        }

        /// <summary>
        /// addition to sris random utility, returns a random integer up to the inputted amount
        /// </summary>
        /// <param name="upto"></param>
        /// <returns></returns>
        public static int GetRandom(int upto)
        {
            return rnd.Next(upto);
        }

    }
    public class SriRandom  // Switched to a faster XorShift RNG based on some code I pillaged from the web
    {
        private static XorShiftRandom sriRnd = new XorShiftRandom();

        //public static int GetRandom()
        //{
        //    return sriRnd.NextInt32();
        //}
        public static ulong GetRandom()
        {
            return (ulong)sriRnd.NextInt64();
        }
        public static double GetRandomDouble()
        {
            return sriRnd.NextDouble();
        }

    }
}
