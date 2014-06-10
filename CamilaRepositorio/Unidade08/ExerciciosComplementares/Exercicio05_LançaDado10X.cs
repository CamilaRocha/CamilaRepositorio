using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class Exercicio05_LançaDado10X
    /* Considere um jogo no qual o jogador lança um dado 10 vezes. O jogador ganha se a soma dos valores obtidos nos lançamentos for ímpar. Se o número
    6 for sorteado 2 vezes o jogador perde imediatamente. O número 1 deve ser desconsiderado na somatória. Implemente um programa em C# para simular a
    execução desse jogo */
     
    {
        public static int numero, soma;

        public static void Main05(string[] args)

        {
            Random gerador = new Random();

            for (int i = 1; i <= 5; i++)
            {
                numero = gerador.Next(0,7);
                Console.WriteLine(numero);

                if (numero == 1)
                {
                    numero = 0;
                }
                soma += numero;

            }

            Console.Clear();
            Console.WriteLine("Soma dos dados = " + soma);
            Console.WriteLine();

            if (soma % 3 == 0)
            {
                Console.WriteLine("VENCEU!!");
            }
            else
            {
                Console.WriteLine("PERDEU!!");
            }

            Console.ReadLine();
        }
    }
}
