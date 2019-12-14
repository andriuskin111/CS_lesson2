using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd2
{
    class Program
    {
        static void Main(string[] args)
        {
            int KintamasisA = 10;
            int KintamasisB = 2;
            (KintamasisA, KintamasisB) = (KintamasisB, KintamasisA);

            Console.WriteLine("{0}, {1}", KintamasisA, KintamasisB);
            Console.ReadLine();
        }

    }
}
