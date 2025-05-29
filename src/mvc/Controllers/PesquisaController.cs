using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.Models.Domain;
using mvc.Models.ViewModels;

namespace mvc.Controllers
{
    public class PesquisaController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;
        public IActionResult Index(string termo)
        {
            ViewBag.TermoPesquisa = termo;

            if (string.IsNullOrWhiteSpace(termo))
            {
                return View(new PesquisaViewModel { Receitas = new List<ReceitaUsuario>() });
            }

            termo = termo.Trim().ToLower();

            var receitas = _context.Receitas
                .Include(r => r.Usuario)
                .Include(r => r.Categoria)
                .Include(r => r.ReceitaHasTags)
                    .ThenInclude(rht => rht.Tag)
                .Where(r => r.Aprovada) // Só mostra receitas aprovadas
                .AsEnumerable() // Mudar para client-side para usar ToLower()
                .Where(r =>
                    r.Titulo.ToLower().Contains(termo) ||
                    r.Categoria.Nome.ToLower().Contains(termo) ||
                    r.ReceitaHasTags.Any(t => t.Tag.Nome.ToLower().Contains(termo)))
                .Select(r => new ReceitaUsuario
                {
                    Id = r.Id,
                    Titulo = r.Titulo,
                    UrlFoto = r.UrlFoto,
                    NomeUsuario = r.Usuario.Nome,
                    FotoUsuario = r.Usuario.UrlFoto,
                    CategoriaId = r.Categoria.Id

                })
                .ToList();

            return View(new PesquisaViewModel { Receitas = receitas });
        }
    }
}
