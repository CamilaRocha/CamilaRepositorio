using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXII.ExercícioFixação
{
    class Exercicio05_OrdenarElementos

    {
        public static void Main05(string[] args)
        {
            int[] array = new int[] { 9, 56, 3, 55 };


            Ordenar(array);
            Console.WriteLine(array);         
            Console.ReadLine();
        }

        public static int Menor(int[] array, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        } 

        public static void Troca(int[] array, int i, int j)
        {
            int auxiliar = array[i];
            array[i] = array[j];
            array[j] = auxiliar;
        }



        public static void Ordenar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                Troca(array, i, menor);
            }
        }
    }
}
