using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio02_PadrãoTerminal

    {
        public static int espaco;

        public static void Main02(string[] args)
        {
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("**********");
                    Contadorespaco();
                    espaco += 1;
                }

                espaco = 0;
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("**********");
                    Contadorespaco();
                    espaco += 1;
                }

                espaco = 0;
                for (int j = 1; j <= 6; j++)
                {
                    Console.WriteLine("**********");
                    Contadorespaco();
                    espaco += 1;
                }

              
               
            Console.ReadLine();
        }

        private static void Contadorespaco()
        {
          
            for (int i = 0; i < espaco + 1; i++)
            {
               
                Console.Write(" ");
            }
        }



    }
}
