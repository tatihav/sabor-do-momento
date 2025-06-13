using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.Models.Domain;
using mvc.Models.ViewModels;
using System.Security.Claims;

namespace mvc.Controllers
{
    public class ReceitaController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        public IActionResult Detalhes(int? id, int? idCategoria)
        {
            if (id == null || idCategoria == null)
            {
                return NotFound();
            }

            // Busca a receita principal com todos os relacionamentos necessários
            var receitaPrincipal = _context.Receitas
                .Include(r => r.Usuario)
                .Include(r => r.Comentarios)
                    .ThenInclude(c => c.Usuario)
                .Include(r => r.Curtidas)
                .FirstOrDefault(r => r.Id == id);

            if (receitaPrincipal == null)
            {
                return NotFound();
            }

            var viewModel = new ReceitaViewModel
            {
                // Dados da receita principal
                ReceitaId = receitaPrincipal.Id,
                CategoriaId = receitaPrincipal.CategoriaId,
                ReceitaTitulo = receitaPrincipal.Titulo,
                ReceitaFoto = receitaPrincipal.UrlFoto,
                UsuarioNome = receitaPrincipal.Usuario.Nome,
                UsuarioFoto = receitaPrincipal.Usuario.UrlFoto,
                Curtidas = receitaPrincipal.Curtidas.Count,
                TempoPreparo = receitaPrincipal.TempoPreparo,
                Ingredientes = receitaPrincipal.Ingredientes,
                ModoPreparo = receitaPrincipal.ModoPreparo,


                // Comentários da receita
                Comentarios = receitaPrincipal.Comentarios
                    .OrderByDescending(c => c.Id)
                    .ToList(),

                // Receitas recomendadas (da mesma categoria)
                ReceitasRecomendadas = _context.Receitas
                 .Where(r => r.CategoriaId == idCategoria && r.Id != id) // Exclui a receita atual
                 .Take(4) // Limita a 4 receitas recomendadas
                 .Include(r => r.Usuario)
                 .Select(r => new ReceitasRecomendadas
                 {
                     Id = r.Id,
                     Titulo = r.Titulo,
                     UrlFoto = r.UrlFoto,
                     NomeUsuario = r.Usuario.Nome,
                     FotoUsuario = r.Usuario.UrlFoto,
                     CategoriaId = r.CategoriaId,
                 })
                 .ToList(),
                Tags = _context.ReceitaHasTags
            .Where(rt => rt.ReceitaId == id)
            .Include(rt => rt.Tag)
            .Select(rt => rt.Tag)
            .ToList()
            };

            return View(viewModel);
        }
        [HttpGet]
        public IActionResult Nova()
        {
            var vm = new NovaReceitaViewModel
            {
                Categorias = _context.Categorias.ToList(),
                Tags = _context.Tags.ToList(),
                CategoriaId = null,
                TagIds = new List<int>()
            };
            return View(vm);

        }

        [HttpPost]
        public IActionResult Nova(NovaReceitaViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Categorias = _context.Categorias.ToList();
                vm.Tags = _context.Tags.ToList();
                return View(vm);
            }

