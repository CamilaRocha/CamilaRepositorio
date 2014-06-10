using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExercicioFixação
{
    class Exercicio03
    /*  03) Uma loja está levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo que permita a entrada das seguintes informações: 
    a) o número total de mercadorias no estoque; 
    b) o valor de cada mercadoria. Ao final imprimir o valor total em estoque e a média de valor das mercadorias. */

    {
        
        public static double valor_mercadoria, total, media;

        public static void Main3(string[] args)

        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o valor da mercadoria: ");
                valor_mercadoria = double.Parse(Console.ReadLine());
                total += valor_mercadoria;
                media = total / 2;
                Console.Clear();
            }

            Console.WriteLine("O total das mercadorias foi de R$" + total);
            Console.WriteLine("A média foi de: " + media);
            Console.ReadLine();
        }
    }
}
