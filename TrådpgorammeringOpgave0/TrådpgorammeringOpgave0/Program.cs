using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TrådpgorammeringOpgave0
{
    class Program
    {
        //Function that the created thread uses
        public void WorkThreadFunction(object threadName)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
                Console.WriteLine("Thread name: " + threadName);
            }
        }

        static void Main(string[] args)
        {
            //Creates a new instance of the Program class so the WorkThreadFunction method can be created
            Program pg = new Program();
            string nameOne = "Thread nr. 1";
            string nameTwo = "Thread nr. 2";


            //Creates a new thread that takes the WorkThreadFunction as its parameter
            Thread thread1 = new Thread(new ParameterizedThreadStart(pg.WorkThreadFunction));
            thread1.Name = "Thread nr. 1";

            Thread thread2 = new Thread(new ParameterizedThreadStart(pg.WorkThreadFunction));
            thread2.Name = "Thread nr. 2";

            //Creates and starts the thread
            thread1.Start(nameOne);
            thread2.Start(nameTwo);
            Console.Read();
        }
    }
}
