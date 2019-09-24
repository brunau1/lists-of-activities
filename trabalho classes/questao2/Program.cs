using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTrab
{
    class Program
    {
        static void Main(string[] args)
        {
            OperaMatrizes operador = new OperaMatrizes(3,3,true);
            Matrizes m1 = new OperaMatrizes(4, 3, true);
            Matrizes m2 = new OperaMatrizes(3, 5, true);
            Matrizes matriz = operador.multMatriz(m1, m2);
            m1.listar();
            m2.listar();
            matriz.listar();
        }
    }
}
