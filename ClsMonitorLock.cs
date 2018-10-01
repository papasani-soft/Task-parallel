using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_Parallel
{ 
    class ClsMonitorLock
    {
        static readonly object _object = new object();
        public static void PrintNumbers()
        {
            Monitor.Enter(_object);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(_object);
            }
        }
        //static void TestLock()
        //{
        //    lock (_object)
        //    {
        //        Thread.Sleep(100);
        //        Console.WriteLine(Environment.TickCount);
        //    }
        //}
         public static void CreateMain()
        {
            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(new ThreadStart(PrintNumbers));
                Threads[i].Name = "Child " + i;
            }
            foreach (Thread t in Threads)
            t.Start();
            Console.ReadLine();
        }
    }  
}
