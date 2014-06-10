using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExercicioSlide
{
    class Operadores

    {
        public static double adicao, subtracao, multiplicacao, divisao, modulo, x, y, nota;
        public static int a, b, divisao2;
        public static void Main2(string[] args)

        {
            //-------------------- Exercicio01 - operações aritméticas -------------------
            Console.WriteLine("Informe o valor de x: "); 
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de y: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine();
            adicao = x + y;
            subtracao = x - y;
            multiplicacao = x * y;
            divisao = x / y;
            modulo = x % y;

            Console.WriteLine("Soma = " + adicao);
            Console.WriteLine(" Subtração = " + subtracao);
            Console.WriteLine("Multiplicação = " + multiplicacao);
            Console.WriteLine("Divisao = " + divisao);
            Console.WriteLine("Modulo = " + modulo);


            Console.WriteLine();
            Console.WriteLine();

            

            //-------------------- Exercicio02 - Operadores de divisao de inteiros - a parte fracionaria é descartada --------------------
            Console.WriteLine("Informe o valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ReadLine();
            divisao2 = a / b;
            Console.WriteLine("Divisao inteiros: " + divisao);
            Console.WriteLine();
            Console.WriteLine();

            //-------------------- Exercicio03 - Concatenação --------------------
            string testeConcatenacao = 1 + 2 + 3 + "testando";
            string testeConcatenacao2 = "testando" + 1 + 2 + 3;
            Console.WriteLine(testeConcatenacao);
            Console.WriteLine(testeConcatenacao2);

            //-------------------- Casting --------------------
            System.Console.WriteLine((double)a / b);


            //-------------------- Exercicio04 - operadores atribuição --------------------

            int valor = 10; // valor = 10

            valor += 1; //  valor = 11
            valor -= 1; // valor = 10
            valor *= 1; // valor = 10
            valor /= 1; // valor = 10
            valor %= 1 ; // valor = 0
            valor++; // valor = 1
            valor--; // valor = 0

            Console.WriteLine();
            Console.WriteLine();

            //-------------------- Exercicio05 - operadores relacionais --------------------
            int i = 10;
            bool t = false;
            t = (i == 10);
            t = (i != 10);
            t = (i >= 6);
            t = (i <= 2);

            Console.WriteLine();


            //-------------------- Exercicio06 - operadores logicos --------------------
            int c = 15;
            bool j = false;

            j = (c == 10 && c != 15);
            j = (c <= 20 || c >= 10);
            j = (c == 15 ^ c <= 20);    // xor

            Console.WriteLine();

           
            Console.ReadLine();
             

            //-------------------- Operador ternário --------------------
           
            string resultado = nota >= 0.5 ? " aprovado " : "reprovado";
            System.Console.WriteLine(nota >= 0.5 ? "aprovado " : " reprovado ");

           // Pre incremento e Pós incremento
           // Pós incremento mais utitilizado
            int r = 10;

            int g = ++r + r--; // -- nao mostra o resultado na hora.
            System.Console.WriteLine(g);


            Console.ReadLine();

            //-------------------- Exercicio07 - Operadores Ternarios --------------------

            string resposta = nota >= 7 ? " reprovado " : " aprovado ";
            System.Console.WriteLine(nota >= 7 ? "reprovado" : "aprovado ");
            Console.WriteLine();


            //-------------------- Exercicio08 - Negação --------------------



            //-------------------- Exercicio09 - Incremento e Decremento --------------------
            int w = 30;

            int d = ++w + ++r + r--;
            System.Console.WriteLine();


            // -------------------- Operadores String --------------------

            /* descobrir a quantidade de caracteres de uma string 
            string s = "Nome da Pessoa";

            int length = s.Length;

            Console.WriteLine(length);
            Console.ReadLine(); */
             
            /* Recuperar um caractere de acordo com a sua posição na string 
            string p = "Nome da Pessoa";

            char f = p[0];

            Console.WriteLine(f); */

            /* Podemos verificar se uma determinada sequencia de caracter esta contida em um string 
            string s = "Apostila de C#";

            bool resultado1 = s.StartsWith("C#");
            bool resultado2 = s.StartsWith("Apostila");

            ----- False -----
            Console.WriteLine(resultado1);

            ----- True -----
            Console.WriteLine(resultado2);

            /* Podemos extrair um trecho de uma string.
            string s1 = " Camila Rocha ";

            string s2 = s1.Substring(1,1);
            string s3 = s1.Substring(0, 6);

             ----- Rocha -----
            Console.WriteLine(s2);

            ----- Camila -----
            Console.WriteLine(s3);

            /* Podemos eliminar os espaços em branco do começo e do término de uma string.
            string s1 = "  Camila Rocha    ";

            string s2 = s1.Trim();

            ----- " Camila Rocha " -----
            Console.WriteLine(s2);

             /* Letra Maiuscula 
            string nome = "camila";
            nome.ToUpper();
             
            /* Letra Minuscula
            nome.ToLower();
             
             
            /* Separador
            nome = "Camila-Rocha";
            string[] stringArray = nome.Split('-');
             
            ----- stringArray[0] = Camila
            stringArray[1] = Rocha
            nome.Replace('-', ' ');


            /* DateTime dt = new DateTime(2010, 8, 27);

            ----- Acrescentando 140 dias -----
            dt = dt.AddDays(140);

            ----- Subtraindo 2 anos -----
            dt = dt.AddYears(-2);

            ----- Acrescentando 20 segundos -----
            dt = dt.AddSeconds(20); */
            

            
        }
    }
}
