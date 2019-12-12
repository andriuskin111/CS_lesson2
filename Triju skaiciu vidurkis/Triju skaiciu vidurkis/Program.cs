using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triju_skaiciu_vidurkis
{
    class Program
    {
        static void Main(string[] args)
        {
            double pirmasSkaicius;
            double antrasSkaicius;
            double treciasSkaicius;

            Console.WriteLine("Iveskite pirma skaiciu");
            pirmasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite pirma skaiciu");
            antrasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite pirma skaiciu");
            treciasSkaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaiciu vidurkis yra: " + ((pirmasSkaicius + antrasSkaicius + treciasSkaicius) / 3));
            Console.ReadLine();
        }
    }
}
