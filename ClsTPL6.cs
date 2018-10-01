using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Parallel
{
    class ClsTPL6
    {
        static void Workload()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task - iteration {0}", i);
                //sleeping for 1 second  
                Thread.Sleep(1000);
            }
        }
      public  static void CreateMain()
        {
            //creating and starting a simple task  
            Task task = new Task(new Action(Workload));
            task.Start();

            //waiting for the task  
            Console.WriteLine("Waiting for task to complete.");
            task.Wait();//Wait() method you can wait until a single task has completed
            Console.WriteLine("Task Completed.");

            //creating and starting another task             
            task = new Task(new Action(Workload));
            task.Start();
            Console.WriteLine("Waiting 2 secs for task to complete.");
            task.Wait(2000);
            Console.WriteLine("Wait ended - task completed.");

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
