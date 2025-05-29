using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Models.Domain
{
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Ingredientes { get; set; }

        public string ModoPreparo { get; set; }

        public bool Aprovada { get; set; }

        public string UrlFoto { get; set; }

        public int TempoPreparo { get; set; }

        public int UsuarioId { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        public ICollection<ReceitaHasTag> ReceitaHasTags { get; set; } = new List<ReceitaHasTag>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public ICollection<Curtida> Curtidas { get; set; } = new List<Curtida>();
        public ICollection<ReceitaSalva> ReceitasSalvas { get; set; } = new List<ReceitaSalva>();
    }
}
