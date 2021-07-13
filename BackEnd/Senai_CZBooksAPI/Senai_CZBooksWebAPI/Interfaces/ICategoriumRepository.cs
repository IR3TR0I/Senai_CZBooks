using Senai_CZBooksWebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Interfaces
{
    interface ICategoriumRepository
    {
        List<Categorium> Listar();

        Categorium BuscarPorId(int id);

        void Cadastrar(Categorium novaCategorium);

        void Atualizar(int id, Categorium CategoriumAtualizada);

        void Deletar(int id);
    }
}
