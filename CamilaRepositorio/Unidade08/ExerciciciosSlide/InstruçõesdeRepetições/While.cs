using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class While
    {
        // inicialização
        public static int i = 1;

        public static void Main6(string[] args)
        {

            // condição
            while (i <= 100)
            {
                // corpo
                Console.WriteLine("Mensagem número " + i);

                // atualização
                i++;
            }

            Console.ReadLine();
        }
    }
}
