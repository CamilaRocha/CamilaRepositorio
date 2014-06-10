using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.FunçõesOuMétodos
{
    class ConsumoDeCombustivel
    {
        // Implemente um programa em C# definindo um método que realize o cálculo do consumo de combustível de um veículo.

        public static void Main01(string[] args)
        {
            double km, litros, km_litros;

            Console.WriteLine("Informe a quantidade de litros utilizada: ");
            litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos quilômetros foram andados: ");
            km = double.Parse(Console.ReadLine());
            km_litros = CalculoKm(litros, km);
            Console.WriteLine("Foram feitos " + km_litros + " Km/L");

            Console.ReadLine();
        }


        private static double CalculoKm(double km, double litros)
        {
            double calculo = litros / km;
            return calculo;
        }



        
    }
}
