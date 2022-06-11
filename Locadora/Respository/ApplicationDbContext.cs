using Locadora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Respository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> TabelaDeUsuarios { get; set; }
        public DbSet<Filme> TabelaDeFilmes { get; set; }
        public DbSet<Serie> TabelaDeSeries { get; set; }
        public DbSet<Conta> TabelaDeContas { get; set; }

        // contrutor == builder em inglês
        protected override void OnConfiguring(
            DbContextOptionsBuilder construtor)
        {
            // string de conexão
            // são informações para se contectar com o BD
            // o servidor
            // o nome do bando de dados
            // forma de conectar (usuário/senha)
            string conexao = "Server=localhost\\SQLEXPRESS;" +
                "Database=Locadora;Integrated Security=SSPI";
            construtor.UseSqlServer(conexao);
        }
    }
}
