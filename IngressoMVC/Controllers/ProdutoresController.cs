using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class ProdutoresController : Controller
    {
        private IngressoDbContext _context;

        public ProdutoresController (IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Produtores;

            return View(result);
        }

        public IActionResult Detalhes(int id)
        {
            var result = _context.Produtores.Find(id);

            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostProdutorDTO produtorDTO)
        {
            Produtor produtor = new Produtor(produtorDTO.Nome, produtorDTO.Bio, produtorDTO.FotoPerfilURL);

            _context.Produtores.Add(produtor);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }
    }
}
