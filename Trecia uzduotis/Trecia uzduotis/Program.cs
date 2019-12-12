using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trecia_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string mokyklosPavadinimas;
            string kursoPabadinimas;
            int studentuSkaicius;
            DateTime.Today.ToString();

            Console.WriteLine("Iveskite mokyklos pavadinima");
            mokyklosPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite kursopavadinima");
            kursoPabadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite studentu skaiciu");
            studentuSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mokyklos pavadinimas: " + mokyklosPavadinimas);
            Console.WriteLine("Kurso pavadinimas: " + kursoPabadinimas);
            Console.WriteLine("Stdentu skaicius: " + studentuSkaicius);
            Console.WriteLine(DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
