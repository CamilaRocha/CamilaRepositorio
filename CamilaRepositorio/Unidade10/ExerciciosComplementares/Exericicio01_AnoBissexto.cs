using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exericicio01_AnoBissexto
        /* 1) Implemente um método que determina seu ano é ou não é bissexto. As regras para determinar se um ano é bissexto são:

    1. Anos múltiplos de 4 são bissextos.
    2. Anos múltiplos de 100 não são bissextos.
    3. Anos múltiplos de 400 são bissextos.
    4. As últimas regras prevalecem sobre as primeiras. */

    {
        public static void Main01(string[] args)
        {
            int ano;

            Console.Write("Informe o ano: ");
            ano = int.Parse(Console.ReadLine());

            CalculoAno(ano);

            Console.ReadLine();
        }



        private static int CalculoAno(int ano)
        {
            if (ano % 4 == 0 && ano != 100 || ano % 400 == 0)
            {
                Console.Write("Ano Bissexto!");
            }
            else
            {
                Console.Write("Não é ano bissexto!");
            }

            return ano;
        }

        
	
    }
}
