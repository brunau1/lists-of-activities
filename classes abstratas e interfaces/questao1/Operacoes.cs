using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
  class Operacoes
  {
    public double retornaCalculo(AnaliseCombinatoria calc, int n, int p)
    {
      return calc.calcula(n, p);
    }
  }
}
