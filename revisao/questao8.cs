using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromo;
            string reversedString;
            char[] reverse;
            Console.Write("Digite um numero inteiro de quatro digitos: ");
            palindromo = Console.ReadLine();

            reverse = palindromo.ToCharArray();
            Array.Reverse(reverse);
            reversedString = new string(reverse);

            Console.Clear();
            if (reversedString == palindromo)
                Console.WriteLine("O numero é palindromo.");
            else
                Console.WriteLine("o numero não é palindromo.");
            Console.ReadKey();
        }
    }
}