            // Pega usuário logado
            var emailUsuario = User.FindFirst(ClaimTypes.Email)?.Value;
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == emailUsuario);
            if (usuario == null) return Unauthorized();

            var novaReceita = new Receita
            {
                Titulo = vm.Titulo,
                Ingredientes = string.Join(",", vm.Ingredientes),
                ModoPreparo = vm.Modopreparo,
                CategoriaId = vm.CategoriaId.Value,
                UsuarioId = usuario.Id,
                Aprovada = false,
                TempoPreparo = 0
            };

            // Salva a imagem
            if (vm.Foto != null && vm.Foto.Length > 0)
            {
                var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "receitas");
                Directory.CreateDirectory(pasta);
                var nomeArquivo = $"{Guid.NewGuid()}{Path.GetExtension(vm.Foto.FileName)}";
                var caminho = Path.Combine(pasta, nomeArquivo);
                using (var stream = new FileStream(caminho, FileMode.Create))
                {
                    vm.Foto.CopyTo(stream);
                }
                novaReceita.UrlFoto = $"img/receitas/{nomeArquivo}";
            }

            _context.Receitas.Add(novaReceita);
            _context.SaveChanges();

            // Tags
            if (vm.TagIds != null && vm.TagIds.Any())
            {
                foreach (var tagId in vm.TagIds)
                {
                    _context.ReceitaHasTags.Add(new ReceitaHasTag
                    {
                        ReceitaId = novaReceita.Id,
                        TagId = tagId
                    });
                }
                _context.SaveChanges();
            }

            return RedirectToAction("Detalhes", "Receita", new { id = novaReceita.Id, idCategoria = vm.CategoriaId });
        }
        [HttpGet]
        public JsonResult Curtidas(int id)
        {
            var total = _context.Curtidas.Count(c => c.ReceitaId == id);
            return Json(new { curtidas = total });
        }
        // curtir receitas
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CurtirAjax([FromBody] CurtidaRequest request)
        {
            var usuarioId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (usuarioId == null)
            {
                return Json(new { sucesso = false, mensagem = "É necessário estar logado para curtir." });
            }

            int userId = int.Parse(usuarioId);
            int receitaId = request.Id;

            var receita = _context.Receitas.Include(r => r.Curtidas).FirstOrDefault(r => r.Id == receitaId);
            if (receita == null)
            {
                return Json(new { sucesso = false, mensagem = "Receita não encontrada." });
            }

            var curtida = _context.Curtidas.FirstOrDefault(c => c.UsuarioId == userId && c.ReceitaId == receitaId);

            if (curtida != null)
            {
                _context.Curtidas.Remove(curtida);
            }
            else
            {
                _context.Curtidas.Add(new Curtida
                {
                    UsuarioId = userId,
                    ReceitaId = receitaId
                });
            }

            _context.SaveChanges();

            var totalCurtidas = _context.Curtidas.Count(c => c.ReceitaId == receitaId);

            return Json(new { sucesso = true, curtidas = totalCurtidas });
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(int id)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (usuarioId == null)
                return Json(new { success = false, message = "Não autenticado" });
            int userId = int.Parse(usuarioId);
            bool jaSalvou = _context.ReceitasSalvas.Any(rs => rs.UsuarioId == userId && rs.ReceitaId == id);
            if (!jaSalvou)
            {
                _context.ReceitasSalvas.Add(new ReceitaSalva
                {
                    UsuarioId = userId,
                    ReceitaId = id
                });
                _context.SaveChanges();
            }




            return Json(new { success = true, message = "Receita salva com sucesso!" });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoverSalva(int id)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (usuarioId == null)
                return RedirectToAction("Login", "Auth");

            int userId = int.Parse(usuarioId);

            var receitaSalva = _context.ReceitasSalvas
                .FirstOrDefault(rs => rs.UsuarioId == userId && rs.ReceitaId == id);

            if (receitaSalva != null)
            {
                _context.ReceitasSalvas.Remove(receitaSalva);
                _context.SaveChanges();
            }

            return RedirectToAction("MeuPerfil", "Perfil");
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Comentar(int receitaId, string textoComentario)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (usuarioId == null || string.IsNullOrWhiteSpace(textoComentario))
                return RedirectToAction("Detalhes", new { id = receitaId });

            var comentario = new Comentario
            {
                TextoComentario = textoComentario,
                ReceitaId = receitaId,
                UsuarioId = int.Parse(usuarioId)
            };

            _context.Comentarios.Add(comentario);
            _context.SaveChanges();

            var categoriaId = _context.Receitas
    .Where(r => r.Id == receitaId)
    .Select(r => r.CategoriaId)
    .FirstOrDefault();

            return RedirectToAction("Detalhes", new { id = receitaId, idCategoria = categoriaId });
        }


    }
}
