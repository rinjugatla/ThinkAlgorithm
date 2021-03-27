using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkAlgorithm.Sample
{
    internal class A
    {
        public int Data1 { get; }
        /// <summary>
        /// Dの数
        /// </summary>
        public int Data2 { get; }
        public int Data3 { get; }
        public int Data4 { get; }
        public int Data5 { get; }

        internal A(int d1, int d2, int d3, int d4, int d5)
        {
            Data1 = d1;
            Data2 = d2;
            Data3 = d3;
            Data4 = d4;
            Data5 = d5;
        }
    }
}
