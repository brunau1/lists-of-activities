using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    abstract class AnaliseCombinatoria
    {
        protected int calcFatorial(int n)
        {
            if (n == 1) return 1;
            return n * calcFatorial(n - 1);
        }
        abstract public double calcula(int n, int p);
    }
}
