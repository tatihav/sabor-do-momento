using mvc.Models.Domain;

namespace mvc.Models.ViewModels
{
    public class CategoriaViewModel
    {
        public string NomeCategoria { get; set; }
        public List<ReceitaComUsuario> Receitas { get; set; } = new List<ReceitaComUsuario>();
    }

    public class ReceitaComUsuario
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string UrlFoto { get; set; }
        public string NomeUsuario { get; set; }
        public string FotoUsuario { get; set; }
        public int CategoriaId { get; set; }
    }
}
