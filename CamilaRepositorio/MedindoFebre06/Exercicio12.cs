using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoFebreVI
{
    class Exercicio12
    {
         public static int nota1, nota2, nota3, media, frequencia, mediaturma;
        public static int matricula;

        public static void Main01(string[] args)

        {
            for (int i = 1; i < 5; i++)
            {
                Console.Write("Informe o número da sua matrícula: ");
                matricula = int.Parse(Console.ReadLine());
                Console.Write("Informe sua primeira nota: ");
                nota1 = int.Parse(Console.ReadLine());
                Console.Write("Informe sua segunda nota: ");
                nota2 = int.Parse(Console.ReadLine());
                Console.Write("Informe sua terceira nota: ");
                nota3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe quantas aulas você frequentou: ");
                frequencia = int.Parse(Console.ReadLine());
                frequencia = frequencia * 10;
                media = (nota1 + nota2 + nota3) / 3;

                Console.Clear();

                if (media >= 7 && frequencia >= 70)
                {
                    Console.WriteLine("Matricula : " + matricula + "\nSua média é = " + media + "\nSua frequência é = " + frequencia + "%\nVocê está APROVADO!");
                }
                else
                {
                    Console.WriteLine("Matricula : " + matricula + "\nSua média é = " + media + "\nSua frequência é = " + frequencia + "%\nVocê está REPROVADO!");
                }
                Console.WriteLine();        
                
            }

            mediaturma += media / 5 ;
            Console.WriteLine("A média da turma = " + mediaturma);

           

            Console.ReadLine();
        }
    }
}
    

