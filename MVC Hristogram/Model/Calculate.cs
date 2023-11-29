using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Hristogram
{
    internal class Calculate
    {
        public int N { get; set; }
        public int[] info;
        public double P1{ get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }

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
            int br4 = 0;
            int br5 = 0;
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i] < 200)
                {
                    br1++;
                }
                else if (info[i] >= 200 && info[i] < 400)
                {
                    br2++;
                }
                else if (info[i] >= 400 && info[i] < 600)
                {
                    br3++;
                }
                else if (info[i] >= 600 && info[i] < 800)
                {
                    br4++;
                }
                else if (info[i] > 800)
                {
                    br5++;
                }
            }
            P1 = (double)br1 / info.Length * 100;
            P2 = (double)br2 / info.Length * 100;
            P3 = (double)br3 / info.Length * 100;
            P4 = (double)br4 / info.Length * 100;
            P5 = (double)br5 / info.Length * 100;
        }
    }
}
