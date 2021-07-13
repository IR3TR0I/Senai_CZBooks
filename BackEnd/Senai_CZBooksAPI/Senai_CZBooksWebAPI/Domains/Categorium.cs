﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooksWebAPI.Domains
{
    public partial class Categorium
    {
        public Categorium()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
