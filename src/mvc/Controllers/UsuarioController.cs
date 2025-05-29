using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    [Authorize]
    public class UsuarioController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
