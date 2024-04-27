using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;


namespace Livraria
{
    class DAOLivro
    {

        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public long[] codigo;
        public string[] titulo;
        public string[] autor;
        public string[] editora;
        public string[] genero;
        public long[] ISBN;
        public string[] quantidade;
        public string[] preco;
        public int i;
        public int contador;
        public string msg;
        //Construtor
        public DAOLivro()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=BibliotecaTI20N;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//Abrir a conexão
                Console.WriteLine("Conectado!");//Teste
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo deu errado!\n\n" + erro);
                conexao.Close();//Fechar a conexão com o banco
            }
        }//fim do construtor

        public void Inserir(long codigo, string titulo, string autor, string editora,
                           string genero, long ISBN,
                           string quantidade, string preco)
        {
            try
            {
                

                //Declarei as variáveis e preparei o comando
                dados = $"('{codigo}','{titulo}','{autor}','{editora}','{genero}','{ISBN}'," +
                        $"'{quantidade}','{preco}')";
                comando = $"Insert into pessoa values {dados}";
                //Engatilhar a inserção do banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Ctrl + Enter
                                                              //Mostrar na tela
                Console.WriteLine(resultado + " linha afetada");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo deu errado!\n\n" + erro);
            }
        }//fim do método

        public void PreencherVetor()
        {
            string query = "select * from pessoa";//Coletar os dados do banco

            //Instanciar
            codigo = new long[100];
            titulo = new string[100];
            autor = new string[100];
            editora = new string[100];
            genero = new string[100];
            ISBN = new long[100];
            quantidade = new string[100];
            preco = new string[100];

            //Preencher
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                titulo[i] = "";
                autor[i] = "";
                editora[i] = "";
                genero[i] = "";
                ISBN[i] = 0;
                quantidade[i] = "";
                preco[i] = "";
            }//fim do for

            //Preparar o comando do select
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt64(leitura["CPF"]);
                titulo[i] = leitura["nome"] + "";
                autor[i] = leitura["telefone"] + "";
                editora[i] = leitura["endereco"] + "";
                genero[i] = leitura["login"] + "";
                ISBN[i] = Convert.ToInt64(leitura["ISBN"]);
                quantidade[i] = leitura["situacao"] + "";
                preco[i] = leitura["posicao"] + "";
                i++;
                contador++;
            }//fim do while
            leitura.Close();//Fecha a conexão com o banco
        }//fim do método

        public string ConsultarTudo()
        {
            PreencherVetor();//Preenche os vetores
            msg = "";
            for (i = 0; i < contador; i++)
            {
                msg += "CPF: " + codigo[i] +
                       ", titulo: " + titulo[i] +
                       ", autor: " + autor[i] +
                       ", editora: " + editora[i] +
                       ", genero: " + genero[i] +
                       ", ISBN: " + ISBN[i] +
                       ", quantidade: " + quantidade[i] +
                       ", preco: " + preco[i];
            }//fim do for

            return msg;
        }//fim do método

        public string ConsultarIndividual(long codCodigo)
        {

            PreencherVetor();
            for (i = 0; i < contador; i++)
            {

                if (codigo[i] == codCodigo)
                {

                    msg = ",codigo: " + codigo[i] +
                          ", titulo: " + titulo[i] +
                          ", autor: " + autor[i] +
                          ", editora: " + editora[i] +
                          ", genero: " + genero[i] +
                          ", ISBN: " + ISBN[i] +
                          ", quantidade: " + quantidade +
                          ", preco: " + preco[i];
                    return msg;
                }//Fim do If

            }//Fim do For
            return "Código informado não é válido!";

        }//Fim do Consultar

        public string Atualizar(long codCodigo, string campo, string novoDado)
        {
            try
            {

                string query = "update pessoa set " + campo + " = '" + novoDado + "' where CPF = '" + codCodigo + "'";
                //Executar
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + "linha afetada!";
            }
            catch (Exception ex)
            {

                return "Algo deu errado!\n\n\n" + ex;


            }


        }

        public string Atualizar(int codCodigo, string campo, int novoDado)
        {
            try
            {

                string query = "update pessoa set " + campo + " = '" + novoDado + "' where CPF = '" + codCodigo + "'";
                //Executar
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + "linha afetada!";
            }
            catch (Exception ex)
            {

                return "Algo deu errado!\n\n\n" + ex;


            }


        }

        public string Excluir(long codCodigo)
        {
            try
            {

                string query = "update pessoa set situacao = 'Inativo' where CPF = '" + codCodigo + "'";
                //Executar
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + "linha afetada!";
            }
            catch (Exception ex)
            {

                return "Algo deu errado!\n\n\n" + ex;


            }


        }

    }
}
