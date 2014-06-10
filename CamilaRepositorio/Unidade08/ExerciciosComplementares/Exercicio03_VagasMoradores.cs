using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio03_VagasMoradores
    /* 3) Para controlar o estacionamento de um condomínio, devemos implementar um programa em C# para gerar os cartões das vagas dos moradores. Nos 
    cartões, é necessário constar o número do bloco e o número do apartamento. Nesse condômino, há três blocos numerados de 1 a 3. Em cada bloco, há
    9 andares. Em cada andar, há 4 apartamentos. No primeiro andar, os números dos
    Apartamentos são: 11, 12, 13 e 14. No segundo andar, os números dos apartamentos são: 21, 22, 23 e 24. Nos outros andares, a lógica de numeração
     é a mesma. */

    {
        public static int bloco, andar, apartamento;

        public static void Main03(string[] args)

        {
            Random gerador = new Random();
            bloco = gerador.Next(1, 3);
            andar = gerador.Next(1, 9);

            if (andar == 1)
            {
                apartamento = gerador.Next(11, 14);
            }
            if (andar == 2)
            {
                apartamento = gerador.Next(21,24);
            }
            if (andar == 3)
            {
                apartamento = gerador.Next(31, 34);
            }
            if (andar == 4)
            {
                apartamento = gerador.Next(41, 44);
            }
            if (andar == 5)
            {
                apartamento = gerador.Next(51, 54);
            }
            if (andar == 6)
            {
                apartamento = gerador.Next(61, 64);
            }
            if (andar == 7)
            {
                apartamento = gerador.Next(71, 74);
            }
            if (andar == 8)
            {
                apartamento = gerador.Next(81, 84);
            }
            if (andar == 9)
            {
                apartamento = gerador.Next(91, 94);
            }
            Console.WriteLine(bloco + "º Bloco, " + andar + "º Andar, Apartamento : " + apartamento);

            Console.ReadLine();
        }
    }
}
