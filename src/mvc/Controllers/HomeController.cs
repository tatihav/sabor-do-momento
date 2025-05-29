using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.Models.ViewModels;

namespace mvc.Controllers
{
    public class HomeController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inicio(int? categoriaId, int? tagId)
        {
            var query = _context.Receitas
                .Include(r => r.Usuario)
                .Include(r => r.Categoria)
                .Include(r => r.ReceitaHasTags)
                    .ThenInclude(rht => rht.Tag)
                .Where(r => r.Aprovada)
                .AsQueryable();

            // Aplicar filtros se existirem
            if (categoriaId.HasValue)
            {
                query = query.Where(r => r.CategoriaId == categoriaId.Value);
            }

            if (tagId.HasValue)
            {
                query = query.Where(r => r.ReceitaHasTags.Any(t => t.TagId == tagId.Value));
            }

            var viewModel = new InicioViewModel
            {
                TituloPagina = "Página Inicial",
                Receitas = query.Select(r => new ReceitaComUsuarioInicio
                {
                    Id = r.Id,
                    Titulo = r.Titulo,
                    UrlFoto = r.UrlFoto,
                    NomeUsuario = r.Usuario.Nome,
                    FotoUsuario = r.Usuario.UrlFoto,
                    CategoriaId = r.CategoriaId,
                }).ToList(),
                Categorias = _context.Categorias.ToList(),
                Tags = _context.Tags.ToList(),
                CategoriaSelecionada = categoriaId,
                TagSelecionada = tagId
            };

            return View(viewModel);
        }
    }
}