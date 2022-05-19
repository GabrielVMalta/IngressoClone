using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Cinema : IEntidade
    {
        public Cinema(string nome, string descricao, string logoUrl)
        {
            Nome = nome;
            Descricao = descricao;
            LogoUrl = logoUrl;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string LogoUrl { get; private set; }
        
        public List<Filme> Filmes { get; set; }
    }
}
