using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlLivro
    {

        DAOLivro person;//Conexão com pessoa
        Livro model;//Conectar com a classe pessoa
        private int opcao;
        public ControlLivro()
        {
            person = new DAOLivro();
            model = new Livro();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;
        }//fim do construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do modificarOpcao

        public void Menu()
        {
            Console.WriteLine("Menu - Livro" +
                              "\nEscolha uma das opções abaixo: " +
                              "\n1. Cadastrar Livro" +
                              "\n2. Consultar Tudo" +
                              "\n3. Consultar Individual" +
                              "\n4. Atualizar Titulo" +
                              "\n5. Atualizar Autor" +
                              "\n6. Atualizar Editora" +
                              "\n7. Atualizar Genero" +
                              "\n8. Atualizar Quantidade" +
                              "\n9. Atualizar Preço" +
                              "\n10. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            Menu();//Mostrar o menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o Código: ");
                    long codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nome do livro: ");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("Informe o nome do autor: ");
                    string autor = Console.ReadLine();

                    Console.WriteLine("Informe a editora: ");
                    string editora = Console.ReadLine();

                    Console.WriteLine("Informe o genero: ");
                    string genero = Console.ReadLine();

                    Console.WriteLine("Informe o ISBN: ");
                    long ISBN = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade: ");
                    string quantidade = Console.ReadLine();

                    Console.WriteLine("Informe o preço: ");
                    string preco = Console.ReadLine();

                    //Chamar o método cadastrar
                    person.Inserir(codigo, titulo, autor, editora, genero, ISBN, quantidade, "Ativo", preco);
                    break;
                case 2:

                    //Mostrar os dados
                    Console.WriteLine(person.ConsultarTudo());

                    break;
                case 3:
                    Console.WriteLine("Informe o código qeu deseja consultar: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine(person.ConsultarIndividual(codigo));
                    break;
                case 4:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo título do livro: ");
                    titulo = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(codigo, "titulo", titulo));
                    break;
                case 5:
                    Console.WriteLine("Informe o CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o autor: ");
                    autor = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(codigo, "autor", autor));
                    break;
                case 6:
                    Console.WriteLine("Informe o CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a editora: ");
                    editora = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(codigo, "editora", editora));
                    break;
                case 7:
                    Console.WriteLine("Informe o CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o genero: ");
                    genero = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(codigo, "genero", genero));
                    break;
                
                case 8:
                    Console.WriteLine("Informe o CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade: ");
                    quantidade = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(codigo, "quantidade", quantidade));
                    break;

                case 9:
                    Console.WriteLine("Informe o CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o cargo: ");
                    preco = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(codigo, "preco", preco));
                    break;
                case 10:
                    Console.WriteLine("Informe o CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    person.Excluir(codigo);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }//fim do switch
        }//fim da operacao

    }
}
