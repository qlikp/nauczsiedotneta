using System;
using System.Linq;


namespace LaczenieIntow
{
    class Program
    {
        static void Main(string[] args)
        {

            var correctArgs = args.Where(n => int.TryParse(n, out int k));

            if (correctArgs.Count() >1 )
            {


                Numbers2 liczby2 = new Numbers2(correctArgs.ToArray());


                Console.WriteLine($"Liczba max: {liczby2.maxNumber}");
                Console.WriteLine($"Liczba min: {liczby2.minNumber}");

                               

            }
            else
            {
                Console.WriteLine("Za mało argumentów");
            }

            Console.ReadKey();

        }
    }
}
