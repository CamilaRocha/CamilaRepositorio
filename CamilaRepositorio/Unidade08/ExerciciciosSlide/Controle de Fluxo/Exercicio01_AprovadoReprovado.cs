using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciciosSlide
{
    class Exercicio01_AprovadoReprovado
    // Controle de fluxo

    {
        
        public static double nota;

        public static void Main1(string[] args)

        {
            Random gerador = new Random();

            nota = gerador.NextDouble();
            Console.WriteLine(nota);
            Console.WriteLine();

            if (nota >= 0.7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            Console.ReadLine();
            
        }

    }
}
