using mvc.Models.Domain;

namespace mvc.Models.ViewModels
{
    public class PesquisaViewModel
    {
        public List<ReceitaUsuario> Receitas { get; set; } = new List<ReceitaUsuario>();
    }

    public class ReceitaUsuario
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string UrlFoto { get; set; }
        public string NomeUsuario { get; set; }
        public string FotoUsuario { get; set; }
        public int CategoriaId { get; set; }
    }
}
