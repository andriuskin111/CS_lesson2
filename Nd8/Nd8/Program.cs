using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            string Vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde");
            string Pavarde = Console.ReadLine();
            Console.WriteLine("{0} {1}", Vardas, Pavarde);
            Console.ReadLine();
        }
    }
}
