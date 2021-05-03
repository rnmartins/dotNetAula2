using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotNetAula2.Tabela;

namespace dotNetAula2.Data
{
    public class MeuContexto : DbContext
    {
        public MeuContexto(DbContextOptions<MeuContexto> opcoes) : base(opcoes)
        {
            
        }

        public DbSet<Produto> Produto { get; set; }
    }
}