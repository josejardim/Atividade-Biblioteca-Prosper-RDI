using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Biblioteca
    {
        public List<Pessoa> Pessoas { get; set; }
        public List<Livro> Livros { get; set; } 

        public void CadastrarPessoa(Pessoa pessoa)
        {
            if (Pessoas == null)
                Pessoas = new List<Pessoa>();
            Pessoas.Add(pessoa);
        }
        public void CadastrarLivro (Livro livro)
        {
            if (Livros == null)
                Livros = new List<Livro>();
            Livros.Add(livro);
        }
        public void EmprestarLivroBiblioteca (int idLivro, int idPessoa)
        {
            Livro LivrosEmprestados = new Livro();
            LivrosEmprestados.EmprestarLivro(idLivro);
            LivrosEmprestados.EmprestarLivro(idPessoa);
        }
        public void DevolverLivroBiblioteca (int idLivro, int idPessoa)
        {
            Livro DevolverLivro = new Livro();
            DevolverLivro.DevolverLivro(idLivro);
            DevolverLivro.DevolverLivro(idPessoa);
        }
        public Livro ConsultarLivroPorId(int id)
        {
            return Livros.Where(idLivro => idLivro.ObterIdLivro() == id).FirstOrDefault();
        }
        public Pessoa ConsultarPessoaPorId(int id)
        {
            return Pessoas.Where(idPessoa => idPessoa.ObterIdPessoa() == id).FirstOrDefault();
        }
    }
}
