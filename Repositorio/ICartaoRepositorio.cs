using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartaoVirtual.Models
{
    interface ICartaoRepositorio
    {
        Task<IEnumerable<Cartao>> Get(string email);
        Task<Cartao> Create(Cartao cartao);

    }
}
