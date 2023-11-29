using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal class Contr1
    {
        Display display;
        Calculate calculate;
        public Contr1()
        {
            display = new Display();
            calculate = new Calculate(display.V, display.P1, display.P2, display.H);
            display.Percentage1 = calculate.percantageP1();
            display.Percentage2 = calculate.percantageP2();
            display.Total = calculate.Percentage();
            display.Print();
        }

    }
}
