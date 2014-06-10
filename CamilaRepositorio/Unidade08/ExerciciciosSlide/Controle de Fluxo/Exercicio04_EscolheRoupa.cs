using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class Exercicio04_EscolheRoupa

    {
        public static double valor;

        public static void Main4(string[] args)
        {
            Random gerador = new Random();
            valor = gerador.NextDouble();
            Console.WriteLine(valor);
            Console.WriteLine();
            Console.Clear();

            if (valor >= 0.5)
            {
                Console.WriteLine("Veste uma camisa vermelha!");
            }
            else
            {
                Console.WriteLine("Veste uma blusa azul!");
            }

            Console.ReadLine();
        }
    }
}
