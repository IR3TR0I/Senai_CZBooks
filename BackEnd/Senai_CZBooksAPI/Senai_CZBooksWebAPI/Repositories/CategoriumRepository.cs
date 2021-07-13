using Senai_CZBooksWebAPI.Contexts;
using Senai_CZBooksWebAPI.Domains;
using Senai_CZBooksWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Repositories
{
    public class CategoriumRepository : ICategoriumRepository
    {
        CZBooksContext ctx = new CZBooksContext();
        public void Atualizar(int id, Categorium CategoriumAtualizada)
        {
            throw new NotImplementedException();
        }

        public Categorium BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Categorium novaCategorium)
        {
            ctx.Categoria.Add(novaCategorium);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categorium> Listar()
        {
            return ctx.Categoria.ToList();
        }
    }
}
