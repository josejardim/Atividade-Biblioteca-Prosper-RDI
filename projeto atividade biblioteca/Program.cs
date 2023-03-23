using System.Security.Cryptography.X509Certificates;

namespace Atividade
{
    internal class Program
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1 - Cadastrar Pessoa");
            Console.WriteLine("2 - Cadastrar Livro");
            Console.WriteLine("3 - Emprestar Livro");
            Console.WriteLine("4 - Devolver Livro");
            Console.WriteLine("5 - Listar todos os livros");
            Console.WriteLine("6 - Listar todas as pessoas cadastradas");
            Console.WriteLine("7 - Listar todos os livros emprestados");

        } 
        static void Main(string[] args)
        {
            int opcao;

            Pessoa pessoa = new Pessoa();
            Livro livro = new Livro();
            Biblioteca biblioteca = new Biblioteca();

            do
            {
                MostrarMenu();
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Escreva seu nome: ");
                    string nome = Console.ReadLine();
                    pessoa.Nome = nome;
                    pessoa.CadastrarNomePessoa(nome);

                    Console.WriteLine("Escreva seu Id: ");
                    int id = int.Parse(Console.ReadLine());
                    pessoa.Id = id;

                    var pessoaConsultada = biblioteca.ConsultarPessoaPorId(id);
                    if (pessoaConsultada != null)
                    {
                        Console.WriteLine("Pessoa já cadastrada");
                        Console.Clear();
                        MostrarMenu();
                    }
                    pessoa.CadastrarIdPessoa(id);

                    Console.Clear();
                    MostrarMenu();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Escreva o nome do livro: ");
                    string livros = Console.ReadLine();
                    livro.Titulo = livros;
                    biblioteca.CadastrarLivro(livro);

                    Console.WriteLine("Escreva o id do livro: ");
                    int id = int.Parse(Console.ReadLine());
                    livro.Id = id;

                    var livroConsultado = biblioteca.ConsultarLivroPorId(id);
                    if (livroConsultado != null) 
                    {
                        Console.WriteLine("Livro já cadastrado");
                        Console.Clear();
                        MostrarMenu();
                    }
                    livro.CadastrarIdLivro(id);

                    Console.Clear();
                    MostrarMenu();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite seu Id: ");
                    int idp = int.Parse(Console.ReadLine());
                    biblioteca.ConsultarPessoaPorId(idp);

                    var pessoaConsultada = biblioteca.ConsultarPessoaPorId(idp);
                    if (pessoaConsultada != null)
                    {
                        Console.WriteLine("Pessoa já cadastrada");
                        Console.Clear();
                        MostrarMenu();
                    }

                    Console.WriteLine("Digite o Id do livro: ");
                    int idl = int.Parse(Console.ReadLine());
                    biblioteca.ConsultarLivroPorId(idl);
                    
                    var livroConsultado = biblioteca.ConsultarLivroPorId(idl);
                    if (livroConsultado != null)
                    {
                        Console.WriteLine("Livro já cadastrado");
                        Console.Clear();
                        MostrarMenu();
                    }
                    Console.WriteLine($"O Livro {idl} foi emprestado para a pessoa {idp}");
                    Console.Clear();
                    MostrarMenu();
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Digite seu Id: ");
                    int idp = int.Parse(Console.ReadLine());
                    biblioteca.ConsultarPessoaPorId(idp);

                    var pessoaConsultada = biblioteca.ConsultarPessoaPorId(idp);
                    if (pessoaConsultada != null)
                    {
                        Console.WriteLine("Pessoa já cadastrada");
                        Console.Clear();
                        MostrarMenu();
                    }
                    
                    Console.WriteLine("Digite o Id do livro: ");
                    int idl = int.Parse(Console.ReadLine());
                    biblioteca.ConsultarLivroPorId(idl);
                    
                    var livroConsultado = biblioteca.ConsultarLivroPorId(idl);
                    if (livroConsultado != null)
                    {
                        Console.WriteLine("Livro já cadastrado");
                        Console.Clear();
                        MostrarMenu();
                    }
                    Console.WriteLine($"O Livro {idl} que estava com a pessoa {idp} foi devolvido com sucesso");
                    Console.Clear();
                    MostrarMenu();
                }
                else if (opcao == 5)
                {
                    Console.WriteLine($"Esses são todos os livros cadastrados: {biblioteca.CadastrarLivro}");
                    Console.Clear();
                }
                else if (opcao == 6)
                {
                    Console.WriteLine($"Esses são todas as pessoas cadastradas: {biblioteca.CadastrarPessoa}");
                    Console.Clear();
                }
                else if (opcao == 7)
                {
                    var livrosemp = biblioteca.EmprestarLivroBiblioteca;
                    var pessoasemp = biblioteca.ConsultarPessoaPorId;

                    Console.WriteLine($"{livrosemp} está emprestado para {pessoasemp}");
                    Console.Clear();
                    MostrarMenu();
                }
            } while (opcao == 0);
            if (opcao == 0)
            {
                Console.WriteLine("Opcão Errada");
                Console.Clear();
                MostrarMenu();
            }
        }
    }
}