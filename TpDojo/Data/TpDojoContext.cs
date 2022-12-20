using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BO;
using System.Reflection.Metadata;

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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Samurai>()
                .HasOne(s => s.Arme)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
