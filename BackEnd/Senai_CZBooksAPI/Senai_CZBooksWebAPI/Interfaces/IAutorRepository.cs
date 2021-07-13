using Senai_CZBooksWebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Interfaces
{
    interface IAutorRepository
    {
        List<Autor> Listar();
        Autor BuscaPorId(int id);

        void Cadastrar(Autor novoAutor);

        void Atualizar(int id, Autor autorAtualizado);

        void Deletar(int id);
    }
}
