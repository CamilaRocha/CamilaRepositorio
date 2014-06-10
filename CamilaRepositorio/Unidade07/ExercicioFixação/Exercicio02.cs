using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExercicioFixação
{
    class Exercicio02
    /*   A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um algoritmos para coletar dados sobre o salário e número de filhos
    de cada habitante e após as leituras, escrever: 
   a) Média de salário da população 
   b) Média do número de filhos 
   c) Maior salário dos habitantes 
   d) Percentual de pessoas com salário menor que R$ 150,00 
   Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo” */


    {
        public static double salario, media_sal, media_filhos, percentual, maior_salario;
        public static int contador, filhos;
        public static void Main2(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Informe quantos filhos: ");
                filhos = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o salario: ");
                salario = double.Parse(Console.ReadLine());
                media_sal += salario / 2;
                media_filhos += filhos / 2;
                Console.WriteLine();
                Console.Clear();

                if (i == 0)
                {
                    maior_salario = salario;
                }
                else if (salario > maior_salario)
                {
                    maior_salario = salario;
                }

                if (salario < 150)
                {
                    contador++;
                }
            }

            percentual = (contador / 2) * 100;
            Console.WriteLine("O maior salário é R$" + maior_salario);
            Console.WriteLine("A média de filhos é igual a " + media_filhos);
            Console.WriteLine("A média de salário é igual a R$ " + media_sal);
           
            Console.ReadLine();


            


        }
    }
}
