using CartaoVirtual.Data;
using CartaoVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartaoVirtual.Data
{
    public class Context : DbContext
    {
        public DbSet<Cartao> Cartoes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbCartaoVirtual;Data Source=SOFIA-PC\SQLEXPRESS");
        }

    }
}


