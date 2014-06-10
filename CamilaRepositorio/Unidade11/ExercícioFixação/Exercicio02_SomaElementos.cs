using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXII.ExercícioFixação
{
    class Exercicio02_SomaElementos

    {
        public static void Main02(string[] args)
        {
            int[] array = new int[] { 9, 56, 3, 55 };

            double resultadoSoma = Soma(array);
            Console.WriteLine("A soma é igual a = " + resultadoSoma);
            Console.ReadKey();
        }

        public static int Soma(int[] array)
        {
            int soma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }

            return soma;
        }

    }
}
