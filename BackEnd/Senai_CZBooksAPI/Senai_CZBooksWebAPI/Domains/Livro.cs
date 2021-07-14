using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_CZBooksWebAPI.Domains
{
    public partial class Livro
    {
        
        public int IdLivros { get; set; }
        public int? IdAutor { get; set; }
        
        [Required(ErrorMessage = "É necessário o id da categoria ")]
        public int? IdCategoria { get; set; }

        [Required(ErrorMessage = "É necessário um título para o livro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "É necessário uma sinopse para o livro")]
        public string Sinopse { get; set; }

        [Required(ErrorMessage = "É necessário o nome do autor que escreveu este livro")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "É necessário incluir o preço do livro")]
        public double? Preco { get; set; }

        [Required(ErrorMessage = "É necessário incluir a data de lançamento do livro")]
        public string DataPublicação { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categorium IdCategoriaNavigation { get; set; }
    }
}
