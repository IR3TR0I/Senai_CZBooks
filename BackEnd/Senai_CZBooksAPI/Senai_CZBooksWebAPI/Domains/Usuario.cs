using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooksWebAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Autors = new HashSet<Autor>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TiposUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Autor> Autors { get; set; }
    }
}
