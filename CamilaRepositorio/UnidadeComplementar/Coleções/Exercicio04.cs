using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnidadeComplementar.Coleções
{
    internal class Exercicio04

        //4) Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. Adicione dados em cada uma delas e no final liste-os
    {
        public static ArrayList _ArrayList = new ArrayList(1);
        public static List<string> _ListString = new List<string>();
        public static List<int> _List = new List<int>();
        public static List<int> _ListInt = new List<int>() { 10, 23, 3, 17, 78, 19 };
        public static Dictionary<char, string> _Dictionary = new Dictionary<char, string>();

        public static void Main04(string[] args)
        {
            // ---------- ArrayList ----------
            _ArrayList.Add("Nome: Camila");
            _ArrayList.Add("Altura: 1.65");
            _ArrayList.Add("Sexo: F");

            Console.WriteLine("----------- ArrayList -----------");
            Console.WriteLine();
            foreach (var item in _ArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // ----------- List ----------
            _ListInt.Add(100);
            _ListInt.Add(10);
            _ListInt.Add(20);
            _ListInt.Add(5);

            Console.WriteLine("---------- List --------------");
            Console.WriteLine();
            Console.WriteLine("Maior valor: {0} ", _ListInt.Max());
            Console.WriteLine("Menor valor: {0} ", _ListInt.Min());
            Console.WriteLine("Media: {0} ", _ListInt.Average());
            Console.WriteLine("Soma: {0} ", _ListInt.Sum());

            Console.WriteLine();
            //---------- Dictionary -----------
            Console.WriteLine("---------- Dictionary ----------");
            Console.WriteLine();

            _Dictionary.Add('a', "2");
            _Dictionary.Add('b', "22");
            _Dictionary.Add('c', "222");
            _Dictionary.Add('d', "3");
            _Dictionary.Add('e', "33");
            _Dictionary.Add('f', "333");
            _Dictionary.Add('g', "4");
            _Dictionary.Add('h', "44");
            _Dictionary.Add('i', "444");
            _Dictionary.Add('j', "5");
            _Dictionary.Add('k', "55");
            _Dictionary.Add('l', "555");
            _Dictionary.Add('m', "6");
            _Dictionary.Add('n', "66");
            _Dictionary.Add('o', "666");
            _Dictionary.Add('p', "7");
            _Dictionary.Add('q', "77");
            _Dictionary.Add('r', "777");
            _Dictionary.Add('s', "7777");
            _Dictionary.Add('t', "8");
            _Dictionary.Add('u', "88");
            _Dictionary.Add('v', "888");
            _Dictionary.Add('w', "9");
            _Dictionary.Add('x', "99");
            _Dictionary.Add('y', "999");
            _Dictionary.Add('z', "9999");

            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();
            nome = nome.ToLower();
            char[] array = nome.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                foreach (var item in _Dictionary)
                {
                    if (array[i] == item.Key)
                    {
                        Console.Write(item.Value + " ");                        
                    }
                }
            }

            Console.ReadLine();
        }
    }
}