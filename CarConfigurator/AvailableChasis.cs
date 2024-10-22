using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConfigurator
{
    public class AvailableChasis
    {
        public int Chasis()
        {
            Console.WriteLine("Welcome!!\n" +
                "This is basic car configurator\n" +
                "" +
                "For starter choose your desired chasis:\n");

            Console.WriteLine("1.Sedan/Saloon\n");
            Console.WriteLine("        ____________");
            Console.WriteLine("       //  ||  ||  \\ \\");
            Console.WriteLine(" _____//___||__||___\\ \\__");
            Console.WriteLine(" )  _    -    -  _    -o|");
            Console.WriteLine(" |_/ \\__________/ \\_____|");
            Console.WriteLine("   \\_/          \\_/    ");


            Console.WriteLine("2.Wagon/Tourer:\n");
            Console.WriteLine("         ___________________");
            Console.WriteLine("        //  ||  ||   |      |");
            Console.WriteLine(" _____ //___||__||___|______|");
            Console.WriteLine(" )  _      -    -    _    o-|");
            Console.WriteLine(" |_/ \\______________/ \\_____|");
            Console.WriteLine("   \\_/              \\_/  ");





            Console.WriteLine("3.Hatchback/Compact:\n");
            Console.WriteLine("         ____________");
            Console.WriteLine("        //  ||  ||   |");
            Console.WriteLine("  _____//___||__||___|");
            Console.WriteLine(" )  _     -    -  _ o|");
            Console.WriteLine(" |_/ \\___________/ \\_|");
            Console.WriteLine("   \\_/           \\_/     ");


            string input = Console.ReadLine();
            int chasis = 0;
            bool convert = Int32.TryParse(input, out int choice);
            if (convert)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You've picked sedan");
                        chasis = 1;
                        break;
                    case 2:
                        Console.WriteLine("You've picked wagon");
                        chasis = 2;
                        break;
                    case 3:
                        Console.WriteLine("You've picked hatchback");
                        chasis = 3;
                        break;
                    default:
                        chasis = 0;
                        Console.WriteLine("Invalid choice try again");
                        break;
                }
            }
            return chasis;
        }
    }
}
