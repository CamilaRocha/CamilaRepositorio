using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection String
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\CamilaRepositorio\CamilaRepositorio\Unidade12\BancoDeDados\CamilaDB.mdf;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Abrindo Conexão
            sqlConnection.Open();

            // Realizar Comandos

            // Seleciona Todos os Produtos

            //SqlCommand command = new SqlCommand("Select * From Produto", sqlConnection);

            //SqlDataReader reader = command.ExecuteReader ();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Nome"]);
            //}

            // Atualiza Produto 

            //    Console.WriteLine("Digite o Id do produto a ser editado: ");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o nome do produto: ");
            //    string nome = Console.ReadLine();
            //    string sqlUpdate = String.Format("Update Produto Set Nome = '{0}' Where Id = {1}", nome, id);
            //    SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);



            //    try
            //    {
            //        int i = command.ExecuteNonQuery();
            //        if (i > 0)
            //        {
            //               Console.WriteLine("Produto deletado com sucesso! ");
            //         }
            //    }
            //    catch (SqlException e)
            //    {

            //        Console.WriteLine(e.ToString());
            //    }


            //}

            // Deleta Produto

            //Console.WriteLine("Digite o Id do produto a ser deletado: ");
            //int id = int.Parse(Console.ReadLine());
            //string sqlDelete = String.Format("Delete From Produto Where Id = {0}", id);
            //SqlCommand command = new SqlCommand(sqlDelete, sqlConnection);

            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        Console.WriteLine("Produto deletado com sucesso! ");
            //    }
               
            //}
            //catch (SqlException e)
            //{

            //    Console.WriteLine(e.ToString());
            //}

             //Inserir Produto

            Console.WriteLine("Digite o nome do Produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a unidade do Produto: ");
            string unidade = Console.ReadLine();
            Console.WriteLine("Digite o valor do Produto: ");
            decimal valor = decimal.Parse(Console.ReadLine());


            string sqlInsert = String.Format("Insert Into Produto (Nome, Unidade, Valor) Values ('{0}', '{1}', '{2}'", nome, unidade, valor);
            SqlCommand command = new SqlCommand(sqlInsert, sqlConnection);

            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Produto inserido com sucesso! ");
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.ToString());
            }

            // Encerra a Conexão
            sqlConnection.Close();

        }
    }
}
