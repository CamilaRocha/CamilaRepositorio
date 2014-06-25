using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio
         
    {
        public static ArrayList _ArrayList = new ArrayList();
        public static List<int> _ListInt = new List<int>();     // possui muito mais metodos aberto para usar
        public static IList<string> _IListInt = new List<string>(); // IList so implementa List
        public static Dictionary<int, string> _Dictionary = new Dictionary<int, string>();


        public static void Main22(string[] args)
        {

            // ------------- ArrayList -----------
            _ArrayList.Add(1);
            _ArrayList.Add("Camila");
            _ArrayList.Add(1.65);
            _ArrayList.Add('F');


            // ---------- Remover ----------
            _ArrayList.Remove(1); // remove por objeto
            _ArrayList.Insert(3, 1);  // insere na posição
            int index = _ArrayList.IndexOf(1);  // mostra a  posição
            _ArrayList.LastIndexOf(1); // mostra a ultima posição
            _ArrayList.Clear();  // limpa a lista
            //_ArrayList.RemoveAt(3);   // remove pela posição

            //_ArrayList[1] = 1 + 1;
            _ArrayList.Sort();   // ordena crescente
            _ArrayList.Reverse(); // ordena decrescente

            // ------------ List -----------

            // Adicionar 

            //_ListInt.Add(12);
            //_ListInt.Add(13);
            //_ListInt.Add(56);
            //_ListInt.Add(16);
            //_ListInt.Add(2);

            //double media = _ListInt.Max();
            //double av = _ListInt.Average();
            //double min = _ListInt.Min();
            //double soma = _ListInt.Sum();






            //_Dictionary.Add('1', "2");
            //_Dictionary.Add('2', "22");
            //_Dictionary.Add('3', "222");
            //_Dictionary.Add('4', "3");
            //_Dictionary.Add('5', "33");
            //_Dictionary.Add('6', "333");
            //_Dictionary.Add('7', "4");

            Console.ReadLine();
        }
    }
}
