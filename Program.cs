using System;
using System.Diagnostics; // Required for stopwatch
//Your name here


namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            //CircularArray<SO> priorityArray = new CircularArray<SO>(1);
            //CircularLinkedList<SO> priorityLL = new CircularLinkedList<SO>();

            //SO sampleSO = new SO(0);
            //sampleSO.ToString();

            //int runcount = 100000;

            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();



            //int largestcount = 0;
            //int n_eventscounter = 0;
            //while(stopWatch.ElapsedMilliseconds < 60000)    //one minute
            //{
            //    int n_events = Util.GetRandom(12);  //generates from 0-11
            //    int flipper = Util.GetRandom(2); //generates from 0-1

            //    for (int j = 0; j < n_events; j++)
            //    {
            //        if (flipper == 1)
            //        {
            //            SO tempso = new SO(SriRandom.GetRandom());
            //            priorityArray.Enqueue(tempso);
            //        }
            //        else
            //        {
            //            priorityArray.Dequeue();
            //        }
            //    }
            //    if (priorityArray.count > largestcount)
            //        largestcount = priorityArray.count;

            //    n_eventscounter += n_events;
            //}

            //stopWatch.Stop();
            //TimeSpan ts = stopWatch.Elapsed;
            //long tsticks = stopWatch.ElapsedTicks;
            //Console.WriteLine();

            ////// Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime);
            //Console.WriteLine("{0} instances of enqueuing or dequeueing n_events to an array", runcount);
            //Console.WriteLine("Current array size: {0} -- number of events: {1} -- largest size of array: {2}", priorityArray.count, n_eventscounter, largestcount);


            //Stopwatch stopWatch2 = new Stopwatch();
            //stopWatch2.Start();

            //int largestcount2 = 0;
            //int n_eventscounter2 = 0;
            //while (stopWatch2.ElapsedMilliseconds < 60000)    //one minute
            //{
            //    int n_events2 = Util.GetRandom(12);  //generates from 0-11
            //    int flipper2 = Util.GetRandom(2); //generates from 0-1

            //    for (int j = 0; j < n_events2; j++)
            //    {
            //        if (flipper2 == 1)
            //        {
            //            SO tempso = new SO(SriRandom.GetRandom());
            //            priorityLL.Enqueue(tempso);
            //        }
            //        else
            //        {
            //            priorityLL.Dequeue();
            //        }
            //    }
            //    if (priorityLL.count > largestcount2)
            //        largestcount2 = priorityLL.count;

            //    n_eventscounter2 += n_events2;
            //}

            //stopWatch2.Stop();
            //TimeSpan ts2 = stopWatch2.Elapsed;
            //long tsticks2 = stopWatch2.ElapsedTicks;
            //Console.WriteLine();

            ////// Format and display the TimeSpan value.
            //string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime2);
            //Console.WriteLine("{0} instances of enqueuing or dequeueing n_events to a list", runcount);
            //Console.WriteLine("Current list size: {0} -- number of events: {1} -- largest size of list: {2}", priorityLL.count, n_eventscounter2, largestcount2);


            /*
             * Hashtable code
             * 
             */
            //notes.
            //a 20 size array failed at 60% capacity.
            //a 40 size array failed at %35 capacity.
            //an 80 size array failed at the last value, 30% capactiy
            //a 100 size array works
            string[] demostrings = { "Srivastava", "Hurley", "Mitchell", "McConnell", "Feng", "Noorian", "Young",
                "Smith", "Northrop", "Andreau", "Reid", "Alam", "Addas", "Atkinson", "Hickson", "Aniag", "Patrick",
                "Subramanian", "Pollanen", "Bruder", "Beland", "Akaiso", "Hircock", "Erzurumluoglu", "Neels"};
            Console.WriteLine("Hashmap Testing\n");
            int size = 100;
            HashTable<string> myhashtable = new HashTable<string>(size);

            foreach(string i in demostrings)
            {
                myhashtable.Add(i);
            }


            foreach(string i in myhashtable)
            {
                Console.WriteLine("{0}",i);
            }

            Console.WriteLine("My name is: William Van Leeuwen");// (please put your name in this statement)
        }
    }
}
