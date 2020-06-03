using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaczenieIntow
{
    class Program
    {
        static void Main(string[] args)
        {




            List<string> lista = new List<string>();

            Numbers liczby = new Numbers(args);


            Console.WriteLine($"Max: {liczby.maxInt}");
            Console.WriteLine($"Min: {liczby.minInt}");
            Console.ReadKey();

        }
    }
}
