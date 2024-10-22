using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace CarConfigurator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AvailableChasis chasis = new AvailableChasis();
                Configurator configurator = new Configurator();
                Encyclopedia encyclopedia = new Encyclopedia();
                int choice = chasis.Chasis();

                Console.WriteLine("Options:\n" +
                    "1. Configure\n" +
                    "2. Dimensions\n" +
                    "0. Return\n");
                string input2 = Console.ReadLine();
                bool option = Int32.TryParse(input2, out int optionChosen);

                switch (optionChosen)
                {
                    case 1:
                        configurator.Specing(choice);
                        break;
                    case 2:
                        Console.WriteLine(encyclopedia.Info(choice));
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }





            }
        }
            
    }
}