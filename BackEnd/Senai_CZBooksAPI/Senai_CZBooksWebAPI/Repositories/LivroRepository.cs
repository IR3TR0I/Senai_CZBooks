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
            throw new NotImplementedException();
        }

        public Livro BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro novoLivro)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Livro> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
