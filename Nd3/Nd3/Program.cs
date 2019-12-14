using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Iveskite pirma skaiciu");
            double PirmasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            double AntrasSkaicius = Convert.ToDouble(Console.ReadLine());

            if(PirmasSkaicius == AntrasSkaicius)
            {
                Console.WriteLine("Skaiciai yra lygus");
            }
            else
            {
                Console.WriteLine("Skaiciai yra nelygus");
            }

            Console.ReadLine();
            
        }

    }
}
