using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoVirtual.Data;
using CartaoVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CartaoVirtual.Repositorio;


namespace CartaoVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartoesController : ControllerBase
    {

        private readonly ICartaoRepositorio _cartaoRepositorio;
        public CartoesController(ICartaoRepositorio cartaoRepositorio)
        {
            _cartaoRepositorio = cartaoRepositorio;
        }

        [HttpGet("Listar Cartao - {email}")]
        public async Task<IEnumerable<Cartao>> GetCartoesPorEmail(string email)
        {
            var cartoes = await _cartaoRepositorio.Get(email);
            var cartoesTitular = from c in cartoes
                                 where c.EmailTitular == email
                                 orderby c.DataCriacao
                                 select c;

            return cartoesTitular;
        }

        [HttpPost("Criar Novo Cartao - {email}")]
        public async Task<ActionResult<Cartao>> PostCartao(string email)
        {
            Cartao cartao = new Cartao(email);
            var novoCartao = await _cartaoRepositorio.Create(cartao);
            return novoCartao;
        }

    }
}

