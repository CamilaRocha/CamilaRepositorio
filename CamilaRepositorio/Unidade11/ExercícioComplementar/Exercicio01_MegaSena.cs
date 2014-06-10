using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXII.ExercícioComplementar
{
    class Exercicio01_MegaSena
    /* 1) Implemente um gerador (Aleatório) de números sorteados da mega-sena. É necessário acertar a sena, o que significa obter
    coincidência entre seis dos números apostados e os seis números sorteados, de um total de sessenta dezenas (de 01 a 60), 
    independentemente da ordem da aposta ou da ordem do sorteio. */

    {
        public static int numero;

        public static void Main(string[] args)
        {
            Console.WriteLine("============ Aposta ===========");
            Aposta(numero);
            if (numero > 60)
            {
                Console.WriteLine("Número Inválido!");
            }

            Console.WriteLine();
            Console.WriteLine("============ Mega-Sena ========");
            Console.WriteLine();
            Console.Write("Numeros sorteados: ");
            Sorteados();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("============ Resultado ========");
            Console.ReadLine();
        }

        public static int Aposta(int numero)
        {
            for (int i = 1; i <= 6; i++)
            {
                numero = int.Parse(Console.ReadLine());
                
            }

            return numero;
        }
        public static int[] Sorteados ()
        { 
            Random gerador = new Random();
            int[] numeros = new int[6];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = gerador.Next(1, 61);
                Ordenar(numeros);
                Console.Write("[" + numeros[i] +"]" + " ");
                

            }
    
            return numeros;
        }

        public static void Troca(int[] array, int i, int j)
        {
            int auxiliar = array[i];
            array[i] = array[j];
            array[j] = auxiliar;
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
