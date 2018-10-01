using System;

namespace Task_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter program no. to execute ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ClsLock.CreateMainMethod();
                    break;
                case 2:
                    ClsMonitorLock.CreateMain();
                    break;
                case 3:
                    ClsSemaphore.CreateMain();
                    break;
                case 4:
                    ClsSemaphoreslim.CreateMain();
                    break;
                case 5:
                    ClsAutoResetEvent.CreateMainMethod();
                    break;
                case 6:
                    ClsManualResetEvent.CreateMainMethod();
                    break;
                case 7:
                    ClsDebuggingThreads.CreateMain();
                    break;
                case 8:
                    ClsThreadPooling.CreateMain();
                    break;
                case 9:
                    ClsTPL.CreateMain();
                    break;
                case 10:
                    ClsTPL2.CreateMain();
                    break;
                case 11:
                    ClsTPL3.CreateMain();
                    break;
                case 12:
                    ClsTPL4.CreateMain();
                    break;
                case 13:
                    ClsTPL5.CreateMain();
                    break;
                case 14:
                    ClsTPL6.CreateMain();
                    break;
                case 15:
                    ClsTPL7.CreateMain();
                    break;
                case 16:
                    ClsTPL8.CreateMain();
                    break;
                case 17:
                    ClsTPL8.CreateMain();
                    break;
                case 18:
                    ClsTPL9.CreateMain();
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
