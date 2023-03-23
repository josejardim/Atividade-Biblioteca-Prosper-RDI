﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int QuantidadeExemplares { get; set; }
        
        public void EmprestarLivro(int quantidadeEmprestada)
        {
            QuantidadeExemplares -= quantidadeEmprestada;
        }
        public void DevolverLivro(int quantidadeDevolvida)
        {
            QuantidadeExemplares += quantidadeDevolvida;
        }
        public void CadastrarIdLivro (int id)
        {
            Id += id;
        }
        public string ObterNomeLivro()
        {
            return Titulo;
        }
        public string ObterAutorLivro() 
        {
            return Autor; 
        }
        public int ObterIdLivro()
        {
            return Id;
        }
    }
}
