using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("cadastro")]
    public class CadastroController : Controller
    {
        [Route("lista")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Busca()
        {
            return View();
        }
    }
}
