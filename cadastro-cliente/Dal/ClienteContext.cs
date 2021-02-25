using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using cadastro_cliente.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.Entity;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace cadastro_cliente.Dal
{
    [System.Data.Entity.DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
        public ClienteContext() : base() { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}
