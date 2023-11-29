using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal class Calculate
    {
        public Calculate(double v, double p1, double p2, double h)
        {
            V = v;
            P1 = p1;
            P2 = p2;
            H = h;
        }

        public double V { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double H { get; set; }

        public double CalculateP1()
        {
            return P1 * H;
        }
        public double CalculateP2()
        {
            return P2 * H;
        }
        public double Percentage()
        {
            return ((CalculateP1() + CalculateP2()) / V)*100;
        }
        public double percantageP1()
        {
            return (CalculateP1() / (CalculateP1() + CalculateP2())) * 100;
        }
        public double percantageP2()
        {
            return (CalculateP2() / (CalculateP1() + CalculateP2())) * 100;
        }
    }
}
