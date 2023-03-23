# Atividade-Biblioteca-Prosper-RDI
Criação de um programa que simula a gestão de uma biblioteca.

Classe 1 - Livro
Atributos
● Id (int)
● Titulo (string)
● Autor (string)
● Editora (string)
● QuantidadeExemplares (int)
Métodos
● EmprestarLivro(int quantidadeEmprestada) - Deverá decrementar a
QuantidadeExemplares do livro ;
● DevolverLivro(int quantidadeDevolvida) - Deverá incrementar a
QuantidadeExemplares do livro;

Classe 2 - Pessoa
Atributos
● Id (int)
● Nome (string)
● Cpf (string)
● Telefone (string)
● LivrosEmprestados (List<Livros>)
Métodos
● AdicionarLivroLista(Livro)
● RemoverLivroLista(int idLivro)

Classe 3 - Biblioteca
Atributos
● Pessoas (List<Pessoa>)
● Livros (List<Livros>)
Métodos:

● CadastrarPessoa(Pessoa) - Deverá incluir uma pessoa na lista Pessoas do objeto
Biblioteca;
● CadastrarLivro(Livro) - Deverá incluir um livro na lista de Livros do objeto Biblioteca;
● EmprestarLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método
EmprestarLivro do objeto Livro e Adicionar um Livro na lista LivrosEmprestados do
objeto Pessoa através do método AdicionarLivroLista;
● DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método
DevolverLivro do objeto Livro e Remover um Livro na lista LivrosEmprestados do
objeto Pessoa através do método RemoverLivroLista;

Após a criação das classes, será necessário preparar a “interface” para que o sistema
atenda ao usuário da biblioteca. A interface deverá funcionar da seguinte forma:
1. Deverá possuir um “Menu” com as 7 opções:
a. 1 - Cadastrar Pessoa
b. 2 - Cadastrar Livro
c. 3 - Emprestar Livro
d. 4 - Devolver Livro
e. 5 - Listar todos os livros
f. 6 - Listar todas as pessoas cadastradas
g. 7 - Listar todos os livros emprestados
2. De acordo com a opção selecionada pelo o usuário, o sistema terá os seguintes
comportamentos:
a. 1 - Cadastrar Pessoa
i. O sistema deverá Solicitar ao usuário todos os dados da Pessoa,
para que os atributos da classe sejam preenchidos;
ii. O Id da pessoa será informado manualmente pelo usuário;
iii. Se o Id informado já existir na lista de pessoas da biblioteca, o
sistema deverá exibir a mensagem “Pessoa já cadastrada” e então
retornar ao menu principal do sistema;
iv. Ao cadastrar, a lista de livros emprestados para aquela pessoa
deverá estar então vazia;
v. Após o cadastro, retornar ao menu principal.
b. 2 - Cadastrar Livro
i. O sistema deverá Solicitar ao usuário todos os dados do Livro, para
que os atributos da classe sejam preenchidos;
ii. O Id do Livro será informado manualmente pelo usuário;
iii. Se o Id informado já existir na lista de livros da biblioteca, o sistema
deverá exibir a mensagem “Livro já cadastrado” e então retornar ao
menu principal do sistema;
iv. Após o cadastro, retornar ao menu principal.
c. 3 - Emprestar Livro
i. Para o empréstimo o sistema deve solicitar o Id da Pessoa e o Id do
Livro;
ii. Se o Id da pessoa não estiver cadastrado deverá exibir a mensagem
“Pessoa não cadastrada” e então retornar ao menu principal;

iii. Se o Id do livro não estiver cadastrado deverá exibir a mensagem
“Livro não cadastrado” e então retornar ao menu principal;
iv. Após o usuário informar um ID de livro e Pessoa válidos, mostrar a
mensagem: “O Livro {nome do livro} foi emprestado para a pessoa
{nome da pessoa}” e então retornar para o menu principal.

d. 4 - Devolver Livro
i. Para a devolução o sistema deve solicitar o Id da Pessoa e o Id do
Livro;
ii. Se o Id da pessoa não estiver cadastrado deverá exibir a mensagem
“Pessoa não cadastrada” e então retornar ao menu principal;
iii. Se o Id do livro não estiver cadastrado deverá exibir a mensagem
“Livro não cadastrado” e então retornar ao menu principal;
iv. Após o usuário informar um ID de livro e Pessoa válidos, mostrar a
mensagem: “O Livro {nome do livro} que estava com a pessoa {nome
da pessoa} foi devolvido com sucesso” e então retornar para o menu
principal.
e. 5 - Listar todos os livros
i. Nesta opção o sistema deverá listar todos os livros cadastrados no
sistema

f. 6 - Listar todas as pessoas cadastradas
i. Nesta opção o sistema deverá listar todos as pessoas cadastrados no
sistema

g. 7 - Listar todos os livros emprestados
i. Nesta opção, o sistema deverá percorrer as listas de todos os livros
emprestados de cada pessoa e então os imprimir na tela da seguinte
forma: “{Nome do Livro} está emprestado para {nome da pessoa}”
