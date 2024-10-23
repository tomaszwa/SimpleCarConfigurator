using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConfigurator
{
    public class InputHandler
    {
        public static int GetValidIntInput(int minOption, int maxOption)
        {
            int selectedOption = -1;
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    string input = Console.ReadLine();

                    if (!Int32.TryParse(input, out selectedOption))
                        throw new FormatException("Input is not a valid number.");

                    if (selectedOption < minOption || selectedOption > maxOption)
                        throw new ArgumentOutOfRangeException($"Please select a valid option between {minOption} and {maxOption}.");

                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message} Please enter a valid number.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return selectedOption;
        }
    }
}
