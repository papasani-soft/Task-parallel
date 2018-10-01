using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_Parallel
{
    public class TestSemaphoreSlim
    {
        private static SemaphoreSlim _semaSlim = new SemaphoreSlim(3);
        public static void DoWork(object threadId)
        {
            Console.WriteLine("Thread {0} is in queue of SemaphoreSlim. Count: {1}", threadId, _semaSlim.CurrentCount);
            _semaSlim.Wait();
            Console.WriteLine("Thread {0} has entered in SemaphoreSlim. Count: {1}", threadId, _semaSlim.CurrentCount);
            Thread.Sleep(1000);
            _semaSlim.Release();
            Console.WriteLine("Thread {0} has exited from SemaphoreSlim. Count: {1}", threadId, _semaSlim.CurrentCount);
        }
    }
    class ClsSemaphoreslim
    {
        public static void CreateMain()
        {
            Console.Title = "SemaphoreSlim Demo";
            for (int i = 1; i <= 5; i++)
            {
                new Thread(TestSemaphoreSlim.DoWork).Start(i);
            }
        }
    }
}
