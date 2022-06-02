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
    public class CategoriasController : Controller
    {

        private IngressoDbContext _context;

        public CategoriasController (IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Categorias;

            return View(result);
        }

        public IActionResult Detalhes(int id)
        {
            var result = _context.Categorias.Find(id);

            return View(result);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostCategoriaDTO categoriaDTO)
        {
            //receber os dados - ok

            //validar os dados
            //instanciar novo ator
            Categoria categoria = new Categoria(categoriaDTO.Nome);
            //instanciar um novo ator que recebe os dados -- ok
            _context.Categorias.Add(categoria);

            //gravar esse ator no banco de dados

            //salvar as mudanças -- ok
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
