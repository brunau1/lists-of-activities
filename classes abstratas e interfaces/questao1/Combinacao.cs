using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
  class Combinacao : AnaliseCombinatoria
  {
    public override double calcula(int n, int p)
    {
      return base.calcFatorial(n) / (base.calcFatorial(p) * base.calcFatorial(n - p));
    }
  }
}
