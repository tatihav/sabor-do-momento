using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.Models.Domain;
using mvc.Models.ViewModels;
using System.IO;
using System.Security.Claims;



[Authorize]
public class PerfilController : Controller
{
    private readonly AppDbContext _context;

    public PerfilController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Editar(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario == null) return NotFound();

        return View(usuario);
    }

    [HttpPost]
    public IActionResult Editar(Usuario usuario, IFormFile fotoPerfil)
    {


        // Buscar usuário original do banco
        var usuarioDb = _context.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
        if (usuarioDb == null) return NotFound();

        // Atualizar campos modificáveis
        usuarioDb.Nome = usuario.Nome;
        usuarioDb.Email = usuario.Email;
        if (!string.IsNullOrWhiteSpace(usuario.Senha))
            usuarioDb.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

        // Se tiver foto nova, salvar
        if (fotoPerfil != null && fotoPerfil.Length > 0)
        {
            var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "perfil");
            Directory.CreateDirectory(pasta);
            var extensao = Path.GetExtension(fotoPerfil.FileName);
            var nomeArquivo = $"{Guid.NewGuid()}{extensao}";
            var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
            {
                fotoPerfil.CopyTo(stream);
            }

            usuarioDb.UrlFoto = $"img/perfil/{nomeArquivo}";
        }

        _context.SaveChanges();
        TempData["Sucesso"] = "Perfil atualizado com sucesso!";
        return RedirectToAction("MeuPerfil", "Perfil");
    }

    public IActionResult Index()
    {

        var email = User.FindFirst(ClaimTypes.Email)?.Value;
        var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);

        if (usuario == null) return NotFound();

        return RedirectToAction("MeuPerfil");
    }
    public IActionResult Detalhes(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario == null) return NotFound();

        return View(usuario);
    }
    [AllowAnonymous]
    public IActionResult Excluir(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario == null) return NotFound();

        return View(usuario);
    }

    [HttpPost, ActionName("Excluir")]
    [AllowAnonymous]
    public IActionResult ExcluirConfirmado(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario == null) return NotFound();

        usuario.Ativo = false;
        _context.SaveChanges();

        return RedirectToAction("Index", "Home");
    }
    [AllowAnonymous]
    public IActionResult AcessDenied()
    {
        return View();
    }
    [Authorize]
    public IActionResult MeuPerfil()
    {
        var email = User.FindFirst(ClaimTypes.Email)?.Value;
        var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);
        if (usuario == null) return NotFound();

        var receitasSalvas = _context.ReceitasSalvas
     .Where(rs => rs.UsuarioId == usuario.Id)
     .Include(rs => rs.Receita)
         .ThenInclude(r => r.Usuario)
     .Select(rs => rs.Receita)
     .ToList();

        var viewModel = new PerfilViewModel
        {
            Usuario = usuario,
            Categorias = _context.Categorias.ToList(),
            Tags = _context.Tags.ToList(),
            ReceitasSalvas = receitasSalvas
        };

        return View("Index", viewModel);
    }
    // Listar receitas pendentes
    [Authorize(Roles = "Admin")]
    public IActionResult ReceitasPendentes()
    {
        var receitas = _context.Receitas
            .Where(r => !r.Aprovada)
            .Include(r => r.Usuario)
            .Include(r => r.Categoria)
            .ToList();

        return View(receitas);
    }

    // Aprovar receita
    [Authorize(Roles = "Admin")]
    public IActionResult Aprovar(int id)
    {
        var receita = _context.Receitas.FirstOrDefault(r => r.Id == id);
        if (receita == null) return NotFound();

        receita.Aprovada = true;
        _context.SaveChanges();

        return RedirectToAction("ReceitasPendentes");
    }

    // Excluir receita
    [Authorize(Roles = "Admin")]
    public IActionResult ExcluirReceita(int id)
    {
        var receita = _context.Receitas.FirstOrDefault(r => r.Id == id);
        if (receita == null) return NotFound();
        var tagsRelacionadas = _context.ReceitaHasTags
    .Where(rt => rt.ReceitaId == id).ToList();

        _context.ReceitaHasTags.RemoveRange(tagsRelacionadas);


        _context.Receitas.Remove(receita);
        _context.SaveChanges();

        return RedirectToAction("ReceitasPendentes");
    }



}

