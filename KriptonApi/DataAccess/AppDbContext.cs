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
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<TipoCuenta> TipoCuentas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<TipoTransaccion> TipoTransaccions { get; set; }
        public DbSet<Conversion> Conversions { get; set; }
        public DbSet<TipoConversion> TipoConversions { get; set; }
        public DbSet<Criptomoneda> Criptomonedas { get; set; }
        
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

