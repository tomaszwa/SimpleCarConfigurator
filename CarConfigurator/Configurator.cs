using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConfigurator
{
    public class Configurator
    {
        public bool Specing(int chasis)
        {
            Car Car = new Car();
            Console.WriteLine($"Available engine:\n" +
                $"1. Petrol 1.8 MPI 140HP 62000EUR\n" +
                $"2. Petrol 2.5 Turbo 258HP 72000EUR\n" +
                $"3. Diesel 2.0 TurboD 172HP 60500EUR\n" +
                $"4. Hybrid 1.6 MPI + Electric engine 210HP(combined) 68000EUR");
            string input =Console.ReadLine();
            Int32.TryParse(input, out int engine);

            Console.WriteLine($"Available transmision:\n" +
                $"1. Manual 6 speed +0EUR\n" +
                $"2. DualClutch Automatic 8 speed +2000EUR\n" +
                $"3. CVT(only hybrid) +0EUR");
            string input2 = Console.ReadLine();
            Int32.TryParse(input2, out int transmission);
            if(engine != 4 && transmission == 3)
            {
                Console.WriteLine("Wrong option, start again");
                return false;
            }

            Console.WriteLine($"Available interiors:\n" +
                $"1. Black leather +1500EUR\n" +
                $"2. Carmel leather +2000EUR\n" +
                $"3. Grey fabric +0EUR\n" +
                $"4. Handmade alcantara + black leather +3500EUR\n");
            string input3 = Console.ReadLine();
            Int32.TryParse(input3, out int interior);

            Console.WriteLine($"Available paints:\n" +
                $"1. Midnight Black +0EUR\n" +
                $"2. Arctic White +0EUR\n" +
                $"3. Magnetic Silver +0EUR\n" +
                $"4. Candy Red +2000EUR\n" +
                $"5. Sating Grey +3500EUR\n" +
                $"6. Electric Orange +4000EUR");
            string input4 = Console.ReadLine(); 
            Int32.TryParse(input4, out int paint);

            Console.WriteLine($"Avaialable equipment packages:\n" +
                $"1. Standard(6.5' inch multimedia screen, heated seats, 2-zone climate control +0EUR\n" +
                $"2. PackPlus(8' inch multimedia screen, heated and ventilated seats, 3-zone climate control +200EUR\n" +
                $"3. SportPack(8' inch multimedia screen, heated and ventilated seats, 3-zone climate control, black wheels 19' inch alloy wheels, black splitters +1100EUR \n" +
                $"4. MaxPack(8 inch multimedia screen, heated and ventilated seats, 4-zone climate control, gunpowder grey 20' inch alloy wheels, 360 camera system, active cruise control + 2400EUR");
            string input5 = Console.ReadLine();
            Int32.TryParse(input5, out int pack);

            Console.WriteLine(Car.CarBuild(chasis, engine, transmission, interior, paint, pack));

            return true;

            
        }
    }
}
