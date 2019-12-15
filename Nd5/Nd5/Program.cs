using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio ilgi");
            double StaciakampioIlgis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio ploti");
            double StaciakampioPlotis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("staciakampio plotas yra: " + (StaciakampioIlgis * StaciakampioPlotis));
            Console.ReadLine();
        }
    }
}
