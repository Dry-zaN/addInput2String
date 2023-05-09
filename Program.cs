namespace Application
{

    class Program
    {
        static void Main()
        {
            string navn;
            int alder;
            //Outputter uden at lave en ny linje, som gør at jeg kan skrive mit navn på samme linje.
            Console.Write("Giv mig dit fornavn: ");
            //Asks you for a text-based input and adds it to the string "navn"
            navn = Console.ReadLine();
            if (navn.Length == 0)
            {
                Console.WriteLine("Du har ikke indtastet noget\nProgrammet lukker næste gang du taster.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine();
            Console.Clear();
            //Asks you for your age. \n will make a new line. 
            Console.Write("Hvor gammel er du?\nGiv mig din alder: ");
            //Asks you for your age and converts the input to Int32 before adding it to the int "alder" 
            alder = Convert.ToInt32(Console.ReadLine());
            if (alder <0 || alder == 0)
            {
                Console.WriteLine("You are wrong my friend.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey {0}! Min processor er også {1} gammel! Nice!", navn, alder);
            Console.ReadKey();
        }
    }
}
