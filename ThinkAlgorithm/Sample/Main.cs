using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkAlgorithm.Sample
{
    internal class Main
    {
        public A HeaderA { get; }

        public B HeaderB { get; }

        public IReadOnlyList<D> DataD { get; }

        internal Main(A headerA, B headerB, IReadOnlyList<D> dataD)
        {
            HeaderA = headerA;
            HeaderB = headerB;
            DataD = dataD;
        }
    }
}
