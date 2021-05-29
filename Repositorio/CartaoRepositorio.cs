using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoVirtual.Data;
using CartaoVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace CartaoVirtual.Repositorio
{
    public class CartaoRepositorio : ICartaoRepositorio
    {
        private readonly Context _context;

        public CartaoRepositorio(Context context)
        {
            _context = context;
        }

        public async Task<Cartao> Create(Cartao cartao)
        {
            _context.Cartoes.Add(cartao);
            await _context.SaveChangesAsync();

            return cartao;
        }
        public async Task<IEnumerable<Cartao>> Get(string email)
        {
            return await _context.Cartoes.ToListAsync();
        }



    }
}
