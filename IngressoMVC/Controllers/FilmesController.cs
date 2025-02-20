﻿using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.RequestDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class FilmesController : Controller
    {
        private IngressoDbContext _context;

        public FilmesController (IngressoDbContext context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Filmes);
        }

        public IActionResult Detalhes(int id)
        {
            var result = _context.Filmes.Find(id);

            return View(result);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostFilmeDTO filmeDTO)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Nome == filmeDTO.NomeCinema);
            if (cinema == null) return View();

            var produtor = _context.Produtores.FirstOrDefault(p => p.Nome == filmeDTO.NomePodutor);
            if (produtor == null) return View();

            Filme filme = new Filme
                (
                    filmeDTO.Titulo,
                    filmeDTO.Descricao,
                    filmeDTO.Preco,
                    filmeDTO.ImageURL,
                    cinema.Id,
                    produtor.Id
                );

            _context.Add(filme);
            _context.SaveChanges();

            //Incluir Relacionamentos
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Atualizar(int id)
        {
            return View();
        }
        
        public IActionResult Deletar(int id)
        {
            return View();
        }
    }
}
