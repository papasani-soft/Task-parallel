using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task_Parallel
{
    class ClsTPL3
    {
      public static void CreateMain()
        {
            //Action delegate  
            Task task1 = new Task(new Action<object>(HelloConsole), "Task 1");

            //anonymous function  
            Task task2 = new Task(delegate (object obj)
            {
                HelloConsole(obj);
            }, "Task 2");

            //lambda expression  
            Task task3 = new Task((obj) => HelloConsole(obj), "Task 3");

            task1.Start();
            task2.Start();
            task3.Start();

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
        static void HelloConsole(object message)
        {
            Console.WriteLine("Hello: {0}", message);
        }
    }
}
