using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooksWebAPI.Domains
{
    public partial class Livro
    {
        public int IdLivros { get; set; }
        public int? IdAutor { get; set; }
        public int? IdCategoria { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Autor { get; set; }
        public double? Preco { get; set; }
        public string DataPublicação { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categorium IdCategoriaNavigation { get; set; }
    }
}
