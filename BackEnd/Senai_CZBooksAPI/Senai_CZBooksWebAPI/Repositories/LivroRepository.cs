using Microsoft.EntityFrameworkCore;
using Senai_CZBooksWebAPI.Contexts;
using Senai_CZBooksWebAPI.Domains;
using Senai_CZBooksWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        CZBooksContext ctx = new CZBooksContext();
        public void Atualizar(int id, Livro LivroAtualizado)
        {
            //Busca um livro por id 
            Livro livroBuscado = ctx.Livros.Find(id);

            //Titulo do livro informado
            if (LivroAtualizado.Titulo != null)
            {
                livroBuscado.Titulo = LivroAtualizado.Titulo;
            }

            // Categoria do livro
            if (LivroAtualizado.IdCategoria != null)
            {
                livroBuscado.IdCategoria = LivroAtualizado.IdCategoria;
            }

            //Autor
            if (LivroAtualizado.Autor != null)
            {
                livroBuscado.Autor = LivroAtualizado.Autor;
            }

            //sinopse

            if (LivroAtualizado.Sinopse != null)
            {
                livroBuscado.Sinopse = LivroAtualizado.Sinopse;
            }

            //preço
            if (LivroAtualizado.Preco != null)
            {
                livroBuscado.Preco = LivroAtualizado.Preco;
            }

            ctx.Livros.Update(livroBuscado);

            ctx.SaveChanges();
        }

        public Livro BuscarPorId(int id)
        {
            return ctx.Livros.FirstOrDefault(e => e.IdLivros == id);
        }

        public void Cadastrar(Livro novoLivro)
        {
            ctx.Livros.Add(novoLivro);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Livros.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Livro> Listar()
        {
            return ctx.Livros

                .Include(e => e.Autor)
                .Include(e => e.IdCategoria)
                .ToList();
        }
    }
}
