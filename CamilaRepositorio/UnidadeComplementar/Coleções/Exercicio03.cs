using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio03

        //3) Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada utilizando a ideia do algoritmo da inserção. No final, 
    // o programa deve mostrar todos os nomes ordenados alfabeticamente. 
    {

        public static ArrayList _ArrayList = new ArrayList();

        public static void Main03(string[] args)
        {
            _ArrayList.Add("Camila");
            _ArrayList.Add("Luana");
            _ArrayList.Add("Marcos");
            _ArrayList.Add("Diego");
            _ArrayList.Add("Antonio");
            _ArrayList.Add("Maria");
            _ArrayList.Add("Laura");
            _ArrayList.Add("Diogo");

            _ArrayList.Sort();

            foreach (var item in _ArrayList)
            {
                Console.WriteLine(item);
            }





            Console.ReadLine();
        }
    }
}
