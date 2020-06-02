using System;
using System.Collections.Generic;


namespace ConsoleApp_Fibonacci
{
    class Program
    {

        static void Main(string[] args)
        {

            if (args.Length == 1)
            {
                try
                {
                    int numberOfElements = int.Parse(args[0]);

                    var fibonacci_string = "";


                    if (numberOfElements == 1)
                    {
                        fibonacci_string = "0";
                    }
                    else if (numberOfElements > 1)
                    {
                        List<int> fibonacci = new List<int>() { 0, 1 };

                        int i = 2;
                        while (i < numberOfElements)
                        {
                            fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                            i++;
                        }
                        fibonacci_string = string.Join(" ", fibonacci);
                    }




                    Console.WriteLine($"Fibonacci sequence for N={numberOfElements} elements:");
                    Console.WriteLine(fibonacci_string);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Argument isn't an integer");

                }


            }
            else
            {
                Console.WriteLine("Wrong number of arguments");
            }


            Console.ReadKey();

        }
    }
}
