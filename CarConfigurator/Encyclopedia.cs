using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConfigurator
{
    public class Encyclopedia
    {

        public string Info(int chasis)
        {
            switch (chasis)
            {
                case 1:
                    return $"Length: 4810mm\n" +
                        $"Width: 1820mm\n" +
                        $"Width including mirrors: 2084mm\n" +
                        $"Height: 1445mm\n" +
                        $"Wheelbase: 2850mm\n" +
                        $"Kerb Weight: 1550kg\n" +
                        $"Trunk space: 500L\\720L(seats folded)";
                case 2:
                    return $"Length: 4936mm\n" +
                        $"Width: 1820mm\n" +
                        $"Width including mirrors: 2084mm\n" +
                        $"Height: 1445mm\n" +
                        $"Wheelbase: 2850mm\n" +
                        $"Kerb Weight: 1650kg\n" +
                        $"Trunk space: 560L\\1200L(seats folded)";
                case 3:
                    return $"Length: 4460mm\n" +
                        $"Width: 1790mm\n" +
                        $"Width including mirrors: 1984mm\n" +
                        $"Height: 1435mm\n" +
                        $"Wheelbase: 2725mm\n" +
                        $"Kerb Weight: 1400kg\n" +
                        $"Trunk space: 380L\\520L(seats folded)";
            }
            return "";
        }

    }

}
