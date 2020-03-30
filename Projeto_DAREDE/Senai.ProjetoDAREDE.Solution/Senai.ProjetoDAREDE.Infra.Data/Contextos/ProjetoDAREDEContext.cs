using Microsoft.EntityFrameworkCore;
using Senai.ProjetoDAREDE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Infra.Data.Contextos
{
    public class ProjetoDAREDEContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }
        public DbSet<ServicosDominio> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //João => colocar as informações abaixo para usar o SQL Server
                //optionsBuilder.UseSqlServer("")
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(
                new UsuarioDominio
            {
                Id = 1, 
                Nome = "Flavio",
                Email = "flavio.rescia@darede.com.br",
                Senha = "123123",
                CPF = "",
                NomeEmpresa = "DAREDE",
                IdTipoCliente = 1,
                // se for em grupo continua abaixo.
                NomeGrupo = "",
                Holding = "",
                IdTipoHold = "",


            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
