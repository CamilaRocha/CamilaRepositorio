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
        public static List<double> x = new List<double>();
        public static void Main02(string[] args)
        {

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe um numero: ");
                x.Add(int.Parse(Console.ReadLine()));

            }
            
            Console.WriteLine("Maior valor: {0} ", x.Max());
            Console.WriteLine("Menor valor: {0} ", x.Min());
            Console.WriteLine("Media: {0} ", x.Average());
            Console.WriteLine("Soma: {0} ", x.Sum());
            



            Console.ReadLine();
        }
    }
}
