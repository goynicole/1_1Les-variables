using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            double rayon = 0;
            Console.WriteLine("le rayon est de");
            double.TryParse(Console.ReadLine(), out rayon);

            Console.WriteLine("Le rayon du cercle de" + rayon + " a un périmétre de" + (2 * Math.PI * rayon));
            Console.WriteLine("Le rayon du cercle de" + rayon + " a une surface de" + (Math.PI * (Math.Pow(rayon, 2))));
        }
    }
}
