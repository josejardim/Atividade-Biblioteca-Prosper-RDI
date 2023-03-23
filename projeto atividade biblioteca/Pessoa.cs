using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }

        public void AdicionarLivroLista(Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }
        public void RemoverLivroLista(Livro idLivro)
        {
            LivrosEmprestados.Remove(idLivro);
        }
        public void CadastrarIdPessoa(int idPessoa)
        {
            Id += idPessoa;
        }
        public void CadastrarNomePessoa(string NomePessoa)
        {
            Nome += NomePessoa;
        }
        public string ObterNomePessoa()
        {
            return Nome;
        }
        public int ObterIdPessoa()
        {
            return Id;
        }
    }
}
