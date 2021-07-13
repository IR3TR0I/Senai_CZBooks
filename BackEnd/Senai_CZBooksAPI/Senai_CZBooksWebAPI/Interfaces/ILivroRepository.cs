using Senai_CZBooksWebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Interfaces
{
    interface ILivroRepository
    {
        List<Livro> Listar();
        Livro BuscarPorId(int id);
        void Cadastrar(Livro novoLivro);

        void Atualizar(int id, Livro LivroAtualizado);

        void Deletar(int id);
    }
}
