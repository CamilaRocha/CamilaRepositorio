using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exercicio03_MaiorMenorIdade
     /* Implemente um método que verifique a idade de 20 pessoas, um para comparar a maior idade, um para menor
      idade, outro para fazer a média de todas as 20 idades e por fim imprimir todos esses dados. (5 métodos) */

    {
        public static int SomaIdade, IdadeMaior = 0, IdadeMenor = 0;
        public static int Idade = 0, media;
        public static void Main(string[] args)

        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Pessoa (" + i + "), idade: ");
                Idade = int.Parse(Console.ReadLine());
                SomaIdade = SomaIdade + Idade;
                IdadeMaior = MaiorIdade(IdadeMaior, Idade);
                IdadeMenor = MenorIdade(IdadeMenor, Idade);
                
            }
            

            media = MediaIdade(media);
            Console.Write("Média idade = " + media);
            Console.WriteLine();
            Console.Write("Maior idade = " + IdadeMaior);
            Console.WriteLine();
            Console.Write("Menor idade = " + IdadeMenor);


            Console.ReadLine();
        }

         private static int MediaIdade(int a)
        {
            a = SomaIdade / 20;
            return a;
        }

        private static int MenorIdade(int a, int b) // a = menor idade, b = idade
         {
             if (b > a)
             {
                 b = a;
             }
             return  b;
         }

        private static int MaiorIdade(int a, int b) // a = maior idade b = idade
        {
            if (b < a)
            {
                a = b;
            }
            return a; 
        }
    }

   
}
