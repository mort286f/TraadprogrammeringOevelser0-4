using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrådprogrammeringOpgave1
{
    class Program
    {
        public static void ThreadOneWriter()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
                Thread.Sleep(1000);
            }
        }

        public static void ThreadTwoWriter()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde...");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread threadOne = new Thread(new ThreadStart(ThreadOneWriter));
            threadOne.Start();

            Thread threadTwo = new Thread(new ThreadStart(ThreadTwoWriter));
            threadTwo.Start();

            Console.Read();
        }
    }
}
