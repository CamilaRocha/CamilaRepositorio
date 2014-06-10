using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class Exercicio03_EscolheCaminho

    {
        public static double x;
        public static void Main3(string[] args)

        {
            Random gerador = new Random();
            x = gerador.NextDouble();
            Console.WriteLine(x);
            Console.WriteLine();
            Console.Clear();

            if (x >= 0.5)
            {
                Console.WriteLine("Siga para Direita!");
            }
            else
            {
                Console.WriteLine("Siga para Esquerda!");
            }

            Console.ReadLine();
        }
    }
}
