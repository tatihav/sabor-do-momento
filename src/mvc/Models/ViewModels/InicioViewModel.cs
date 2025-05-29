using mvc.Models.Domain;
using System.Collections.Generic;

namespace mvc.Models.ViewModels
{
    public class InicioViewModel
    {
        public string TituloPagina { get; set; }
        public List<ReceitaComUsuarioInicio> Receitas { get; set; } = new List<ReceitaComUsuarioInicio>();
        public List<Categoria> Categorias { get; set; } = new List<Categoria>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public int? CategoriaSelecionada { get; set; }
        public int? TagSelecionada { get; set; }
    }

    public class ReceitaComUsuarioInicio
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string UrlFoto { get; set; }
        public string NomeUsuario { get; set; }
        public string FotoUsuario { get; set; }
        public int CategoriaId { get; set; }
    }
}