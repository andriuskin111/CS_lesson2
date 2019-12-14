using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            double PirmasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            double AntrasSkaicius = Convert.ToDouble(Console.ReadLine());

            PirmasSkaicius++;
            AntrasSkaicius--;

            Console.WriteLine("Pirmas skaicius + 1: {0}, Antras skaicius - 1: {1}", PirmasSkaicius, AntrasSkaicius);
            Console.ReadLine();
        }
    }
}
