using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Coleções
{
    class Exercicio01

        
    //1) Faça um algoritmo que adicione 100 números em qualquer coleção que vocês preferir, ao final imprima
    // esses números decrescente e depois crescente.

    {
        public static ArrayList _ArrayList = new ArrayList();
        public static Random gerador = new Random();

        public static void Main01(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                _ArrayList.Add(gerador.Next(0,99));

            }

            _ArrayList.Sort();   // ordem crescente

            Console.WriteLine(" ------ Ordem Crescente ------ ");
            Console.WriteLine();
            foreach (var item in _ArrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            _ArrayList.Reverse();  // ordem decrescente
            Console.WriteLine(" ------ Ordem Decrescente ------ ");
            Console.WriteLine();

            foreach (var item in _ArrayList)
            {
                Console.Write(item + " ");
            }


          
            Console.ReadLine();




        }
    }
}
