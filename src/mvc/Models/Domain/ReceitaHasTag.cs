using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Models.Domain
{
    public class ReceitaHasTag
    {
        [Key]
        public int Id { get; set; }

        public int TagId { get; set; }

        public int ReceitaId { get; set; }

        [ForeignKey("TagId")]
        public Tag Tag { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }
    }
}
