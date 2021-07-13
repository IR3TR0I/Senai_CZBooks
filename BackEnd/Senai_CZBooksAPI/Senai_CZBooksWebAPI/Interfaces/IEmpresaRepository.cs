using Senai_CZBooksWebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Interfaces
{
    interface IEmpresaRepository
    {
        List<Empresa> Listar();

        Empresa BuscarPorId(int id);

        void Cadastrar(Empresa novaEmpresa);

        void Atualizar(int id, Empresa EmpresaAtualizada);

        void Deletar(int id);
    }
}
