using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio06_NúmeroAleatório
    /* Crie um programa em C# que gere e exiba no terminal um número aleatório. Além disso, esse programa deve contabilizar a quantidade de dígitos 
    “1” do número aleatório e exibir essa quantidade no terminal. Complete o código abaixo. */
     
    {
        public static int numero, total;
        public static void Main6(string[] args)

        {
            Random gerador = new Random();

            for (int i = 1; i <= 5; i++)
            {
                numero = gerador.Next(1, 10);
                Console.WriteLine(numero);

                if (numero == 1)
                {
                    total += numero;
                }

            }

            Console.Clear();
            Console.WriteLine("Possui " + total + " numeros 1!");


            Console.ReadLine();
        }
    }
}
