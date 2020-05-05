using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200505
{
    class Program
    {
        static void Main()
        {
            var p = new Palinka()
            {
                Fok = 45,
                Gyumolcs = "szilva",
            };

            Console.WriteLine($"Ez egy {p.Gyumolcs} pálinka, ami {p.Fok}-os!");





            Console.ReadKey();
        }
    }
}
