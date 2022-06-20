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
            if (!ModelState.IsValid || !atorDTO.FotoPerfilURL.EndsWith(".jpg"))
            {
                return View(atorDTO);
            }
            //instanciar um novo ator que recebe os dados -- ok
            Ator ator = new Ator(atorDTO.Nome, atorDTO.Bio, atorDTO.FotoPerfilURL);

            //gravar esse ator no banco de dados -- ok
            _context.Atores.Add(ator);

            //salvar as mudanças -- ok
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int id)
        {
            // buscar o ator na view
            // passar o ator na view
            return View();
        }

        public IActionResult Deletar(int id)
        {
            // buscar o ator no banco
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            // buscar o ator na view
            if (result == null) return View();

            return View(result);
        }

        [HttpDelete, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            _context.Atores.Remove(result);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
