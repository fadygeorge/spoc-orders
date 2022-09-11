using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spoc1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Data
{
    public class Context: IdentityDbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Agent> Agents { get; set; }

        public DbSet<Pharmacy> Pharmacies { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Distributor> Distributors { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
