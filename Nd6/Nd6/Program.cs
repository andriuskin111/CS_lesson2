using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool eiluteTuscia;
            Console.WriteLine("Iveskite betkoki teksta");
            string tekstas = Console.ReadLine();

            if(tekstas != "")
            {
                eiluteTuscia = false;
            }
            else
            {
                eiluteTuscia = true;
            }

            Console.WriteLine(eiluteTuscia);
            Console.ReadLine();

        }
    }
}
