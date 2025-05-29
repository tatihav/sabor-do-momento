using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mvc.Models.Domain
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
