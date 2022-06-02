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
    public class AtoresController : Controller
    {
        private IngressoDbContext _context;

        public AtoresController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Atores);
        }

        public IActionResult Detalhes(int id)
        {
            var result = _context.Atores.Find(id);

            return View(result);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostAtorDTO atorDTO)
        {
            //receber os dados - ok

            //validar os dados
            //instanciar novo ator
            Ator ator = new Ator(atorDTO.Nome, atorDTO.Bio, atorDTO.FotoPerfilURL);
            //instanciar um novo ator que recebe os dados -- ok
            _context.Atores.Add(ator);

            //gravar esse ator no banco de dados

            //salvar as mudanças -- ok
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar()
        {
            // buscar o ator na view
            // passar o ator na view
            return View();
        }

        public IActionResult Deletar(int id)
        {
            // buscar o ator no banco
            // buscar o ator na view
            return View();
        }
    }
}
