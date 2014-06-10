using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExercicioFixação
{
    class Exercicio01
    /* Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever: 
    - o maior preço lido 
    - a média aritmética dos preços dos produtos. */

    {
        public static int codigo;
        public static double preco, media, soma;

        public static void Main2(string[] args)

        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe o codigo do produto: ");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o preco: ");
                preco = double.Parse(Console.ReadLine());
                Console.Clear();
                soma += preco;
            }

            media = soma / 3;
            Console.WriteLine("A média será: " + media);

            Console.ReadLine();
        }
    }
}
