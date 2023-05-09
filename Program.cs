using System;

namespace Application
{

    class Program
    {
        static void Main()
        {
            //Outputter uden at lave en ny linje, som gør at jeg kan skrive mit navn på samme linje.
            Console.Write("Giv mig dit fornavn: ");
            //Asks you for a text-based input and adds it to the string "navn"
            string navn = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            //Asks you for your age. \n will make a new line. 
            Console.Write("Hvor gammel er du?\nGiv mig din alder: ");
            //Asks you for your age and adds it to the string "alder"
            string alder = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey {0}! Min processor er også {1} gammel! Nice!", navn, alder);
            Console.ReadKey();
        }
    }
}