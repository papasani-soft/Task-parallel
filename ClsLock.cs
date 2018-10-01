using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_Parallel
{
    class ClsLock
    {
        static readonly object _object = new object();
        static void TestLock()
        {
            lock (_object)
            {
                Thread.Sleep(100);
                Console.WriteLine(Environment.TickCount);
            }
        }
        public  static void CreateMainMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadStart start = new ThreadStart(TestLock);
                new Thread(start).Start();
            }
            Console.ReadLine();
        }
    }   
}
