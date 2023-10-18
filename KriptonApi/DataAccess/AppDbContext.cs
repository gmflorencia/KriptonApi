using KriptonApi.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using KriptonApi.DataAccess.DataBaseSeeding;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
            {
                new UsuarioSeeder(),
                
            };
            foreach (var seeder in seeders)
            {
                seeder.SeedDataBase(modelBuilder);
            }
        }
    }
}

