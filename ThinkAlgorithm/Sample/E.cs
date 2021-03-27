using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkAlgorithm.Sample
{
    internal class E
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public int Data1 { get; }
        public int Data2 { get; }
        public int Data3 { get; }
        public int Data4 { get; }

        internal E(double x, double y, double z,
            int d1, int d2, int d3, int d4)
        {
            X = x;
            Y = y;
            Z = z;
            Data1 = d1;
            Data2 = d2;
            Data3 = d3;
            Data4 = d4;
        }
    }
}
