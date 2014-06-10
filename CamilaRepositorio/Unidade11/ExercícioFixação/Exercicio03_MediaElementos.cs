using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXII.ExercícioFixação
{
    class Exercicio03_MediaElementos

    {
        public static void Main03(string[] args)
        {
            double[] array = new double[] { 9, 56, 3, 55 };

            double resultadoMedia = Media(array);
            Console.WriteLine("A media dos elementos é igual a = " + resultadoMedia);
            Console.ReadKey();
        }

        public static double Media(double[] array)
        {
            double soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }

            double media = soma / array.Length;

            return media;
        }
    }
}
