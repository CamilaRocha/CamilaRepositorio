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

            //SqlCommand command = new SqlCommand("Select * From Cliente", sqlConnection);

            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["PrimeiroNome"]);
            //}

            // Atualiza Produto 

                //Console.WriteLine("Digite o Id do nome a ser editado: ");
                //int id = int.Parse(Console.ReadLine());
                //Console.WriteLine("Digite o novo nome: ");
                //string PrimeiroNome = Console.ReadLine();
                //string sqlUpdate = String.Format("Update Cliente Set PrimeiroNome = '{0}' Where Id = {1}", PrimeiroNome, id);
                //SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);



                //try
                //{
                //    int i = command.ExecuteNonQuery();
                //    if (i > 0)
                //    {
                //           Console.WriteLine("Nome editado com sucesso! ");
                //     }
                //}
                //catch (SqlException e)
                //{

                //    Console.WriteLine(e.ToString());
                //}


         

            // Deleta Produto

            //Console.WriteLine("Digite o Id do nome a ser deletado: ");
            //int id = int.Parse(Console.ReadLine());
            //string sqlDelete = String.Format("Delete From Cliente Where Id = {0}", id);
            //SqlCommand command = new SqlCommand(sqlDelete, sqlConnection);

            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        Console.WriteLine("Nome deletado com sucesso! ");
            //    }

            //}
            //catch (SqlException e)
            //{

            //    Console.WriteLine(e.ToString());
            //}

            //Inserir Produto

            Console.WriteLine("Digite o novo Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite sua cidade: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Digite seu estado: ");
            string estado = Console.ReadLine();
            Console.WriteLine("Digite seu CEP: ");
            int cep = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu CPF: ");
            int cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu telefone: ");
            int telefone = int.Parse(Console.ReadLine());


            string sqlInsert = String.Format("Insert Into Cliente(PrimeiroNome, Sobrenome, Cidade, Estado, CEP, CPF, Telefone) Values('{0}', '{1}','{2}', '{3}', {4}, {5}, {6})", nome, sobrenome, cidade, estado, cep, cpf, telefone );
            SqlCommand command = new SqlCommand(sqlInsert, sqlConnection);

            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Nome inserido com sucesso! ");
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
