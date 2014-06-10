using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide.Controle_de_Fluxo
{
    class Exercicio12_JogoDeDado

    {
        public static int numero, soma;

        public static void Main12(string[] args)

        {
            Random gerador = new Random();

            for (int i = 1; i <= 5; i++)
            {
                numero = gerador.Next(0,7);
                Console.WriteLine("Jogada de dados = " + numero);
                soma += numero;
               
            }

            Console.WriteLine();
            if (soma >= 19)
            {
                Console.WriteLine("Você ganhou!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }

            Console.ReadLine();
            
        }
    }
}
