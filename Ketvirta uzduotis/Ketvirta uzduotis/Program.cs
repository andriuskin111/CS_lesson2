using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketvirta_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string mokyklosPavadinimas;
            string kursoPabadinimas;
            int studentuSkaicius;
            DateTime kursoPradziosData = new DateTime(2019, 12, 10);
            DateTime kursoPabaigosData = new DateTime(2020, 2, 25);
          

            double dienuSkirtumas = (kursoPabaigosData - kursoPradziosData).TotalDays;
            double savaiciuSkaicius = dienuSkirtumas / 7;
            double dienuSkaiciusBeSavaitgaliu = savaiciuSkaicius * 4;

            Console.WriteLine("Iveskite mokyklos pavadinima");
            mokyklosPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite kursopavadinima");
            kursoPabadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite studentu skaiciu");
            studentuSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mokyklos pavadinimas: " + mokyklosPavadinimas);
            Console.WriteLine("Kurso pavadinimas: " + kursoPabadinimas);
            Console.WriteLine("Stdentu skaicius: " + studentuSkaicius);
            Console.WriteLine("Siandienos data: " + DateTime.Now.ToString());
            Console.WriteLine("Kurso pradzios data: " + kursoPradziosData);
            Console.WriteLine("Kurso pabaigos data: " + kursoPabaigosData);
            Console.WriteLine("Dienu skirtumas tarp kuso pradzios ir pabaigos: " + dienuSkirtumas);
            Console.WriteLine("Savaiciu skaicius: " + savaiciuSkaicius);
            Console.WriteLine("Darbo dienu skaicius: " + dienuSkaiciusBeSavaitgaliu);
            Console.ReadLine();
        }
    }
}
