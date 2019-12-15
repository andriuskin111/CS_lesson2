using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite miesto pavadinima");
            string miestoPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite gatves pavadinima");
            string gatvesPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite namo numeri");
            string namoNumeris = Console.ReadLine();
            Console.WriteLine("Iveskite statymo pradzios data (pvz.: 2018/10/10)");
            DateTime ivestiStatymoPradziosMetai = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite pastatymo data (pvz.: 2018/10/10)");
            DateTime ivestiPastatymoMetai = DateTime.Parse(Console.ReadLine());

            RodytiDuomenis(miestoPavadinimas, gatvesPavadinimas, namoNumeris);

            Console.ReadLine();

            void RodytiDuomenis(string aMiestoPavadinimas, string aGatvesPavadinimas, string aNamoNumeris)
            {
                Console.WriteLine("Miestas: {0}", aMiestoPavadinimas, aGatvesPavadinimas, aNamoNumeris);
                Console.WriteLine("Gatve: {1}", aMiestoPavadinimas, aGatvesPavadinimas, aNamoNumeris);
                Console.WriteLine("Namo Nr: {2}", aMiestoPavadinimas, aGatvesPavadinimas, aNamoNumeris);
                Console.WriteLine("Statymo pradzios metai: {0}", ivestiStatymoPradziosMetai);
                Console.WriteLine("Pastatymo metai: {0}", ivestiPastatymoMetai);
                Console.WriteLine("Statybos laikotarpis metais: {0:0.0}", (ivestiPastatymoMetai - ivestiStatymoPradziosMetai).TotalDays / 365);
            }
        }
    }
}
