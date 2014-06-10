using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide.InstruçõesdeRepetições
{
    class Exercicio09_DivideMaiorInteiro

    {
        public static int i = 2147483647;
       

        public static void Main10(string[] args)

        {
  
            while (i > 100)
            {
                i = i / 2;
                if (i > 100)
                {
                    Console.WriteLine( i);
                }
            }
            Console.ReadLine();
        }
    }
}
