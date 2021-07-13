using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooksWebAPI.Domains
{
    public partial class Autor
    {
        public Autor()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdAutor { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
