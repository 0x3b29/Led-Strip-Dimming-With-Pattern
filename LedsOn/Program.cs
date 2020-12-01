using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLeds = 10;
            float ledsOnPercentage = 0.10f;
            float perfectLedsOn = totalLeds * ledsOnPercentage; 
            float factorOn = totalLeds / perfectLedsOn;

            Console.WriteLine("Total Leds: " + totalLeds);
            Console.WriteLine("On Percentage: " + ledsOnPercentage);
            Console.WriteLine("Perfect Leds On/Off: " + perfectLedsOn + "/" + (totalLeds - perfectLedsOn));
            Console.WriteLine("Factor On: " + factorOn);
            Console.Write("Pattern: ");

            float lastLedOn = 0;

            int totalLedsOn = 0;
            int totalLedsOff = 0;

            for (int i = 0; i < totalLeds; i++)
            {
                if (i + 1 >= lastLedOn + factorOn)
                {
                    lastLedOn += factorOn;
                    totalLedsOn++;
                    Console.Write("X");
                }
                else
                {
                    totalLedsOff++;
                    Console.Write("0");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total Leds On/Off: " + totalLedsOn + "/" + totalLedsOff);

            Console.ReadLine();
        }
    }
}
