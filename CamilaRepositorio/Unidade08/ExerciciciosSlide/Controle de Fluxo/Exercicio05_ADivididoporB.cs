using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class Exercicio05_ADivididoporB

    {
        public static double a, b, valor;

        public static void Main5(string[] args)

        {
            Random gerador = new Random();
            a = gerador.NextDouble();
            Console.WriteLine(a);
            b = gerador.NextDouble();
            Console.WriteLine(b);
            Console.Clear();


            valor = a / b;

            if (valor % 2 == 0 )
            {
                Console.WriteLine("É divisivel!");
            }
            else
            {
                Console.WriteLine("Não é divisivel!");
            }
            Console.ReadLine();
        }
    }
}
