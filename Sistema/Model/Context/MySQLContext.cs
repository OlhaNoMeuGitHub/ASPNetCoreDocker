using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Model.Context
{

    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pontos> Pontos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
    }
}
