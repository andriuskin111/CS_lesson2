using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nd9
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
            int namoNumeris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pastatymo data (pvz.: 2019/10/10)");
            DateTime ivestiPastatymoMetai = DateTime.Parse(Console.ReadLine());

            RodytiDuomenis(miestoPavadinimas, gatvesPavadinimas, namoNumeris);

            Console.ReadLine();

            void RodytiDuomenis(string aMiestoPavadinimas, string aGatvesPavadinimas, int aNamoNumeris)
            {
                Console.WriteLine("Miestas: {0}", aMiestoPavadinimas, aGatvesPavadinimas, aNamoNumeris);
                Console.WriteLine("Gatve: {1}", aMiestoPavadinimas, aGatvesPavadinimas, aNamoNumeris);
                Console.WriteLine("Namo Nr: {2}", aMiestoPavadinimas, aGatvesPavadinimas, aNamoNumeris);
                Console.WriteLine("Pastatymo metai: {0}", ivestiPastatymoMetai);
            }
        }
    }
}
