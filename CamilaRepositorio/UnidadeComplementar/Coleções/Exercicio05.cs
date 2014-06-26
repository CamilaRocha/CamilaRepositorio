using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar.Coleções
{
    class Exercicio05
    {
        public static void Main05(string[] args)
        {
                 var copaDoMundo = new Dictionary<string, char>();
            var grupos = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            var times = new List<string>
            {
                "Alemanha", "Argélia", "Argentina", "Austrália", "Bélgica",
                "Bósnia H.","Brasil", "Camarões","Colombia", "Chile", "Coreia do S.",
                "Costa do M.", "Costa R.", "Croácia", "Equador", "Espanha",
                "Estados U.", "França", "Gana", "Grécia", "Holanda", "Honduras",
                "Inglaterra", "Irã", "Itália", "Japão", "México", "Nigéria",
                "Portugal", "Rússia", "Suíça", "Uruguai"
            };

        
            var sort = new Random();

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    int time = sort.Next(0, times.Count);

                    copaDoMundo.Add(times[time], grupos[j]);
                    times.Remove(times[time]);
                }
            }
            int count = 0;
            foreach (var t in copaDoMundo)
            {
                if (count % 4 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("--------------");
                    Console.WriteLine(" GRUPO " + t.Value);
                    Console.WriteLine("--------------");
                }
                Console.WriteLine(" " + t.Key);
                count++;
            }

            Console.ReadLine();
        }
         
    }
}
