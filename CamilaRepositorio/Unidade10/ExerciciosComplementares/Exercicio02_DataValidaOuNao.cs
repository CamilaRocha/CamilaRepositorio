using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exercicio02_DataValidaOuNao_
    /* 2) Implemente um método que verifica se uma determinada data é válida ou não. Lembre-se que Janeiro, Março, Maio, Julho, Agosto, Outubro
    e Dezembro possuem 31 dias; Abril, Junho, Setembro e Novembro possuem 30 dias; e Fevereiro possui 28 dias em anos não bissextos e 29 dias
    em anos bissextos. */

    {
        public static void Main02(string[] args)
        {
            int data, mes;

            Console.Write("Informe a data desejada: ");
            data = int.Parse(Console.ReadLine());
            Console.Write("Informe o mes: ");
            mes = int.Parse(Console.ReadLine());

            DataValida(data, mes);

            Console.ReadLine();

        }



       private static int DataValida (int data, int mes)
        {
            if (data < 31 && mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Data Válida!");
            }
            else if (data < 32 && mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12 )
            {
                Console.WriteLine("Data Válida!");
            }
            else if (data < 29 && mes == 2)
            {
                Console.WriteLine("Data Válida!");
            }
            else
            {
                Console.WriteLine("Data Inválida!");
            }
            return mes;
        }
    }
}
