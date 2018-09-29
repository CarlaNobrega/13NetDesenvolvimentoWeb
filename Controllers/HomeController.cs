using FIAP01.Data;
using FIAP01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP01.Controllers
{
    public class HomeController : Controller
    {
        private PerguntasContext _context;

        public HomeController(PerguntasContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //ViewBag.Nome = "Carla";
            //ViewData["NomeDoAluno"] = $"Outro Nome: {DateTime.Now.ToString()}";

            //var pergunta = new Pergunta() { ID = 1, Descricao = "Que horas é a chamada?", Autor = "Daniel" };

            return View(_context.Perguntas.ToList());

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                await _context.SaveChangesAsync();
                var a = pergunta;
            }
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }


    }
}
