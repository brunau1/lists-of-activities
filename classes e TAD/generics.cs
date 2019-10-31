using System;

namespace App
{
    class Vetor<T>
    {
        T[] vetor;
        public void setArrayLength(int tam)
        {
            vetor = new T[tam];
        }
        public void addElement(T element, int pos)
        {
            vetor[pos] = element;
        }
        public T removeElement(int pos)
        {
            return vetor[pos];
        }
        public void showElements()
        {
            Console.WriteLine($"Elements:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($"{vetor[i]} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vetor<int> vetor = new Vetor<int>();
            vetor.setArrayLength(10);
            for (int i = 0; i < 10; i++)
                vetor.addElement(i, i);
            vetor.showElements();
        }
    }
}
