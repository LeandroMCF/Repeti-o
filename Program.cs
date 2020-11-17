using System;

namespace Repeti_o
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo WHILE");
            int numero;
            int contador = 0; 

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            while (contador <= numero)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }
        }
    }
}
