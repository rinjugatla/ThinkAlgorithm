using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkAlgorithm.Sample;

namespace ThinkAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Main data = new Sample.Main(
                new A(1, 3, 3, 4, 5),
                new B(1.0, "A", 2),
                new List<D>() {
                    new D(
                        new List<E>() {
                            new E(123.4, 12.0, 0.0, 1, 1, 17, 12),
                            new E(123.4, 12.0, 0.0, 12, 0, 13, 52),
                            new E(123.4, 12.0, 0.0, 11, 2, 1, 12)
                        }),
                    new D(
                        new List<E>() {
                            new E(123.4, 12.0, 0.0, 1, 2, 21, 52),
                        }),
                    new D(
                        new List<E>() {
                            new E(123.4, 12.0, 0.0, 1, 1, 11, 50),
                            new E(123.4, 12.0, 0.0, 12, 1, 35, 70),
                        }),
            });
        }
    }
}
