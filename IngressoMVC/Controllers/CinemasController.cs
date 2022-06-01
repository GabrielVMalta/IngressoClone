using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class CinemasController : Controller
    {
        private IngressoDbContext _context;

        public CinemasController (IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Cinemas;

            return View(result);
        }

        public IActionResult Detalhes(int id)
        {
            var result = _context.Cinemas.Find(id);

            return View(result);
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
