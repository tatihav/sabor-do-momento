using System.ComponentModel.DataAnnotations;

namespace mvc.Models.Domain
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<ReceitaHasTag> ReceitaHasTags { get; set; } = new List<ReceitaHasTag>();
    }
}
