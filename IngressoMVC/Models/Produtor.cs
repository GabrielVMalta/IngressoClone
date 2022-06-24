using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Produtor : Artista
    {
        public Produtor (string nome, string bio, string fotoPerfilURL) : base(nome, bio, fotoPerfilURL)
        {

        }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string FotoPerfilURL { get; set; }
        public List<Filme> Filmes { get; set; }
        public void AtualizarDados(string nome, string bio, string fotoPerfilURL)
        {
            Nome = nome;
            Bio = bio;
            FotoPerfilURL = fotoPerfilURL;
            DataAlteracao = System.DateTime.Now;
        }
    }
}
