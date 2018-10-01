using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_Parallel
{
    public class TestSemaphore
    {
        private static Semaphore _sema = new Semaphore(3, 3);
        private static int _count = 0;
        public static void DoWork(object threadId)
        {
            Console.WriteLine("Thread {0} is in queue of Semaphore. Count: {1}", threadId, _count);
            _sema.WaitOne();
            _count++;
            Console.WriteLine("Thread {0} has entered in Semaphore. Count: {1}", threadId, _count);
            Thread.Sleep(1000);
            _count--;
            _sema.Release();
            Console.WriteLine("Thread {0} has exited from Semaphore. Count: {1}", threadId, _count);
        }
    }
    class ClsSemaphore
    {
        public static void CreateMain()
        {
            Console.Title = "Semaphore Demo";
            for (int i = 1; i <= 5; i++)
            {
                new Thread(TestSemaphore.DoWork).Start(i);
            }
        }
    }
}
