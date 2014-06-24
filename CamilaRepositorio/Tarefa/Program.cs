using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(145);
            al.Add(718);
            al.Add(333);
            al.Add(5556);
            al.Add(124);
            al.Add(232);
            al.Add(98);
            al.Add(0);
            al.Add(6);
            al.Add(16);
            al.Add(76);
            al.Add(66);
            al.Add(56);
            al.Add(6);
            al.Add(6);
            al.Add(6);

            al.Add(6);
            al.Add(145);
            al.Add(718);
            al.Add(333);
            al.Add(5556);
            al.Add(124);
            al.Add(232);
            al.Add(98);
            al.Add(0);
            al.Add(6);
            al.Add(16);
            al.Add(76);
            al.Add(66);
            al.Add(56);
            al.Add(6);
            al.Add(6);
            al.Add(6);

            al.Add(6);

            al.Add(145);
            al.Add(718);
            al.Add(333);
            al.Add(5556);
            al.Add(124);
            al.Add(232);
            al.Add(98);
            al.Add(0);
            al.Add(6);
            al.Add(16);
            al.Add(76);
            al.Add(66);
            al.Add(56);
            al.Add(6);
            al.Add(6);
            al.Add(6);

            al.Add(6);
            al.Add(145);
            al.Add(718);
            al.Add(333);
            al.Add(5556);
            al.Add(124);
            al.Add(232);
            al.Add(98);
            al.Add(0);
            al.Add(6);
            al.Add(16);
            al.Add(76);
            al.Add(66);
            al.Add(56);
            al.Add(6);
            al.Add(6);
            al.Add(6);

            al.Add(6);
            Console.WriteLine("Capacidade do array: {0} ", al.Capacity);
            Console.WriteLine("Total adicionado: {0}", al.Count);
            

            Console.Write("Numeros adicionados:  ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Ordem crescente: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
