using Senai_CZBooksWebAPI.Contexts;
using Senai_CZBooksWebAPI.Domains;
using Senai_CZBooksWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        CZBooksContext ctx = new CZBooksContext();
        public void Atualizar(int id, Autor autorAtualizado)
        {
            throw new NotImplementedException();
        }

        public Autor BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Autor novoAutor)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Autor> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
