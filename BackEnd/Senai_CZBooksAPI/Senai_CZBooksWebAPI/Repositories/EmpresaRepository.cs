using Senai_CZBooksWebAPI.Contexts;
using Senai_CZBooksWebAPI.Domains;
using Senai_CZBooksWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        CZBooksContext ctx = new CZBooksContext();
        public void Atualizar(int id, Empresa EmpresaAtualizada)
        {
            Empresa empresaBuscada = ctx.Empresas.Find(id);

            if (EmpresaAtualizada.Endereço != null)
            {
                empresaBuscada.Endereço = EmpresaAtualizada.Endereço;
            }

            if (EmpresaAtualizada.NomeEmpresa != null)
            {
                empresaBuscada.NomeEmpresa = EmpresaAtualizada.NomeEmpresa;
            }

            ctx.Empresas.Update(empresaBuscada);

            ctx.SaveChanges();
        }

        public Empresa BuscarPorId(int id)
        {
            return ctx.Empresas.FirstOrDefault(i => i.IdEmpresas == id);
        }

        public void Cadastrar(Empresa novaEmpresa)
        {
            ctx.Empresas.Add(novaEmpresa);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Empresas.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Empresa> Listar()
        {
            return ctx.Empresas.ToList();
        }
    }
}
