using System;

namespace Repeti_o
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            int tabuada;
            int rep = 1;

            while (rep == 1)
            {
                Console.Write("Digite um numero para saber sua tabuada: ");
                numero = int.Parse(Console.ReadLine());
                contador = 0;
                while (contador < 10)
                {
                    contador = contador + 1;
                    tabuada = numero * contador;
                    Console.WriteLine(tabuada);
                }
                Console.WriteLine("Fim");
                Console.WriteLine("Deseja ver outro número? \n [1] para ver outro número \n [2] para sair");
                rep = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fim da tabuada");
            
        }
    }
}
