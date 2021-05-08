using Microsoft.AspNetCore.Mvc;
using Site.Data;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _context;

        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Aron",
                DtaNascimento = DateTime.Now,
                Email = "aron_rissato@hotmail.com"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return View();
        }
    }
}
