using System.ComponentModel.DataAnnotations;

namespace mvc.Models.Domain
{
    public enum Perfil
    {
        Admin,
        User
    }

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public string? UrlFoto { get; set; } 

        [Required(ErrorMessage = "Obrigatório informar Perfil!")]
        public Perfil Perfil { get; set; }

        public bool Ativo { get; set; } = true;

        public ICollection<ReceitaSalva> ReceitasSalvas { get; set; } = new List<ReceitaSalva>();
        public ICollection<Receita> Receitas { get; set; } = new List<Receita>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public ICollection<Curtida> Curtidas { get; set; } = new List<Curtida>();
    }
}
