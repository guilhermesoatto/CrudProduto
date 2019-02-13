using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SW.Models.Dados;

namespace SW.Models
{
    public class SWContext : DbContext
    {
        public SWContext (DbContextOptions<SWContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produto { get; set; }
    }
}
