using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje1
{
    internal class Program
    {
        /*
         (6 bodova) Napišite program koji će zatražiti od korisnika da unese 
        tri dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja (npr. 12,17,15 -> 17).
        */
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Unesi 3 troznamenkasta broja: ");
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if(a>=b && a>=c)
            {
                Console.WriteLine(a);
            }
            if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            if (c >= b && c >= a)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();


        }
    }
}
