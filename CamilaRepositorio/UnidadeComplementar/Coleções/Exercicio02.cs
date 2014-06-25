using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Coleções
{
    class Exercicio02
    //2) Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor valor, o maior valor, a média e a soma de todos os valores.

    {
        public static List<int> x = new List<int>();
        public static void Main03(string[] args)
        {
            x.Add(111);
            x.Add(52);
            x.Add(63);
            x.Add(48);
            x.Add(55);
            x.Add(79);
            x.Add(8);
            x.Add(9);
            x.Add(122);
            x.Add(101);

		    int max = x.Max();
            
            Console.WriteLine("Maior valor: ", max);
            Console.WriteLine("Menor valor: ", x.Min());
            Console.WriteLine("Media: ", x.Average());
            Console.WriteLine("Soma: ", x.Min());
            



            Console.ReadLine();
        }
    }
}
