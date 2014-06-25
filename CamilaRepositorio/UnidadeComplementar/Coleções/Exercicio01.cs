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

        public static void Main1(string[] args)
        {
            _ArrayList.Add(111);
            _ArrayList.Add(52);
            _ArrayList.Add(63);
            _ArrayList.Add(48);
            _ArrayList.Add(55);
            _ArrayList.Add(79);
            _ArrayList.Add(8);
            _ArrayList.Add(9);
            _ArrayList.Add(122);
            _ArrayList.Add(101);

            _ArrayList.Sort();   // ordem crescente

            Console.WriteLine(" ------ Ordem Crescente ------ ");
            foreach (var item in _ArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            _ArrayList.Reverse();  // ordem decrescente
            Console.WriteLine(" ------ Ordem Decrescente ------ ");

            foreach (var item in _ArrayList)
            {
                Console.WriteLine(item);
            }


          
            Console.ReadLine();




        }
    }
}
