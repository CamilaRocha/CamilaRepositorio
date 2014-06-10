using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.FunçõesOuMétodos
{
    class MassaCorporal
    // Implemente um programa em C# definindo um método que realize o cálculo do índice de massa corporal e outro que determina a situação da pessoa a
    // partir desse índice.

    {
        public static void Main03(string[] args)
        {
            double peso, altura, calculo;

            Console.Write("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());
            calculo =  IMC(peso, altura);

            if (calculo < 18.5)
            {
                Console.Write("Você está abaixo do peso ideal!");
            }
            else if (calculo > 18.5 && calculo <= 24.9)
            {
                Console.Write("Parabéns, peso normal!");
            }
            else if (calculo >= 25 && calculo <= 29.9)
            {
                Console.Write("Sobrepeso!");
            }
            else if (calculo >= 30 && calculo <= 34.9)
            {
                Console.Write("Obesidade grau I!");
            }
            else if (calculo >= 35 && calculo <= 39.9)
            {
                Console.Write("Obesidade grau II!");
            }
            else 
            {
                Console.Write("Obesidade grau III!");
            }

            Console.ReadLine();
        }


        private static double IMC(double peso, double altura)
        {
            double calculo = peso / Math.Pow((altura), 2);
            return calculo;

        }

    }

}
