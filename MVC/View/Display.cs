using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal class Display
    {
        public double V { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double H { get; set; }
        public double Total { get; set; }
        public double Percentage1 { get; set; }
        public double Percentage2 { get; set; }
        public Display()
        {
            GetValues();
        }
        public void GetValues()
        {
            V = double.Parse(Console.ReadLine());
            P1 = double.Parse(Console.ReadLine());
            P2 = double.Parse(Console.ReadLine());
            H = double.Parse(Console.ReadLine());

        }
        public void Print()
        {
            Console.WriteLine($"the totals is {Total:f2} p1 filled {Percentage1:f2} p2 filled {Percentage2:f2}");
        }
    }
}
