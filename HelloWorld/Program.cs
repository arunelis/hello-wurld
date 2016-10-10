using System;
using System;
using System.Linq;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Program requires at least 1 argument");
                return;
            }

            var module = new HelloModule();

                Console.WriteLine(module.SayHello(args[0]));

            var nameLastname = new Homework();

                Console.WriteLine(nameLastname.SayNameLastname("AruNAs", "muRAsKa"));



            // tiem kas nori kazko sudetingesnio ANTRAS MODULIS: is teksto isrenka ir grazina daugiausiai kartu panaudota raide
            int mostOccurrence = -1;
            char mostOccurringChar = ' ';
            string charString = nameLastname.SayNameLastname("AruNAs", "muRAsKa").Trim();
            foreach (char currentChar in charString)
            {
                int foundCharOccreence = 0;
                foreach (char charToBeMatch in charString)
                {
                    if (currentChar == charToBeMatch)
                        foundCharOccreence++;
                }
                if (mostOccurrence < foundCharOccreence)
                {
                    mostOccurrence = foundCharOccreence;
                    mostOccurringChar = currentChar;
                }
            }
            Console.WriteLine(mostOccurringChar + ": " + mostOccurrence);

            Console.ReadLine();
        }
    }
}
