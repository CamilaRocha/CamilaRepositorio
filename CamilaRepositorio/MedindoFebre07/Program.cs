using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoFebreVII
{
    class Program
    {
        /* Implemente um algoritmo que armazene a idade, nome, sexo, altura, se é adulto ou não. Esses vetores devem ter 50 posições cada um. O
algoritmo deve ter métodos ou funções para inicializar seus vetores com os dados, os valores de idade, altura, sexo e se é adulto ou
não, podem ser gerados aletoriamente.
- A porcentagem dos que são adultos e dos que não são;
- A porcentagem do sexo masculino e feminino;
- A porcentagem dos mais altos que 1,70m;
- Listar todos da seguinte maneira: Nome: Thiago Sartor, Idade: 23, Sexo: ‘M’, Adulto: true
- Listar os 10 mais velhos;
- Listar os 5 mais novos;
- Listar a pessoa mais alta;
- Listar a pessoa mais baixa; */


        static void Main01(string[] args)
        {
            Random gerador = new Random();
            int TotalPessoas = 0;



            bool[] Adulto = new bool[50];
            string[] Nome = new string[50];
            int[] Idade = new int[50];
            double[] Altura = new double[50];
            int[] Sexo = new int[50];



            for (int i = 0; i < 50; i++)
            {
                TotalPessoas++;
                Nome[i] = "Nome" + i;
                Sexo[i] = gerador.Next(0, 2);
                if (Sexo[i] == 1)




                    Idade[i] = gerador.Next(0, 100);
                if (Idade[i] > 18)
                {
                    Adulto[i] = true;
                }
                else
                {
                    Adulto[i] = false;
                }



                Console.WriteLine("Nome: " + Nome[i] + ", Sexo: " + Sexo[i] + ", Idade: " + Idade[i] + ", Adulto: " + Adulto[i]);
                Console.WriteLine();




            }





            Console.ReadLine();
        }


    }
}