using mvc.Models.Domain;

namespace mvc.Models.ViewModels
{
    public class PerfilViewModel
    {
        public Usuario Usuario { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Receita> ReceitasSalvas { get; set; }
    }
}
