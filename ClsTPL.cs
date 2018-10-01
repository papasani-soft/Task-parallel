using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task_Parallel
{
    class ClsTPL
    {
        public static void CreateMain()
        {
            //Action delegate  
            Task task1 = new Task(new Action(HelloConsole));

            //anonymous function  
            Task task2 = new Task(delegate
            {
                HelloConsole();
            });

            //lambda expression  
            Task task3 = new Task(() => HelloConsole());

            task1.Start();
            task2.Start();
            task3.Start();
       
            Console.ReadKey();
        }
        static void HelloConsole()
        {
            Console.WriteLine("Hello Task");
        }
    }
}
