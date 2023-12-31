﻿using Microsoft.EntityFrameworkCore;


namespace RestWithASPNET.Model.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Seguro> Seguros{ get; set; }
    }
}
