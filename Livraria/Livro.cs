using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livro
    {
        //Encapsulamento = Deixar as variavéis privadas
        private long codigo;
        private string titulo;
        private string autor;
        private string editora;
        private string genero;
        private long ISBN;
        private string quantidade;
        private string preco;

        //Método Construtor
        public Livro()
        {
            ModificarCodigo = 0;
            ModificarTitulo = "";
            ModificarAutor = "";
            ModificarEditora = "";
            ModificarGenero = "";
            ModificarISBN = 0;
            ModificarQuantidade = "";
            ModificarPreco = "";
        }// Fim do Construtor

        //Métodos Modificadores = Gets e Sets
        public long ModificarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }

        }//Fim do Modificar

        public string ModificarTitulo
        {
            get { return titulo; }
            set { this.titulo = value; }

        }//Fim do Modificar

        public string ModificarAutor
        {
            get { return autor; }
            set { this.autor = value; }

        }//Fim do Modificar

        public string ModificarEditora
        {
            get { return editora; }
            set { this.editora = value; }

        }//Fim do Modificar

        public string ModificarGenero
        {
            get { return genero; }
            set { this.genero = value; }

        }//Fim do Modificar

        public long ModificarISBN
        {
            get { return ISBN; }
            set { this.ISBN = value; }

        }//Fim do Modificar

        public string ModificarQuantidade
        {
            get { return quantidade; }
            set { this.quantidade = value; }

        }//Fim do Modificar

        public string ModificarPreco
        {
            get { return preco; }
            set { this.preco = value; }

        }//Fim do Modificar

        //Métodos - CRUD
        public void Cadastrar(long codigo, string titulo, string autor, string editora, string genero, long ISBN, string quantidade, string preco)
        {

            ModificarCodigo = codigo;
            ModificarTitulo = titulo;
            ModificarAutor = autor;
            ModificarEditora = editora;
            ModificarGenero = genero;
            ModificarISBN = ISBN;
            ModificarQuantidade = quantidade;
            ModificarPreco = preco;

        }// Fim do Void

        public string ConsultarReposicao(long codigo)
        {
            string consulta = "";
            if (ModificarCodigo == codigo)
            {
                consulta = "\nCodigo: " + ModificarCodigo + 
                           "\nTitulo: " + ModificarTitulo + 
                           "\nAutor: " + ModificarAutor + 
                           "\nEditora: " + ModificarEditora + 
                           "\nGenero: " + ModificarGenero + 
                           "\nISBN: " + ModificarISBN + 
                           "\nQuantidade: " + ModificarQuantidade + 
                           "\nPreco" + ModificarPreco;

            }
            else
            {
                consulta = "Número de Consulta não é válido!";
            }

            return consulta;

        }// Fim do Método

        public void AtualizarAutor(long codigo, string autor)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarAutor = autor;

            }
        }

        public void AtualizarEditora(long codigo, string editora)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarEditora = editora;

            }
        }

        public void AtualizarGenero(long codigo, string genero)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarGenero = genero;

            }
        }

        public void AtualizarISBN(long codigo, long ISBN)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarISBN = ISBN;

            }
        }

        public void AtualizarQuantidade(long codigo, string quantidade)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarQuantidade = quantidade;

            }
        }

        public void AtualizarPreco(long codigo, string preco)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarPreco = preco;

            }
        }

        public void Excluir(long codigo)
        {
            if (ModificarCodigo == codigo)
            {

                ModificarCodigo = 0;

            }
        }//Fim do Método
    }
}
