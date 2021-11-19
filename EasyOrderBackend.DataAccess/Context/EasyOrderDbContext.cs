using EasyOrderBackend.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.DataAccess.Context
{
    class EasyOrderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Database=EasyOrderDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
