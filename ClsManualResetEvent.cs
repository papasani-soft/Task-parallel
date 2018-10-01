using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_Parallel
{
    class ClsManualResetEvent
    {
        static ManualResetEvent objAuto = new ManualResetEvent(false);
        public static void CreateMainMethod()
        {
            new Thread(SomeMethod).Start();
            Console.ReadLine();
            objAuto.Set();
        }
        static void SomeMethod()
        {
            Console.WriteLine("starting....");
            objAuto.WaitOne();
            Console.WriteLine("Finishing....");
        }
    }
}
