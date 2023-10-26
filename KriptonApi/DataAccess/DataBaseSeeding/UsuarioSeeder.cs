﻿using KriptonApi.Entities;
using KriptonApi.Helpers;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class UsuarioSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    IdUsuario = 1,
                    Nombre = "Martin",
                    Apellido = "Cabrera",
                    Dni = 31467581,
                    Email = "martin@gmail.com",
                    Clave = ClaveEncryptHelper.EncryptClave("1234", "martin@gmail.com"),
                    Activo = true

                },
                new Usuario
                {
                    IdUsuario = 2,
                    Nombre = "Florencia",
                    Apellido= "Gonzalez",
                    Dni = 37053098,
                    Email = "florencia@gmail.com",
                    Clave = ClaveEncryptHelper.EncryptClave("1234", "florencia@gmail.com"),
                    Activo = true
                },
                new Usuario
                {
                    IdUsuario = 3,
                    Nombre = "Salome",
                    Apellido = "Cabrera",
                    Dni = 58706438,
                    Email = "salome@gmail.com",
                    Clave = ClaveEncryptHelper.EncryptClave("1234", "salome@gmail.com"),
                    Activo = true

                });
        }
    }
}
