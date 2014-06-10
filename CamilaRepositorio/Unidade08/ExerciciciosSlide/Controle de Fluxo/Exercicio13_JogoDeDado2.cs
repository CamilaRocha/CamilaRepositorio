using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide.Controle_de_Fluxo
{
    class Exercicio13_JogoDeDado2

    {
        public static int numero, soma;

        public static void Main13(string[] args)
        {
            Random gerador = new Random();

            for (int i = 1; i <= 4; i++)
            {
                numero = gerador.Next(0,5);
                Console.WriteLine("Valor do dado: " + numero);

                if (numero%2 ==0)
                {
                    continue;
                }

                soma += numero;
               
                

                if (soma > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você venceu!");
                    break;
                }
               
               
            }
            Console.ReadLine();
        }
    }
}
