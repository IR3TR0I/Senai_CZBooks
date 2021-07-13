using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_CZBooksWebAPI.Domains;
using Senai_CZBooksWebAPI.Interfaces;
using Senai_CZBooksWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private ILivroRepository _livroRepository { get; set; }

        public LivroController()
        {
            _livroRepository = new LivroRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_livroRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        //Cadastro só ADM
        [Authorize(Roles ="1")]
        [HttpPost]
        public IActionResult Post(Livro novoLivro)
        {
            try
            {
                _livroRepository.Cadastrar(novoLivro);

                return StatusCode(201);
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Livro novoLivro)
        {
            try
            {
                _livroRepository.Atualizar(id, novoLivro);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

    }
}
