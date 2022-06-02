using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.Request
{
    public class PostCinemaDTO
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string LogoUrl { get; private set; }
    }
}
