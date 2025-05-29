using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using mvc.Models;
using mvc.Models.Domain;
using System.Security.Claims;


namespace mvc.Controllers
{
    public class AuthController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuth");
            return RedirectToAction("Login", "Auth");
        }

        [AllowAnonymous]
        public IActionResult Cadastro()
        {
            ViewData["SemLayout"] = true;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Cadastro(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            usuario.UrlFoto = null;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string email, string senha, string? returnUrl)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Ativo);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(senha, usuario.Senha))
            
            {
                ViewBag.Erro = "Usuário ou senha inválidos.";
                return View();

            }
            
            var claims = new List<Claim>
{
    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
    new Claim(ClaimTypes.Name, usuario.Nome),
    new Claim(ClaimTypes.Email, usuario.Email),
    new Claim(ClaimTypes.Role, usuario.Perfil.ToString())
};

            var identity = new ClaimsIdentity(claims, "CookieAuth");
            var principal = new ClaimsPrincipal(identity);
            var props = new AuthenticationProperties
            
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync("CookieAuth",principal, props);
                return RedirectToAction( "MeuPerfil", "Perfil" );
                    
            

        }
    }

}
