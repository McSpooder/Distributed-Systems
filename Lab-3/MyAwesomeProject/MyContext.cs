using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MyAwesomeProject
{
    class MyContext : DbContext
    {
        public DbSet<Person> people { get; set; }
        public DbSet<Address> addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EFLab");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
