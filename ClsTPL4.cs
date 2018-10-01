using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task_Parallel
{
    class ClsTPL4
    {
       public static void CreateMain()
        {
            //creating the task  
            Task<int> task1 = new Task<int>(() =>
            {
                int result = 1;

                for (int i = 1; i < 10; i++)
                    result *= i;

                return result;
            });

            //starting the task  
            task1.Start();

            //waiting for result - printing to the console  
            Console.WriteLine("Task result: {0}", task1.Result);

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
