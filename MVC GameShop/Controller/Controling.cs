using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_GameShop
{
    internal class Controling
    {
        Display display;
        Calculate calculate;
        public Controling()
        {
            display = new Display();
            calculate = new Calculate(display.N, display.info);
            calculate.Percentages();
            display.HearhStone = calculate.HearhStone;
            display.Fortnite = calculate.Fortnite;
            display.Overwatch = calculate.Overwatch;
            display.Others = calculate.Others;
            display.Print();
        }
    }
}
