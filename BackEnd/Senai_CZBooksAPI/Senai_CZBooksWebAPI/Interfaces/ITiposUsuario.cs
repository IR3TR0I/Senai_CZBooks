using System;
using System.Collections.Generic;
using Senai_CZBooksWebAPI.Domains;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Interfaces
{
    interface ITiposUsuario
    {
        List<TiposUsuario> Listar();


        TiposUsuario BuscarPorId(int id);

        void Cadastrar(TiposUsuario novoTipoUsuario);

        void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado);

        void Deletar(int id);
    }
}
