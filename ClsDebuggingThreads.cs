using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_Parallel
{
    class ClsDebuggingThreads
    {
        static int j = 0;
        static void MyMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                j++;
              
                Thread.Sleep(5000);
            }
        }
        public static void CreateMain()
        {
            Thread one = new Thread(MyMethod);
            one.Name = "one";
            Thread two = new Thread(MyMethod);
            two.Name = "two";
            one.Start();
            two.Start();
            Console.Read();
        }
    }
}

