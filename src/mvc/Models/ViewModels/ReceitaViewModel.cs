using mvc.Models.Domain;

namespace mvc.Models.ViewModels
{
    public class ReceitaViewModel
    {
        public int ReceitaId { get; set; }
        public string ReceitaTitulo {  get; set; }
        public string ReceitaFoto { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioFoto { get; set; }
        public int Curtidas { get; set; }
        public int TempoPreparo { get; set; }
        public string Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
        public List<Tag> Tags { get; set; }
        public int CategoriaId { get; set; }

        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();


        public List<ReceitasRecomendadas> ReceitasRecomendadas { get; set; } = new List<ReceitasRecomendadas>();
    }

    public class ReceitasRecomendadas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string UrlFoto { get; set; }
        public string NomeUsuario { get; set; }
        public string FotoUsuario { get; set; }
        public int CategoriaId { get; set; }
    }
}
