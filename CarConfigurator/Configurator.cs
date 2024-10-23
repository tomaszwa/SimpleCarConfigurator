using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarConfigurator
{
    public class Configurator
    {
        private readonly List<CarElement> Engines = new List<CarElement>
        {
            new CarElement { Id = 1, Name = "Petrol 1.8 MPI 140HP", Price = 62000 },
            new CarElement { Id = 2, Name = "Petrol 2.5 Turbo 258HP", Price = 72000 },
            new CarElement { Id = 3, Name = "Diesel 2.0 TurboD 172HP", Price = 60500 },
            new CarElement { Id = 4, Name = "Hybrid 1.6 MPI + Electric engine 210HP(combined)", Price = 68000 }
        };

        private readonly List<CarElement> Transmissions = new List<CarElement>
        {
            new CarElement { Id = 1, Name = "Manual 6 speed", Price = 0 },
            new CarElement { Id = 2, Name = "DualClutch Automatic 8 speed", Price = 2000 },
            new CarElement { Id = 3, Name = "CVT(only hybrid)", Price = 0 }
        };

        private readonly List<CarElement> Interiors = new List<CarElement>
        {
            new CarElement { Id = 1, Name = "Black leather", Price = 1500 },
            new CarElement { Id = 2, Name = "Carmel leather", Price = 2000 },
            new CarElement { Id = 3, Name = "Grey fabric", Price = 0 },
            new CarElement { Id = 4, Name = "Handmade alcantara + black leather", Price = 3500 }
        };

        private readonly List<CarElement> Paints = new List<CarElement>
        {
            new CarElement { Id = 1, Name = "Midnight Black", Price = 0 },
            new CarElement { Id = 2, Name = "Arctic White", Price = 0 },
            new CarElement { Id = 3, Name = "Magnetic Silver", Price = 0 },
            new CarElement { Id = 4, Name = "Candy Red", Price = 2000 },
            new CarElement { Id = 5, Name = "Sating Grey", Price = 3500 },
            new CarElement { Id = 6, Name = "Electric Orange", Price = 4000 }
        };

        private readonly List<CarElement> EquipmentPackages = new List<CarElement>
        {
            new CarElement { Id = 1, Name = "Standard (6.5' inch multimedia screen, heated seats, 2-zone climate control)", Price = 0 },
            new CarElement { Id = 2, Name = "PackPlus (8' inch multimedia screen, heated and ventilated seats, 3-zone climate control)", Price = 200 },
            new CarElement { Id = 3, Name = "SportPack (8' inch multimedia screen, heated and ventilated seats, 3-zone climate control, black wheels 19' inch alloy wheels, black splitters)", Price = 1100 },
            new CarElement { Id = 4, Name = "MaxPack (8 inch multimedia screen, heated and ventilated seats, 4-zone climate control, gunpowder grey 20' inch alloy wheels, 360 camera system, active cruise control)", Price = 2400 }
        };

        public bool Specing(int chasis)
        {
            Car Car = new Car();
            decimal price = decimal.Zero;

            Console.WriteLine("Available engines:");
            foreach (CarElement element in Engines)
                Console.WriteLine($"{element.Id}. {element.Name} {element.Price}EUR");
            int engine = InputHandler.GetValidIntInput(1, 4);
            price += Engines.FirstOrDefault(x => x.Id == engine).Price;

            Console.WriteLine("Available transmissions:");
            foreach (CarElement element in Transmissions)
                Console.WriteLine($"{element.Id}. {element.Name} {element.Price}EUR");
            int transmission = InputHandler.GetValidIntInput(1, 3);
            price += Transmissions.FirstOrDefault(x => x.Id == transmission).Price;

            if (engine != 4 && transmission == 3)
            {
                Console.WriteLine("Wrong option, start again");
                return false;
            }

            Console.WriteLine("Available interiors:");
            foreach (CarElement element in Interiors)
                Console.WriteLine($"{element.Id}. {element.Name} {element.Price}EUR");
            int interior = InputHandler.GetValidIntInput(1, 4);
            price += Interiors.FirstOrDefault(x => x.Id == interior).Price;

            Console.WriteLine("Available paints:");
            foreach (CarElement element in Paints)
                Console.WriteLine($"{element.Id}. {element.Name} {element.Price}EUR");
            int paint = InputHandler.GetValidIntInput(1, 6);
            price += Paints.FirstOrDefault(x => x.Id == paint).Price;

            Console.WriteLine("Available equipment packages:");
            foreach (CarElement element in EquipmentPackages)
                Console.WriteLine($"{element.Id}. {element.Name} {element.Price}EUR");
            int pack = InputHandler.GetValidIntInput(1, 4);
            price += EquipmentPackages.FirstOrDefault(x => x.Id == pack).Price;

            var finalCarBuild = Car.CarBuild(chasis, engine, transmission, interior, paint, pack, price);
            Console.WriteLine(finalCarBuild);

            Console.WriteLine("1. Send information to dealer\n" +
            "2. Exit\n");
            int sendToDealer = InputHandler.GetValidIntInput(1, 2);

            switch (sendToDealer)
            {
                case 1:
                    SendToDealer(finalCarBuild);
                    break;
                case 2:
                    return true;
                default:
                    break;
            }


            return true;
        }

        private void SendToDealer(string finalCarBuild)
        {
            var actualDate = DateTime.Now;
            Console.WriteLine($"Dates available to meet with dealer:\n" +
                $"{actualDate.AddDays(1).ToString("dd-MM-yyyy")} - 10:00, 12:00, 14:00, 16:00\n" +
                $"{actualDate.AddDays(2).ToString("dd-MM-yyyy")} - 10:00, 12:00, 14:00, 16:00\n" +
                $"{actualDate.AddDays(3).ToString("dd-MM-yyyy")} - 10:00, 12:00, 14:00, 16:00\n" +
                $"Press anything to continue...");
            Console.ReadLine();
        }
    }

    public class CarElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
