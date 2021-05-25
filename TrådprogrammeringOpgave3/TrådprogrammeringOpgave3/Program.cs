using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrådprogrammeringOpgave3
{
    class Program
    {
        public void WriteTemperature()
        {
            Random rndm = new Random();
            int alarmTempCount = 0;
            while (alarmTempCount < 3)
            {
                int randomTemp = rndm.Next(-20, 120);

                if (randomTemp < 0 || randomTemp > 100)
                {
                    Console.WriteLine("Temperaturen lå uden for den tilladte interval! Temperaturen var: " + randomTemp);
                    alarmTempCount++;
                    Console.WriteLine("Alarm aktiveret! Alarm count: " + alarmTempCount);
                }

                else
                {
                    Console.WriteLine("Temperatur: " + randomTemp);
                }
                Thread.Sleep(2000);
            }

            Console.WriteLine("Alarm-tråd ramte 3 ikke tilladte intervaller!");
        }

        static void Main(string[] args)
        {
            Program pg = new Program();
            Thread threadOne = new Thread(new ThreadStart(pg.WriteTemperature));
            threadOne.Start();

            while(threadOne.IsAlive)
            {
                Console.WriteLine("Tråd kører..");
                Thread.Sleep(10000);
            }

            if(!threadOne.IsAlive)
            {
                Console.WriteLine("Tråd termineret!");
            }

            Console.Read();
        }
    }
}
