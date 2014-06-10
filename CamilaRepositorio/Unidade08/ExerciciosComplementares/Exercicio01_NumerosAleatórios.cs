using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio01_NumerosAleatórios
    /* Crie um programa em C# que gere dois números aleatórios e exiba o valor desses números. Além disso, esse programa deve exibir a mensagem “Primeiro > 
    Segundo” se o primeiro número for maior do que o segundo, a mensagem “Segundo > Primeiro” se o segundo número for maior do que o primeiro e mensagem
    “Primeiro = Segundo” se o primeiro número for igual ao segundo. */
    {
        public static int numero1, numero2;

        public static void Main01(string[] args)
        {
            Random gerador = new Random();
            numero1 = gerador.Next(0, 100);
            Console.WriteLine("Primeiro numero: " + numero1);
            numero2 = gerador.Next(0, 100);
            Console.WriteLine("Segundo numero: " + numero2);
            Console.WriteLine();

            if (numero1 > numero2)
            {
                Console.WriteLine("Primero > Segundo");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("Segundo > Primeiro");
            }
            else
            {
                Console.WriteLine("Primeiro = Segundo");
            }


            Console.ReadLine();
        }


    }
}