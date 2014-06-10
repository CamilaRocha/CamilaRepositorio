using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class Exercicio02_VerificaValorProduto

    {
        public static double valor;

        public static void Main2(string[] args)

        {
            Random gerador = new Random();

            valor = gerador.NextDouble();
            Console.WriteLine(valor);
            Console.WriteLine();


            if (valor >= 0.5)
            {
                Console.WriteLine("Caro!");
            }
            else
            {
                Console.WriteLine("O preço está em conta!");
            }


            Console.ReadLine();
        }
    }
}
