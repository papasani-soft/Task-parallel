using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Parallel
{
    class ClsThreadPooling
    {
        private static void RunMillionIterations()
        {
            string x = "";
            for (int i = 0; i < 100000; i++)
            {
                x = x + "s";
            }
        }
        public static void CreateMain()
        {
            //Thread o1 = new Thread(RunMillionIterations);
            //o1.Start();
            Parallel.For(0,10000,x=>RunMillionIterations());
            Console.Read();
        }
    }
}
