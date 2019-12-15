using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            double skaicius = Convert.ToDouble(Console.ReadLine());

            Palyginti(skaicius);

            Console.WriteLine("Skaicius mazesnis uz 0: " + Palyginti(skaicius));
            Console.ReadLine();

            bool Palyginti(double aSkaicius)
            {
                if(aSkaicius < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
