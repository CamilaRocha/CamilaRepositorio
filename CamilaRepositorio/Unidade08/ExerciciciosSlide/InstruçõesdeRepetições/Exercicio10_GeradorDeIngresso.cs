using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide.InstruçõesdeRepetições
{
    class Exercicio10_GeradorDeIngresso

    {
        public static int i ;

        public static void Main11(string[] args)

        {
            while (i <= 4)              
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine("Setor : " + i + " Lugar : " + j);
                }
                Console.ReadLine();
            }

        }
    }
}
