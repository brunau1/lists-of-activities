using System;

namespace Application {
    class Program {
        static void Main (string[] args) {
            double[] altura = new double[15];
            char[] sexo = new char[15];
            double maior, menor, media = 0;
            int contHomens = 0, contMulheres = 0;
            maior = 0;
            menor = 10;
            for (int i = 0; i < 15; i++) {
                Console.Clear ();
                Console.WriteLine ("Digite o sexo (m ou f) da {0} pessoa:", i + 1);
                sexo[i] = char.Parse (Console.ReadLine ());
                Console.WriteLine ("digite a altura:");
                altura[i] = double.Parse (Console.ReadLine ());

                if (sexo[i] == 'f') {
                    media += (double) altura[i];
                    contMulheres++;
                } else if (sexo[i] == 'm')
                    contHomens++;

                if (altura[i] > maior)
                    maior = altura[i];
                if (altura[i] < menor)
                    menor = altura[i];
            }
            Console.Clear ();

            media = media / (double) contMulheres;

            Console.WriteLine ("Maior altura: {0:f2}", maior);
            Console.WriteLine ("Menor altura: {0:f2}", menor);
            Console.WriteLine ("Média de altura das mulheres: {0:f2}", media);
            Console.WriteLine ("Número de homens: {0}", contHomens);

            Console.ReadKey ();
        }
    }
}