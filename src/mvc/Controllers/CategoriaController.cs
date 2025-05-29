using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.Models.ViewModels;

namespace mvc.Controllers
{
    public class CategoriaController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        public IActionResult CafeDaManha()
        {
            var viewModel = new CategoriaViewModel
            {
                NomeCategoria = "Café da Manhã",
                Receitas = _context.Receitas
                    .Where(r => r.CategoriaId == 1) // 1 = Café da Manhã
                    .Include(r => r.Usuario) // Carrega os dados do usuário relacionado
                    .Select(r => new ReceitaComUsuario
                    {
                        Id = r.Id,
                        Titulo = r.Titulo,
                        UrlFoto = r.UrlFoto,
                        NomeUsuario = r.Usuario.Nome,
                        FotoUsuario = r.Usuario.UrlFoto,
                        CategoriaId = r.CategoriaId
                    })
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult Almoco()
        {
            var viewModel = new CategoriaViewModel
            {
                NomeCategoria = "Almoço",
                Receitas = _context.Receitas
                    .Where(r => r.CategoriaId == 2) // 2 = Almoço
                    .Include(r => r.Usuario) // Carrega os dados do usuário relacionado
                    .Select(r => new ReceitaComUsuario
                    {
                        Id = r.Id,
                        Titulo = r.Titulo,
                        UrlFoto = r.UrlFoto,
                        NomeUsuario = r.Usuario.Nome,
                        FotoUsuario = r.Usuario.UrlFoto,
                        CategoriaId = r.CategoriaId
                    })
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult Sobremesa()
        {
            var viewModel = new CategoriaViewModel
            {
                NomeCategoria = "Sobremesa",
                Receitas = _context.Receitas
                    .Where(r => r.CategoriaId == 4) // 4 = Sobremesa
                    .Include(r => r.Usuario) // Carrega os dados do usuário relacionado
                    .Select(r => new ReceitaComUsuario
                    {
                        Id = r.Id,
                        Titulo = r.Titulo,
                        UrlFoto = r.UrlFoto,
                        NomeUsuario = r.Usuario.Nome,
                        FotoUsuario = r.Usuario.UrlFoto,
                        CategoriaId = r.CategoriaId
                    })
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult Jantar()
        {
            var viewModel = new CategoriaViewModel
            {
                NomeCategoria = "Jantar",
                Receitas = _context.Receitas
                    .Where(r => r.CategoriaId == 3) // 3 = Jantar
                    .Include(r => r.Usuario) // Carrega os dados do usuário relacionado
                    .Select(r => new ReceitaComUsuario
                    {
                        Id = r.Id,
                        Titulo = r.Titulo,
                        UrlFoto = r.UrlFoto,
                        NomeUsuario = r.Usuario.Nome,
                        FotoUsuario = r.Usuario.UrlFoto,
                        CategoriaId = r.CategoriaId
                    })
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult Lanche()
        {
            var viewModel = new CategoriaViewModel
            {
                NomeCategoria = "Lanche",
                Receitas = _context.Receitas
                    .Where(r => r.CategoriaId == 5) // 5 = Lanche
                    .Include(r => r.Usuario) // Carrega os dados do usuário relacionado
                    .Select(r => new ReceitaComUsuario
                    {
                        Id = r.Id,
                        Titulo = r.Titulo,
                        UrlFoto = r.UrlFoto,
                        NomeUsuario = r.Usuario.Nome,
                        FotoUsuario = r.Usuario.UrlFoto,
                        CategoriaId = r.CategoriaId
                    })
                    .ToList()
            };

            return View(viewModel);
        }
    }
}
