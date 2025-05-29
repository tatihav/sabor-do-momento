using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Models.Domain
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        public string TextoComentario { get; set; }

        public int ReceitaId { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
