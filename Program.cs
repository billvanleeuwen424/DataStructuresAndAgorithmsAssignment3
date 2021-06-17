using System;
using System.Diagnostics; // Required for stopwatch
//Your name here


namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {



            CircularArray<SO> priorityArray = new CircularArray<SO>(5);

            for(int i = 0;i < 100; i++)
            {
                SO tempso = new SO(SriRandom.GetRandom());  //returns a random ulong by my modifications
                priorityArray.addToQueue(tempso);
            }
            for(int i = 0; i < 50; i++)
            {
                priorityArray.removeFront();
            }for(int i = 0;i < 100; i++)
            {
                SO tempso = new SO(SriRandom.GetRandom());  //returns a random ulong by my modifications
                priorityArray.addToQueue(tempso);
            }
            for(int i = 0; i < 50; i++)
            {
                priorityArray.removeFront();
            }for(int i = 0;i < 100; i++)
            {
                SO tempso = new SO(SriRandom.GetRandom());  //returns a random ulong by my modifications
                priorityArray.addToQueue(tempso);
            }
            for(int i = 0; i < 50; i++)
            {
                priorityArray.removeFront();
            }for(int i = 0;i < 100; i++)
            {
                SO tempso = new SO(SriRandom.GetRandom());  //returns a random ulong by my modifications
                priorityArray.addToQueue(tempso);
            }
            for(int i = 0; i < 50; i++)
            {
                priorityArray.removeFront();
            }for(int i = 0;i < 100; i++)
            {
                SO tempso = new SO(SriRandom.GetRandom());  //returns a random ulong by my modifications
                priorityArray.addToQueue(tempso);
            }
            for(int i = 0; i < 50; i++)
            {
                priorityArray.removeFront();
            }for(int i = 0;i < 100; i++)
            {
                SO tempso = new SO(SriRandom.GetRandom());  //returns a random ulong by my modifications
                priorityArray.addToQueue(tempso);
            }
            for(int i = 0; i < 50; i++)
            {
                priorityArray.removeFront();
            }

            priorityArray.PrintAll();









            //CircularArray < SO> priorityArray = new CircularArray<SO>();
            //CircularLinkedList<SO> priorityLL = new CircularLinkedList<SO>();

            //SO sampleSO = new SO(0);
            //sampleSO.ToString();

            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();


            // in here is where you do the thing that's being timed

            /*
             write a simple tool to compare the performance of the two structures you implemented in “2” and “3”.  
            Your system is going to work like this -  you’re going to generate a random number between 1 and 11 (inclusive), call this variable n_events, 
            and then a second random number 0, or 1.  
            If the second number is 0, you dequeue n_events objects from the structure, if it’s 1, you enqueue that many (these simple objects are randomly generated).

            At the end of your simulation you should be able to report the largest size your priority queue ever reached, 
            the number of objects in your queue at the end, 
            and the total number of objects added or removed.
            
            An event is just that a Simple Object is generated, assigned a random priority (1-5 inclusive), 
            and enqueued, or that n objects are dequeued from the priority queue (and then discarded).  

            Note that you will need to deal with the possibility of attempting to dequeue from an empty list, in that case just return nothing or a null object and ignore it.  

            There are two ways to do this – either generate a fixed number of random events (and see which one is fastest) 
            or run for a fixed amount of time (say 10 seconds) and count how many you could accomplish.  Do both.   
            */


            //stopWatch.Stop();
            //TimeSpan ts = stopWatch.Elapsed;
            ////long tsticks = stopWatch.ElapsedTicks;
            //Console.WriteLine();

            //// Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime);

            ///*
            // * Hashtable code
            // * 
            // */
            //string[] demostrings = { "Srivastava", "Hurley", "Mitchell", "McConnell", "Feng", "Noorian", "Young",
            //    "Smith", "Northrop", "Andreau", "Reid", "Alam", "Addas", "Atkinson", "Hickson", "Aniag", "Patrick",
            //    "Subramanian", "Pollanen", "Bruder", "Beland", "Akaiso", "Hircock", "Erzurumluoglu", "Neels"};
            //Console.WriteLine("Hashmap Testign");
            //int size = 20;
            //HashTable<string> myhashtable = new HashTable<string>(size);
            //// You'll want to actually add things into myhashtable


            //Console.WriteLine("My name is: ___________________");// (please put your name in this statement)


        }
    }
}
