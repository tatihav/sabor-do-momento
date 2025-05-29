using Microsoft.AspNetCore.Http;
using mvc.Models.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models.ViewModels
{
    public class NovaReceitaViewModel
    {
        [Required]
        public string Titulo { get; set; }

        public IFormFile Foto { get; set; }

        [Required]
        public List<string> Ingredientes { get; set; } = new();

        [Required]
        public string Modopreparo { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria")]
        public int? CategoriaId { get; set; }

        public List<int> TagIds { get; set; } = new List<int>();

        // População das listas
        public List<Categoria> Categorias { get; set; } = new();
        public List<Tag> Tags { get; set; } = new();
    }
}
