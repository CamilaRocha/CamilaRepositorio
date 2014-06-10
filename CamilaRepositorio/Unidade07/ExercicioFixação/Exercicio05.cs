using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExercicioFixação
{
    class Exercicio05
        /*  Faça o programa que apresenta a seguinte saída, perguntando ao usuário o número máximo (no exemplo, 9). Este número deve ser sempre ímpar.

        1 2 3 4 5 6 7 8 9
          2 3 4 5 6 7 8
            3 4 5 6 7
              4 5 6
                5  */

    {
        public static int numero, numInicio, numFinal, numEspaco;

        public static void Main3(string[] args)

        {
            Console.WriteLine("Informe o numero máximo para o triângulo!");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

            if (numero % 2 == 0)
            {
                Console.WriteLine("Número inválido!");
            }
            else
            {
                numInicio = 1;
                numFinal = numero;

                while (numInicio != numFinal)
                {
                    Contadorespaco();

                    for (int i = numInicio; i <= numFinal; i++)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                    
                    numInicio += 1;
                    numFinal -= 1;
                    numEspaco += 2;
                }

                Contadorespaco();
                Console.WriteLine(numInicio);
            }
            Console.ReadLine();
        }

        private static void Contadorespaco()
        {
            for (int i = 0; i < numEspaco; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
