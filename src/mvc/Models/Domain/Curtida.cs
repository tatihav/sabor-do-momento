using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Models.Domain
{
    public class Curtida
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int ReceitaId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }
    }
}
