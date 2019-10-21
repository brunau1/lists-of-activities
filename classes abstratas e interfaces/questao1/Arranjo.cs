using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
  class Arranjo : AnaliseCombinatoria
  {
    public override double calcula(int n, int p)
    {
      return base.calcFatorial(n) / base.calcFatorial(n - p);
    }
  }
}
