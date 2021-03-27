using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkAlgorithm.Sample
{
    internal class D
    {
        public IReadOnlyList<E> Es { get; }

        internal D(IReadOnlyList<E> es)
        {
            Es = es;
        }
    }
}
