using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BO;

namespace TpDojo.Data
{
    public class TpDojoContext : DbContext
    {
        public TpDojoContext (DbContextOptions<TpDojoContext> options)
            : base(options)
        {
        }

        public DbSet<BO.Arme> Arme { get; set; } = default!;

        public DbSet<BO.Samurai> Samurai { get; set; }
    }
}
