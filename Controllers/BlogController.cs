using JoinBike_Site.Models;
using JoinBike_SITE.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace JoinBike_Site.Controllers
{
    public class BlogController : Controller
    {       
        private readonly IUsuarioRepositorio _usuariorepositorio;

        public BlogController(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuariorepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            _usuariorepositorio.Adicionar(usuario);
            return RedirectToAction("Index");
        }
    }
}
