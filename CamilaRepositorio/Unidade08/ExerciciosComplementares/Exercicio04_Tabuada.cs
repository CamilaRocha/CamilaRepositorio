using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio04_Tabuada
    /* Escreva um programa em C# que exiba no terminal a tabuada dos números de 1 a 10 de acordo com o padrão abaixo.
    1x1 = 1
    1x2 = 2
    1x3 = 3
    ...
    10x8 = 80
    10x9 = 90
    10x10 = 100 */

    {
        public static int tabuada;

        public static void Main04(string[] args)
        {
            for (int i = 1; i <= 10 ; i++)
            {
                tabuada = 1 * i;
                Console.WriteLine("1 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 2 * i;
                Console.WriteLine("2 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 3 * i;
                Console.WriteLine("3 x " + i + " = " + tabuada);
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 4 * i;
                Console.WriteLine("4 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 5 * i;
                Console.WriteLine("5 x " + i + " = " + tabuada);
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 6 * i;
                Console.WriteLine("6 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 7 * i;
                Console.WriteLine("7 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 8 * i;
                Console.WriteLine("8 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 9 * i;
                Console.WriteLine("9 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                tabuada = 10 * i;
                Console.WriteLine("10 x " + i + " = " + tabuada);
            }

            Console.WriteLine();

            

            Console.ReadLine();
        }
    }
}
