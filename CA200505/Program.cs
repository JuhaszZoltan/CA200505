using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200505
{
    class Program
    {
        static List<Palinka> palinkak;
        static Random rnd = new Random();
        static void Main()
        {
            FeltoltRandomPalinkakkal();
            F01();
            F02();
            Console.ReadKey();
        }

        private static void F02()
        {
            int bev = 0;


            for (int i = 0; i < 50; i++)
            {
                var p = palinkak[rnd.Next(palinkak.Count)];

                bev += (p.Mennyiseg / 2) * p.Ar;
                p.Mennyiseg /= 2;
            }

            Console.WriteLine($"Ennyi bevételem lett: {bev}");
            F01();
        }

        private static void F01()
        {
            float s = 0;

            foreach (var p in palinkak)
            {
                s += p.Mennyiseg;
            }

            Console.WriteLine($"Összesen {s / 10} liter pálinkánk van!");
        }

        private static void FeltoltRandomPalinkakkal()
        {
            palinkak = new List<Palinka>();

            string[] gyumolcsok = { "szilva", "dió", "körte", "meggy", "cseresznye", "alma" };
            for (int i = 0; i < 20; i++)
            {
                palinkak.Add(new Palinka()
                {
                    Fok = rnd.Next(30, 88),
                    Gyumolcs = gyumolcsok[rnd.Next(gyumolcsok.Length)],
                    Mennyiseg = rnd.Next(51),
                    Ev = rnd.Next(2000, DateTime.Now.Year + 1),
                    Ar = rnd.Next(50, 1001),
                });
            }
        }
    }
}
