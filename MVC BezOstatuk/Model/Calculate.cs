using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BezOstatuk
{
    internal class Calculate
    {
        public int N { get; set; }
        public int[] info;
        public double P1{ get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }


        public Calculate(int n, int[] info)
        {
            N = n;
            this.info = info;
        }
        public void Percentages()
        {
            int br1 = 0;
            int br2 = 0;
            int br3 = 0;
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i]%2==0)
                {
                    br1++;
                }
                if (info[i]%3==0)
                {
                    br2++;
                }
                if (info[i]%4==0)
                {
                    br3++;
                }
            }
            P1 = (double)br1 / info.Length * 100;
            P2 = (double)br2 / info.Length * 100;
            P3 = (double)br3 / info.Length * 100;
        }
    }
}
