using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.FunçõesOuMétodos
{
    class JurosCompostos
    {
        // Implemente um programa em C# definindo um método que realize o cálculo do montante obtido com a aplicação de juros compostos.

        public static void Main02(string[] args)
        {
            double juros, montante, capital, tempo;

            Console.Write("Informe o capital: ");
            capital = double.Parse(Console.ReadLine());
            Console.Write("Informe o tempo: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            juros = double.Parse(Console.ReadLine());
            juros = juros / 100;

            montante = MontanteCalculo(capital, tempo, juros);
            Console.WriteLine("O montante é igual a: " + montante);

            Console.ReadLine();
        }

        private static double MontanteCalculo(double capital, double tempo, double juros)
        {
            double calculo = capital * Math.Pow((1 + juros), tempo);
            return calculo;
        }
    }
}
