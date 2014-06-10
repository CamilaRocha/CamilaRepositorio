using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide.InstruçõesdeRepetições
{
    class Exercicio06_Repita5vezes

    {
        public static int i = 1;

        public static void Main7(string[] args)
        {
            while (i <= 5)
            {
                Console.WriteLine("Mensagem número " + i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
