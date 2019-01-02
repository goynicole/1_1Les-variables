using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            double AB, BC, CA =0;
            Console.WriteLine("valeur de BC");
            double.TryParse(Console.ReadLine(), out BC);
            Console.WriteLine("valeur de CA");
            double.TryParse(Console.ReadLine(), out CA);
            Console.ReadLine();
            AB = Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(CA, 2));
            Console.WriteLine("longueur de" + AB);
            Console.ReadKey();
        }
    }
}
