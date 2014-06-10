using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXII.ExercícioFixação
{
    class Exercicio01_AcharMaiorMenorElemento
    {
        public static void Main2(string[] args)
        {
           

            int[] array = new int[] { 9, 56, 3, 55 };

            int maiornumero = Maior(array);
            int menornumero = Menor(array);
           
            Console.WriteLine("O maior numero é: " + array[maiornumero]);
            Console.WriteLine("O menor numero é: " + array[menornumero]);
            Console.ReadKey();
        }

        public static int Maior(int[] array)
        {
            int maiornumero = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maiornumero] < array[i])
                {
                    maiornumero = i;
                }
            }
            return maiornumero;
        }


        public static int Menor(int[] array)
        {
            int menornumero = 0;

            for (int i =  1; i < array.Length; i++)
            {
                if (array[menornumero] > array[i])
                {
                    menornumero = i;
                }
            }
            return menornumero;
        }
    }
}
