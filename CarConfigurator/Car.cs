using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarConfigurator
{
    public class Car
    {
        public string CarBuild(int chasis, int engine, int transmision, int interiorColour, int paintColour, int equipmentPack)
        {
            string[] chasisArray = new string[] { "Sedan", "Wagon", "Hatchback" };
            string[] engineArray = new string[] { "Petrol 1.8 MPI 140HP", "Petrol 2.5 Turbo 258HP", "Diesel 2.0 TurboD 172HP", "Hybrid 1.6 MPI + Electric engine 210HP(combined)" };
            string[] transmisionArray = new string[] { "Manual 6 speed", "DualClutch Automatic 8 speed", "CVT(only hybrid)" };
            string[] interiorArray = new string[] { "Black leather", "Carmel leather","Grey fabric","Handmade alcantara + black leather" };
            string[] paintArray = new string[] { "Midnight Black", "Arctic White", "Magnetic Silver", "Candy Red", "Sating Grey", "Electric Orange" };
            string[] equipmentArray = new string[] { "Standard", "PackPlus", "SportPack", "MaxPack" };

            string finalBuild = $"Your final build!\n" +
                $"Chasis:{chasisArray[chasis-1]}\n" +
                $"Engine: {engineArray[engine-1]}\n" +
                $"Transmission: {transmisionArray[transmision-1]}\n" +
                $"Interior: {interiorArray[interiorColour-1]}\n" +
                $"Paint: {paintArray[paintColour-1]}\n" +
                $"EquipmentPack: {equipmentArray[equipmentPack-1]}";

            return finalBuild;

        }
        
        
        
    }
}
