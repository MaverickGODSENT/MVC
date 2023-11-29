using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Hristogram
{
    internal class Display
    {
        public int N { get; set; }
        public int[] info;
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public Display()
        {
            GetValues();
        }
        public void GetValues()
        {
            N = int.Parse(Console.ReadLine());
            info = new int[N];
            for (int i = 0; i < info.Length; i++) { info[i] = int.Parse(Console.ReadLine());}
        }
        public void Print()
        {
            Console.WriteLine($"{P1:f2}%");
            Console.WriteLine($"{P2:f2}%");
            Console.WriteLine($"{P3:f2}%");
            Console.WriteLine($"{P4:f2}%");
            Console.WriteLine($"{P5:f2}%");
        }
    }
}
