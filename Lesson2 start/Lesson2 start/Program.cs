using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_start
{
    class Program
    {
        static void Main(string[] args)
        {
            double pirmasSkaicius;
            double antrasSkaicius;


            Console.WriteLine("Iveskite pima skaiciu");
            pirmasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            antrasSkaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaiciu suma yra: " + (pirmasSkaicius + antrasSkaicius));
            Console.WriteLine("Skaiciu skirtumas yra: " + (pirmasSkaicius - antrasSkaicius));
            Console.WriteLine("Skaiciu sandauga yra: " + (pirmasSkaicius * antrasSkaicius));
            Console.WriteLine("Skaiciu dalyba yra: " + (pirmasSkaicius / antrasSkaicius));
            Console.ReadLine();
        }
    }
}
