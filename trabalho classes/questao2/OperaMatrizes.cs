using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTrab
{
    class OperaMatrizes : Matrizes
    {
        public OperaMatrizes() : base() { }

        public OperaMatrizes(bool isRandomic) : base(isRandomic) { }

        public OperaMatrizes(int linhas, int colunas) : base(linhas, colunas) { }

        public OperaMatrizes(int linhas, int colunas, bool isRandomic) : base(linhas, colunas, isRandomic) { }
        
        public Matrizes multMatriz(Matrizes M1, Matrizes M2)
        {
            int linhas, colunas, minRows, minCols;
            linhas = M1.n > M2.n ? M1.n : M2.n;
            colunas = M1.p > M2.p ? M1.p : M2.p;
            minRows = M1.n < M2.n ? M1.n : M2.n;
            minCols = M1.p < M2.p ? M1.p : M2.p;
            Matrizes resultante = new Matrizes(linhas, colunas);

            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    resultante.matriz[i, j] = M1.matriz[i, j] * M2.matriz[i, j];

            return resultante;
        }
    }
}
