﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BezOstatuk
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
            display.P1 = calculate.P1;
            display.P2 = calculate.P2;
            display.P3 = calculate.P3;
            display.Print();
        }
    }
}
