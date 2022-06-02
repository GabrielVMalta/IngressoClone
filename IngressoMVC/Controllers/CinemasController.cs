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

        public IActionResult Detalhes(string nome)
        {
            var result = _context.Cinemas.Find(nome);

            return View(result);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostCinemaDTO cinemaDTO)
        {
            Cinema cinema = new Cinema(cinemaDTO.Nome, cinemaDTO.Descricao, cinemaDTO.LogoUrl);
            _context.Cinemas.Add(cinema);
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
