using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Coleções
{
    class Exercicio04
    
    //4) Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. Adicione dados em cada uma delas e no final liste-os

    {
        public static ArrayList _ArrayList = new ArrayList();
        public static List<int> _ListInt = new List<int>();     // possui muito mais metodos aberto para usar
        public static IList<string> _IListInt = new List<string>(); // IList so implementa List
        public static Dictionary<int, string> _Dictionary = new Dictionary<int, string>();

        public static void Main04(string[] args)
        {

            _Dictionary.Add('1', "2");
            _Dictionary.Add('2', "22");
            _Dictionary.Add('3', "222");
            _Dictionary.Add('4', "3");
            _Dictionary.Add('5', "33");
            _Dictionary.Add('6', "333");
            _Dictionary.Add('7', "4");

            foreach (var item in _Dictionary)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
