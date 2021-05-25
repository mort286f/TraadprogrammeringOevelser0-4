using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrådprogrammeringOpgave4
{
    class Program
    {
        public static char ch = '*';

        public static void PrintChar()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
        }

        public static void ReadUserInput()
        {
            while (true)
            {

                ConsoleKeyInfo tempKey = Console.ReadKey();
                
                char key = tempKey.KeyChar;
                if(tempKey.Key != ConsoleKey.Enter)
                {
                    ch = key;
                }
            }
        }

        static void Main(string[] args)
        {
            Thread printer = new Thread(new ThreadStart(PrintChar));
            printer.Start();

            Thread reader = new Thread(new ThreadStart(ReadUserInput));
            reader.Start();
        }
    }
}
