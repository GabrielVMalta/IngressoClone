using IngressoMVC.Data;
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
