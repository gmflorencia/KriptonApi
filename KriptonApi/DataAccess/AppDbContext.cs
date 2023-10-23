﻿using KriptonApi.Entities;
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
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<TipoCuenta> TipoCuenta { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
        public DbSet<TipoTransaccion> TipoTransaccion { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
        public DbSet<Criptomoneda> Criptomoneda { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
            {
                new UsuarioSeeder(),
                new CuentaSeeder(),
                new TipoCuentaSeeder(),
                new TransaccionSeeder(),
                new TipoTransaccionSeeder(),
                new CotizacionSeeder(),
                new MonedaSeeder(),
                new CriptomonedaSeeder(),
                
            };
            foreach (var seeder in seeders)
            {
                seeder.SeedDataBase(modelBuilder);
            }
        }
    }
}

